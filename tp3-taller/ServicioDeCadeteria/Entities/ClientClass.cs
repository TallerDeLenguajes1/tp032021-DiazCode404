using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServicioDeCadeteria.Entities;//agrego esto para usar la clase order y crear un pedido

namespace ServicioDeCadeteria.Entities
{
    /***
     * En esta seccion se recibiran todos los datos de la vista pedidos para registrar los clientes que realicen pedidos
     * ***/
    public class ClientClass
    {
        private string id;
        private string name;
        private string adress;
        private string telephone;
        

        public ClientClass(string id, string name, string adress, string telephone)
        {
            this.Id = id;
            this.Name = name;
            this.Adress = adress;
            this.Telephone = telephone;
            
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Telephone { get => telephone; set => telephone = value; }
    }
}
