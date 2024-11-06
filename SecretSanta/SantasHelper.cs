using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta
{
    public class SantasHelper
    {
        public List<Osoba> Osobe { get; set; }
        public List<Osoba> Slobodni { get; set; }

        public SantasHelper()
        {
            Osobe = new List<Osoba>();
            Slobodni = new List<Osoba>();
        }

        public void DodajOsobu(string ime, string prezime) 
        {
            Osoba osoba = new Osoba(ime, prezime, false);
            Osobe.Add(osoba);
            Slobodni.Add(osoba);
        }

        public void ObrisiOsobu(string ime, string prezime)
        {
            foreach(var osoba in Osobe)
            {
                if(osoba.Ime == ime && osoba.Prezime == prezime)
                {
                    Osobe.Remove(osoba);
                    Slobodni.Remove(osoba);
                }
            }
        }

        public Osoba DodjeliSantu(string ime, string prezime)
        {
            List<Osoba> mogucOdabir = new List<Osoba>();

            foreach(var osoba in Slobodni)
            {
                if(osoba.Ime != ime && osoba.Prezime != prezime)
                {
                    mogucOdabir.Add(osoba);
                }
            }
            Random random = new Random();
            int index = random.Next(0, mogucOdabir.Count);
            Osoba odabranaOsoba = mogucOdabir[index];

            for (int i = 0; i < Slobodni.Count; i++)
            {
                if (Slobodni[i].Ime == odabranaOsoba.Ime && Slobodni[i].Prezime == odabranaOsoba.Prezime)
                {
                    Slobodni.RemoveAt(i);
                    break;
                }
            }

            return odabranaOsoba;
        }

    }
}
