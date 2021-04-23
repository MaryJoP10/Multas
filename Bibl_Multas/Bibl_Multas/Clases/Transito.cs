using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl_Multas.Clases
{
    public class Transito
    {
        private ulong val_sal_min = 920000;
        private string direccion;
        private ulong telefono;
        private List<Multa> l_multas;

        public Transito(string direccion, ulong telefono)
        {
            l_multas = new List<Multa>();
            Direccion = direccion;
            Telefono = telefono;
        }

        public string Direccion 
        { 
            get => direccion;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("La dirección no puede ser nula o estar en blanco.");
                else
                    direccion = value;
            }    
        }
        public ulong Telefono 
        { 
            get => telefono; 
            set
            {
                if (value > 9999999)
                    telefono = value;
                else
                    throw new Exception("El telefono no es valido, debe de tener más de 7 digitos.");
            } 
        }
        public List<Multa> L_multas 
        { 
            get => l_multas;
            set
            {
                l_multas = value;
            }
        }
        public ulong Val_sal_min
        {
            get => val_sal_min;
        }
        public ulong[] Totalizar_multas()
        {
            try
            {
                ulong[] total_multas = new ulong[2] {0, 0};
                foreach (Multa elemento in l_multas)
                {
                    if (elemento is Mayor)
                        total_multas[0] += elemento.Valor;
                    else
                        total_multas[1] += elemento.Valor;
                }
                return total_multas;
            }
            catch(Exception error)
            {
                throw new Exception("Se presentó un error totalizando multas "+error);
            }
        }
    }
}
