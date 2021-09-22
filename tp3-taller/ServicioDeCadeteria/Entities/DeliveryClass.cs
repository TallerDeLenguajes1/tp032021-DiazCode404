using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServicioDeCadeteria.Entities;//agrego esto para usar la clase OrderClass
namespace ServicioDeCadeteria.Entities
{
    public class DeliveryClass
    {
        private string deliveryMan_id;
        private string deliveryMan_name;
        private string deliveryMan_adress;
        private string deliveryMan_telephone;
        private List<OrderClass> deliveryMan_orderList;

        public DeliveryClass()
        {
        }

        public DeliveryClass(string deliveryMan_id, string deliveryMan_name, string deliveryMan_adress, string deliveryMan_telephone)
        {
            this.DeliveryMan_id = deliveryMan_id;
            this.DeliveryMan_name = deliveryMan_name;
            this.DeliveryMan_adress = deliveryMan_adress;
            this.DeliveryMan_telephone = deliveryMan_telephone;
            this.DeliveryMan_orderList = new List<OrderClass>();
        }

        public string DeliveryMan_id { get => deliveryMan_id; set => deliveryMan_id = value; }
        public string DeliveryMan_name { get => deliveryMan_name; set => deliveryMan_name = value; }
        public string DeliveryMan_adress { get => deliveryMan_adress; set => deliveryMan_adress = value; }
        public string DeliveryMan_telephone { get => deliveryMan_telephone; set => deliveryMan_telephone = value; }
        public List<OrderClass> DeliveryMan_orderList { get => deliveryMan_orderList; set => deliveryMan_orderList = value; }

        //funcion para agregar un pedido a la lista de pedidos del cadete
        public void AddOrder(OrderClass order)
        {
            deliveryMan_orderList.Add(order);
        }
    }
}
