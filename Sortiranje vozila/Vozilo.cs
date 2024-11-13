﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sortiranje_vozila
{
    internal class Vozilo
    {
        
        // Svojstva
        public string Marka { get; set; }
        public string Model { get; set; }
        public int GodinaProizvodnje { get; set; }
        public int Kilometraza { get; set; }

        // Konstruktor
        public Vozilo(string marka, string model, int godinaProizvodnje, int kilometraza)
        {
            Marka = marka;
            Model = model;
            GodinaProizvodnje = godinaProizvodnje;
            Kilometraza = kilometraza;
        }

        // Override ToString metode za lakše prikazivanje
        public override string ToString()
        {
            return $"{Marka} - {Model} - {GodinaProizvodnje} - {Kilometraza}";
        }


    }

    
}
