﻿using System;
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
        private Multa l_multas;

        public Transito(string direccion, ulong telefono)
        {
            this.Direccion = direccion;
            this.Telefono = telefono;
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
        public Multa L_multas 
        { 
            get => l_multas;
        }
    }
}