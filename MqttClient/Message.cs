using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MqttClient
{
    public class Message
    {
        static public int Item { get; set; }
        public string Topic { get; set; }
        public string Payload { get; set; }
        public string QoS { get; set; }

        public Message(string topic, string payload, string qos)
        {
            Topic = topic;
            Payload = payload;
            QoS = qos;
            Item++;
        }
    }
}
