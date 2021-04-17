using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl_Multas.Clases
{
    public abstract class Multa
    {
        protected Conductor sancionado;
        protected Vehiculo vehiculo;
        private ulong valor;
        protected DateTime fecha_hora;
        protected ulong consecutivo;

        protected Multa(Conductor sancionado, Vehiculo vehiculo)
        {
            Random nro = new Random();

            this.sancionado = sancionado;
            this.vehiculo = vehiculo;
            fecha_hora = DateTime.Now;
            consecutivo = (ulong)nro.Next(100000, 1000000);
        }

        protected ulong Valor 
        { 
            get => valor;
            set
            {
                if (value < 0)
                    throw new Exception("El valor no puede ser menor que cero.");
                else
                    valor = value;
            }    
        }
    }
}
