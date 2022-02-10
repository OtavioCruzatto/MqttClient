using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace MqttClient
{
    public partial class Form1 : Form
    {

        private MqttFactory factory;
        private IMqttClient mqttClient;
        private List<Message> messages = new List<Message>();
        private bool newMessage = false;
        private bool newSubscription = false;
        StringBuilder log = new StringBuilder();
        List<string> subscriptions = new List<string>();

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;

            factory = new MqttFactory();
            mqttClient = factory.CreateMqttClient();

            InitSubscriptionListView();
            InitComboBoxes();
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
                log.AppendLine($"{DateTime.Now}: Client '{mqttClient.Options.ClientId}' receiving data from the topic '{topic}'.");
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
                    log.AppendLine($"{DateTime.Now}: Client '{mqttClient.Options.ClientId}' publishing data to the topic '{message.Topic}'.");
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
                    log.AppendLine($"{DateTime.Now}: Client '{mqttClient.Options.ClientId}' subscribing in the topic '{options.Topic}'.");
                    subscriptions.Add(options.Topic);
                    newSubscription = true;
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

        private void UpdateSubscriptionListView()
        {
            
            if ((newSubscription == true) && (subscriptions.Count > 0))
            {
                int item = subscriptions.Count - 1;
                newSubscription = false;
                var viewItem = new ListViewItem();
                viewItem.Text = subscriptions.Count.ToString();
                viewItem.SubItems.Add(subscriptions[item]);
                listviewSubSubscriptions.Items.Add(viewItem);
                listviewSubSubscriptions.EnsureVisible(item);
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateGrid();
            UpdateSubscriptionListView();
            txtboxLog.Text = log.ToString();
            
        }

        private void SetDisconnection(IMqttClientOptions options)
        {
            btnConnect.Text = "Connect";
            pbConnectionStatus.Value = 0;
            log.AppendLine($"{DateTime.Now}: Client '{options.ClientId}' disconnected of the broker.");
        }

        private void SetConnection(IMqttClientOptions options)
        {
            btnConnect.Text = "Disconnect";
            pbConnectionStatus.Value = 100;
            log.AppendLine($"{DateTime.Now}: Client '{options.ClientId}' connected to the broker.");
        }

        private void txtboxLog_TextChanged(object sender, EventArgs e)
        {
            txtboxLog.SelectionStart = txtboxLog.Text.Length;
            txtboxLog.ScrollToCaret();
        }

        private void PopulateQosComboBox(ComboBox cb)
        {
            cb.Items.Add("[0] - At most once");
            cb.Items.Add("[1] - At least once");
            cb.Items.Add("[2] - Exactly once");
        }

        private void InitSubscriptionListView()
        {
            listviewSubSubscriptions.Columns.Add("Item");
            listviewSubSubscriptions.Columns.Add("Topic", 150);
            listviewSubSubscriptions.Columns.Add("Qos");
            listviewSubSubscriptions.GridLines = true;
        }

        private void InitComboBoxes()
        {
            PopulateQosComboBox(comboboxPubQoS);
            PopulateQosComboBox(comboboxSubQoS);
            PopulateQosComboBox(comboboxLwtQos);
        }
    }
}
