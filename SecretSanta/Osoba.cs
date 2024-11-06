﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta
{
    public class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public bool ImaSantu { get; set; }

        public Osoba(string ime, string prezime, bool imaSantu)
        {
            Ime = ime;
            Prezime = prezime;
            ImaSantu = imaSantu;
        }
    }
}
