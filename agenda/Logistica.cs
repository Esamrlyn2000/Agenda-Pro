﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
    public class Logistica
    {
        private Acceso _acceso;

        public Logistica()
        {
            _acceso = new Acceso();
        }

        public Contacto SalvaContactos(Contacto contacto)
        {
            if (contacto.Id == 0)
            {
                //_acceso.InsertarContacto
            }
            
            else
               // _acceso.ActualizaContacto
        }
    }
}
