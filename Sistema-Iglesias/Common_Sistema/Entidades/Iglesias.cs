using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Sistema.Entidades
{
    class Iglesias: Ciudad
    {
        public int idIglesia { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int ciudad { get; set; }
        public string pastorEncargado { get; set; }
        public string nomeroTelefono { get; set; }

    }
}
