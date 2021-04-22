using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibl_Multas.Interfaces;

namespace Bibl_Multas.Clases
{
    public class Menor : Multa, IRestarPuntos
    {
        public enum lista_menores { Mal_Estacionado, Luces, Exceso_Velocidad}

        public lista_menores infraccion_menor;

        public Menor(Conductor sancionado, Vehiculo vehiculo, lista_menores infraccion_menor, ulong val_sal_min) : base(sancionado, vehiculo)
        {
            this.infraccion_menor = infraccion_menor;

            Valor = Calcular_sancion(val_sal_min);
        }

        public override ulong Calcular_sancion(ulong val_sal_min)
        {
            try
            {
                return val_sal_min * 3;
            }
            catch (Exception error)
            {
                throw new Exception("\nOcurrió un error en imponer la sanción para la multa menor \n" + error);
            }
        }
        public uint Restar_Puntos()
        {
            try
            {
                if (sancionado.Total_puntos >= 1000)
                    return sancionado.Total_puntos -= 1000;
                else
                    throw new Exception("\nEl conductor no tiene puntos suficientes para restarle \n");
            }
             catch (Exception error)
            {
                throw new Exception("\nOcurrió un error en restar puntos de licencia \n" + error);
            }
        }
        public override string ToString()
        {
            return infraccion_menor + " " + Valor;
        }
    }
}
