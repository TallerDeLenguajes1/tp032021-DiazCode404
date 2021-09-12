using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace tp3_taller.Entidades
{
    public class Cadete : Persona
    {
        public Cadete(string nombreCadete, string direccionCadete, string telefonoCadete) : base(nombreCadete, direccionCadete,telefonoCadete)
        {

        }
       
        public void GuardarCadete(List<Cadete> cadetes)
        {
            string _path = @"C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\tp3-taller\Archivos";

            string CadetesJson = JsonConvert.SerializeObject(cadetes.ToArray(), Formatting.Indented);
            File.WriteAllText(_path, CadetesJson);
        }
        
    }
}
