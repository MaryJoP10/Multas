using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibl_Multas.Clases;
using System.IO;

namespace Multas.Clases
{
    class Archivo
    {
        private List<Conductor> l_conductores = new List<Conductor>();

        public List<Conductor> Cargar_Archivo(string nombre_archivo)
        {
            try
            {
                Conductor conductor;
                StreamReader archivo;

                string linea;
                string[] info_conductores;

                archivo = new StreamReader(nombre_archivo);
                linea = archivo.ReadLine();

                while (linea != null)
                {
                    info_conductores = linea.Split('|');
                    conductor = new Conductor((Conductor.l_tipo_id)Enum.Parse(typeof(Conductor.l_tipo_id), info_conductores[0]), info_conductores[1], info_conductores[2], byte.Parse(info_conductores[3]));

                    l_conductores.Add(conductor);
                    linea = archivo.ReadLine();
                }
                return l_conductores;
            }
            catch (Exception)
            {
                throw new Exception("\nError al cargar el archivo de conductores.");
            }
        }
    }
}
