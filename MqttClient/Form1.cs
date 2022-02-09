using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MqttClient
{
    public partial class Form1 : Form
    {

        private MqttFactory factory;
        private IMqttClient mqttClient;
        private List<Message> messages;
        private bool newMessage = false;
        StringBuilder log;

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;

            factory = new MqttFactory();
            mqttClient = factory.CreateMqttClient();
            messages = new List<Message>();
            log = new StringBuilder();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {

            var options = new MqttClientOptionsBuilder()
                    .WithClientId(txtboxClientId.Text)
                    .WithTcpServer(txtboxTcpServer.Text, int.Parse(txtboxPort.Text))
                    .WithCredentials(txtboxUsername.Text, txtboxPassword.Text)
                    .WithTls()
                    .WithCleanSession()
                    .Build();

            if (mqttClient.IsConnected)
            {
                await mqttClient.DisconnectAsync();
                SetDisconnection(options);
            }
            else
            {
                try
                {
                    await mqttClient.ConnectAsync(options, CancellationToken.None);
                    if (mqttClient.IsConnected)
                    {
                        SetConnection(options);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please, verify the content of the fields.", "Connection failed.");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }

            mqttClient.UseApplicationMessageReceivedHandler(e =>
            {
                var topic = e.ApplicationMessage.Topic;
                var payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                var qos = ((int)e.ApplicationMessage.QualityOfServiceLevel).ToString();
                messages.Add(new Message(topic, payload, qos));
                newMessage = true;
                log.AppendLine($"{DateTime.Now} Client '{mqttClient.Options.ClientId}' receiving data from the topic '{topic}'.");
            });
        }

        private async void btnPublish_Click(object sender, EventArgs e)
        {
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(txtboxPublishTopic.Text)
                .WithPayload(txtboxPayload.Text)
                .WithAtMostOnceQoS()
                .Build();

            if (mqttClient.IsConnected)
            {
                try
                {
                    await mqttClient.PublishAsync(message, CancellationToken.None);
                    log.AppendLine($"{DateTime.Now} Client '{mqttClient.Options.ClientId}' publishing data to the topic '{message.Topic}'.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }

            }
        }

        private async void btnSubscribe_Click(object sender, EventArgs e)
        {
            var options = new MqttTopicFilterBuilder()
                .WithTopic(txtboxSubscribeTopic.Text)
                .WithAtMostOnceQoS()
                .Build();

            if (mqttClient.IsConnected)
            {
                try
                {
                    await mqttClient.SubscribeAsync(options);
                    log.AppendLine($"{DateTime.Now} Client '{mqttClient.Options.ClientId}' subscribing in the topic '{options.Topic}'.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        private void UpdateGrid()
        {
            if ((newMessage == true) && (messages.Count > 0))
            {
                newMessage = false;
                gridviewMessages.Rows.Add(
                    Message.Item,
                    messages[messages.Count - 1].Topic,
                    messages[messages.Count - 1].Payload,
                    messages[messages.Count - 1].QoS);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateGrid();
            txtboxLog.Text = log.ToString();
            
        }

        private void SetDisconnection(IMqttClientOptions options)
        {
            btnConnect.Text = "Connect";
            pbConnectionStatus.Value = 0;
            log.AppendLine($"{DateTime.Now} Client '{options.ClientId}' disconnected of the broker.");
        }

        private void SetConnection(IMqttClientOptions options)
        {
            btnConnect.Text = "Disconnect";
            pbConnectionStatus.Value = 100;
            log.AppendLine($"{DateTime.Now} Client '{options.ClientId}' connected to the broker.");
        }

    }
}
