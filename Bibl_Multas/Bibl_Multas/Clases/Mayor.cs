using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibl_Multas.Interfaces;

namespace Bibl_Multas.Clases
{
    public class Mayor:Multa, ITrabajoSocial, IAnularLicencia
    {
        public enum lista_mayores { Soat_Vencido, Tecnico_Mecanica_Vencida, Manejar_Embriagado };

        public lista_mayores infraccion_mayor;
        public Mayor(Conductor sancionado, Vehiculo vehiculo, lista_mayores infraccion_mayor, ulong val_sal_min) : base(sancionado, vehiculo)
        {
            this.infraccion_mayor = infraccion_mayor;

            Valor = Calcular_sancion(val_sal_min);
        }

        public override ulong Calcular_sancion(ulong val_sal_min)
        {
            try
            {
                return val_sal_min * 15;
            }
            catch (Exception error)
            {
                throw new Exception("\nOcurrió un error en imponer la sanción para la multa mayor \n" + error);
            }
        }
        public string Asignar_TrabajoSocial()
        {
            try
            {
                Random nro = new Random();
                switch (nro.Next(1, 4))
                {
                    case 1:
                        return "Su servicio social se realizara en Biblioteca.";
                    case 2:
                        return "Su servicio social se realizara en Parque.";
                    case 3:
                        return "Su servicio social se realizara en Ciclovias.";
                    default:
                        return "Opción no válida.";
                }
            }
            catch (Exception error)
            {
                throw new Exception("\nOcurrió un error en imponer el trabajo social \n" + error);
            }
        }
        public string Anular_licencia()
        {
            try
            {
                if (sancionado.Estado_licencia == Conductor.l_estado_licencia.Activa)
                { 
                    sancionado.Estado_licencia = Conductor.l_estado_licencia.Suspendida;
                return "La licencia ha sido suspendida.";
                }
                else
                    return "El conductor andaba con la licencia suspendida, detenerlo.";
            }
            catch (Exception error)
            {
                throw new Exception("\nOcurrió un error en anular la licencia \n" + error);
            }
        }
        public override string ToString()
        {
            return infraccion_mayor + " " + Valor; 
        }
    }
}
