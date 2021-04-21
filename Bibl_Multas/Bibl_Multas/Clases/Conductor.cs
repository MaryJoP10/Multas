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
        private uint total_puntos = 50000;

        public Conductor(l_tipo_id tipo_id, string id, string nombre, byte edad)
        {
            Random alea = new Random();

            this.tipo_id = tipo_id;
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Nro_licencia = nro_licencia;
            estado_licencia = l_estado_licencia.Activa;
        }

        public ulong Nro_licencia
        {
            get => nro_licencia;
            set
            {
                if (value < 100000 || value > 999999)
                    throw new Exception("El número de licencia no es valido");
                else
                    nro_licencia = value;
            }
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
        public uint Total_puntos { get => total_puntos; set => total_puntos = value; }
        internal l_estado_licencia Estado_licencia { get => estado_licencia; set => estado_licencia = value; }

        public override string ToString()
        {
            return tipo_id + " " +nro_licencia+ " " +nombre+ " "+edad;
        }
    }
}
