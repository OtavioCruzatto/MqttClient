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

        public Form1()
        {
            InitializeComponent();

            factory = new MqttFactory();
            mqttClient = factory.CreateMqttClient();
            messages = new List<Message>();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {

            try
            {
                var options = new MqttClientOptionsBuilder()
                .WithClientId(txtboxClientId.Text)
                .WithTcpServer(txtboxTcpServer.Text, int.Parse(txtboxPort.Text))
                .WithCredentials(txtboxCredential.Text, txtboxPassword.Text)
                .WithTls()
                .WithCleanSession()
                .Build();

                mqttClient.UseConnectedHandler(e =>
                {
                    Console.WriteLine($"Cliente {options.ClientId}: Conectado ao broker.");
                });

                mqttClient.UseDisconnectedHandler(e =>
                {
                    timer1.Enabled = false;
                    Console.WriteLine($"Cliente {options.ClientId}: Desconectado do broker.");
                });

                await mqttClient.ConnectAsync(options, CancellationToken.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique o preenchimento dos campos.", "Falha na conexão.");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            mqttClient.UseApplicationMessageReceivedHandler(e =>
            {
                var topic = e.ApplicationMessage.Topic;
                var payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                var qos = ((int)e.ApplicationMessage.QualityOfServiceLevel).ToString();
                messages.Add(new Message(topic, payload, qos));
                newMessage = true;
                Console.WriteLine($"Cliente {mqttClient.Options.ClientId}: Recebendo no topico: {topic}");
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
                    Console.WriteLine($"Cliente {mqttClient.Options.ClientId}: Publicando no topico: {message.Topic}");
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
                    timer1.Enabled = true;
                    Console.WriteLine($"Cliente {mqttClient.Options.ClientId}: Subscrevendo no topico: {options.Topic}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        private void AtualizarGrid()
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
            AtualizarGrid();
        }
    }
}
