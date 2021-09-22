using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ServicioDeCadeteria.Entities;

namespace ServicioDeCadeteria.Entities
{
    //esta clase simulara ser un repositorio para aglutinar las demas clases y objetos.
    //asi podremos llevar toda la informacion a distintas vistas
    public class BusinessClass
    {
        private List<OrderClass> orderList;
        private List<DeliveryClass> deliveryManList;

        //private static string _pathClient = @"C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\DB\ClientList.json";
        string _pathDelivery = @"C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\DB\DeliveryMan.json";
        string _pathOrder = @"C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\DB\OrderList.json";

        
        public BusinessClass()
        {
            orderList = new List<OrderClass>();//de esta forma instancio la lista de pedidos sin necesidad de estar pasandole datos?
            DeliveryManList = new List<DeliveryClass>();
        }
        public List<OrderClass> OrderList { get => orderList; set => orderList = value; }
        public List<DeliveryClass> DeliveryManList { get => deliveryManList; set => deliveryManList = value; }

        #region Writing Json
        //esta funcion guardara las lista de clientes en un archivo de formato Json
        /*
        public void SaveClientList(List<ClientClass> ClientList)
        {
            try
            {
                string ClientJson = JsonConvert.SerializeObject(ClientList.ToArray(), Formatting.Indented);

                File.WriteAllText(_pathClient, ClientJson);

            }
            catch (Exception)
            {

                throw;
            }
        }*/

        //esta funcion guardara la lista de cadetes en un formato Json
        public void SaveDeliveryMan(List<DeliveryClass> DeliveryManList)
        {
            string DeliveryJson = JsonConvert.SerializeObject(DeliveryManList.ToArray(), Formatting.Indented);

            File.WriteAllText(_pathDelivery, DeliveryJson);
        }

        //esta funcion guardara los pedidos en formato Json
        public void SaveOrders(List<OrderClass> OrderList)
        {
            string OrderJson = JsonConvert.SerializeObject(OrderList.ToArray(), Formatting.Indented);

            File.WriteAllText(_pathOrder, OrderJson);
        }

        #endregion

        /*
        public List<ClientClass> DeserializeClientList()
        {
            string ReadingClientFromFile;//esta variable hara la lectura del archivo Json de clientes y lo convertira a string
            using (var reader = new StreamReader(_pathClient))
            {
                ReadingClientFromFile = reader.ReadToEnd();//aca leo todo el archivo Json de Clientes 
            }
            
            var ClientList = JsonConvert.DeserializeObject<List<ClientClass>>(ReadingClientFromFile);//aca convierto el string en una lista y la devuelvo

            return ClientList;
        }*/
        
        public List<DeliveryClass> DeserializerDeliveryManList()
        {
            string ReadingDeliveryManFromFile;
            using(var reader = new StreamReader(_pathDelivery))
            {
                ReadingDeliveryManFromFile = reader.ReadToEnd();
            }

            var DeliveryManList = JsonConvert.DeserializeObject<List<DeliveryClass>>(ReadingDeliveryManFromFile);

            return DeliveryManList;
        }

        public List<OrderClass> DeserializerOrderList()
        {
            string ReadingOrderListFromFile;
            using (var reading = new StreamReader(_pathOrder))
            {
                ReadingOrderListFromFile = reading.ReadToEnd();
            }
            var OrderList = JsonConvert.DeserializeObject<List<OrderClass>>(ReadingOrderListFromFile);
            return OrderList;
        }
    }

}
