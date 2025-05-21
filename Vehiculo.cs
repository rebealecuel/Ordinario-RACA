﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinario_RACA
{
    internal class Vehiculo
    {


        public Vehiculo(int iD, string marca, string modelo, int año, string color)
        {
            ID = iD;
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Color = color;
        }

        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Color { get; set; }
    }
}
