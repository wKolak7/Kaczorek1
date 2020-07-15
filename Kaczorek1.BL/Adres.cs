﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek1.BL
{
    public class Adres
    {
        public Adres()
        {

        }
        public Adres(int adresId)
        {
            AdresId = adresId;
        }
        public int AdresId { get; private set; }
        public int AdresTyp { get; set; }
        public string Street { get; set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
        public string  Kraj { get; set; }
    }
}
