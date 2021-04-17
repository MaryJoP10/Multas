using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl_Multas.Clases
{
    public class Vehiculo
    {
        private string placa;
        private string marca;
        private string modelo;
        private DateTime ano;

        public Vehiculo(string placa, string marca, string modelo, DateTime ano)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }

        public string Placa 
        { 
            get => placa; 
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("La placa no puede ser nula o estar en blanco.");
                else
                    placa = value;
            } 
        }
        public string Marca 
        { 
            get => marca; 
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("La marca no puede ser nula o estar en blanco.");
                else
                    marca = value;
            } 
        }
        public string Modelo 
        { 
            get => modelo; 
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("El modelo no puede ser nulo o estar en blanco.");
                else
                    modelo = value;
            } 
        }
        public DateTime Ano 
        { 
            get => ano; 
            set
            {
                if (value.Year > 1930 && value.Year <= (DateTime.Today.Year + 2))
                    ano = value;
                else
                    throw new Exception("El año es invalido.");
            } 
        }
    }
}
