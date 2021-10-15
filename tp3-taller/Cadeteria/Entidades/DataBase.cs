using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Cadeteria.Entidades
{
    
    public class DataBase
    {
       // private int id = 0;
        public string carpetaArchivos = @"C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\Cadeteria\archivosBD\";
        public string path_cadete = @"C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\Cadeteria\archivosBD\listaDeCadetes.json";
        public string path_pedidos = @"C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\Cadeteria\archivosBD\listaDePedidos.json";
        //funcion que guarda un cadete en archivo

        /**********CADETES********/
        public void CrearCadete(string apellido_cadete, string nombre_cadete, string dni_cadete, string domicilio_cadete, string telefono_cadete)
        {
            int id_cadete = LeerArchivoDeCadetes().Count + 1;
            //creo mi nuevo cadete
            ClaseCadetes nuevoCadete = new ClaseCadetes(id_cadete.ToString(), apellido_cadete, nombre_cadete, domicilio_cadete, dni_cadete, telefono_cadete);
            //guardo mi cadete en archivo
            GuardarCadete(nuevoCadete);
        }

        private void GuardarCadete(ClaseCadetes cadete)
        {
            string MyJson = System.Text.Json.JsonSerializer.Serialize(cadete);

            if (!File.Exists(path_cadete))
            {
                Directory.CreateDirectory(carpetaArchivos);
                StreamWriter archivo = File.CreateText(path_cadete);
                archivo.Close();
                archivo.Dispose();
            }
            using (StreamWriter streamWriter = File.AppendText(path_cadete))
            {
                streamWriter.WriteLine(MyJson);
                streamWriter.Close();
                streamWriter.Dispose();
            }
        }

        public List<ClaseCadetes> LeerArchivoDeCadetes()
        {
            List<ClaseCadetes> lista_cadetes = new List<ClaseCadetes>();
            string leer = "";
            if (File.Exists(path_cadete))
            {
                using (StreamReader streamReader = File.OpenText(path_cadete))
                {
                    while ((leer=streamReader.ReadLine())!=null)
                    {
                        ClaseCadetes cadetes = System.Text.Json.JsonSerializer.Deserialize<ClaseCadetes>(leer);
                        lista_cadetes.Add(cadetes);
                    }
                    streamReader.Close();
                    streamReader.Dispose();
                }
                return lista_cadetes;
            }
            return lista_cadetes;
        }

        /**********PEDIDOS********/
        enum estado
        {
            Entregado,
            Cancelado,
            EnCamino
        }
        public void crearPedido(string apellido_cliente, string nombre_cliente, string domicilio_cliente, string telefono_cliente, string pedido)
        {
            int id_cliente = LeerArchivoDePedidos().Count + 1;
            ClaseCliente cliente = new ClaseCliente(id_cliente.ToString(), apellido_cliente, nombre_cliente, domicilio_cliente, telefono_cliente);
            ClasePedidos nuevo_pedido = new ClasePedidos(id_cliente.ToString(), estado.EnCamino.ToString(), cliente, pedido);
            GuardarPedido(nuevo_pedido);

        }

        public void GuardarPedido(ClasePedidos pedido)
        {
            string MyJson = System.Text.Json.JsonSerializer.Serialize(pedido);
            if (!File.Exists(path_pedidos))
            {
                Directory.CreateDirectory(carpetaArchivos);
                StreamWriter archivo = File.AppendText(path_pedidos);
                archivo.Close();
                archivo.Dispose();
            }
            using (StreamWriter streamWriter = File.AppendText(path_pedidos))
            {
                streamWriter.WriteLine(MyJson);
                streamWriter.Close();
                streamWriter.Dispose();
            }
        }
        public List<ClasePedidos> LeerArchivoDePedidos()
        {
            List<ClasePedidos> ListaDePedidos = new List<ClasePedidos>();
            string leer = "";
            if (File.Exists(path_pedidos))
            {
                using (StreamReader streamReader = File.OpenText(path_pedidos))
                {
                    while((leer = streamReader.ReadLine()) != null)
                    {
                        ClasePedidos pedido = System.Text.Json.JsonSerializer.Deserialize<ClasePedidos>(leer);
                        ListaDePedidos.Add(pedido);
                    }
                    streamReader.Close();
                    streamReader.Dispose();
                }
                return ListaDePedidos;
            }

            return ListaDePedidos;
        }
    
    
    }
}
