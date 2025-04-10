using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Segundo_Parcial
{
    internal class PrestamoArchivo
    {
        public void Guardar(string archivo, List<Prestamos> prestamos)
        {
            string json = JsonConvert.SerializeObject(prestamos);
            System.IO.File.WriteAllText(archivo, json);

        }
        public List<Prestamos> Leer(string archivo)
        {
            List<Prestamos> lista = new List<Prestamos>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Prestamos>>(json);
            return lista;
        }
    }
}
