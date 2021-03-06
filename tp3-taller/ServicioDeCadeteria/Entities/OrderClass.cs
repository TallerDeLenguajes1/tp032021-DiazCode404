using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioDeCadeteria.Entities
{
    public class OrderClass
    {
        private string order_number;
        private string order;
        private string order_status;
        private ClientClass client;
        private string deliveryId;
        private string deliveryName;

        public OrderClass(string order_number, string order, string order_status, ClientClass client)
        {
            this.Order_number = order_number;
            this.Order = order;
            this.Order_status = order_status;
            this.Client = client;
            this.DeliveryId = deliveryId;
            this.DeliveryName = DeliveryName;
            //this.Client = new ClientClass(client.Id,client.Name,client.Adress,client.Telephone);
        }

        public string Order_number { get => order_number; set => order_number = value; }
        public string Order { get => order; set => order = value; }
        public string Order_status { get => order_status; set => order_status = value; }
        public ClientClass Client { get => client; set => client = value; }
        public string DeliveryId { get => deliveryId; set => deliveryId = value; }
        public string DeliveryName { get => deliveryName; set => deliveryName = value; }

        public void AddDelivery(string delId,string delName)
        {
            deliveryId = delId;
            deliveryName = delName;
        }
    }
}
