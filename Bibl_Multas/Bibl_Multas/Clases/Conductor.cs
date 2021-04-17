using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl_Multas.Clases
{
    public class Conductor
    {
        public enum l_tipo_id { CC, PAS, TI, CE};
        public enum l_estado_licencia { Activa, Suspendida};

        private string nombre;
        private l_tipo_id tipo_id;
        private l_estado_licencia estado_licencia;
        private string id;
        private byte edad;
        private ulong nro_licencia;
        private ulong total_puntos = 50000;

        public Conductor(l_tipo_id tipo_id,  string id, string nombre, byte edad)
        {
            Random nro = new Random();

            this.tipo_id = tipo_id;
            Id = id;
            Nombre = nombre;
            Edad = edad;
            nro_licencia = (ulong)nro.Next(100000, 999999);
            estado_licencia = l_estado_licencia.Activa;
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("El nombre no puede ser nulo o estar en blanco.");
                else
                    nombre = value;
            }
        }
        public string Id 
        { 
            get => id;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("El ID no puede ser nulo o estar en blanco.");
                else
                    id = value;
            }    
        }
        public byte Edad
        {
            get => edad;
            set
            {
                if (value < 16 || value > 90)
                    throw new Exception("Personas de esa edad no pueden tener licencia.");
                else
                    edad = value;
            }
        }
        public ulong Total_puntos { get => total_puntos; set => total_puntos = value; }
        internal l_estado_licencia Estado_licencia { get => estado_licencia; set => estado_licencia = value; }
    }
}
