using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230323_jz_cs
{
    
    internal class versenyzok
    {
        public string Nev { get; set; }
        public int Szulev { get; set; }
        public string Rajtszam { get; set; }
        public bool Nem { get; set; }
        public string Kategoria { get; set; }
        public TimeSpan[] IdoEredmenyek { get; set; }
        public TimeSpan Osszido
        {
            get
            {
                TimeSpan oi = TimeSpan.Zero;
                foreach (var ie in IdoEredmenyek)
                {
                    oi += ie;
                }
                return oi;
            }
        }

        public versenyzok(string sor)
        {
            string[] v = sor.Split(';');
            Nev = v[0];
            Szulev = int.Parse(v[1]);
            Rajtszam = v[2];
            Nem = v[3] == "f";
            Kategoria = v[4];
            IdoEredmenyek = new TimeSpan[5];
            for (int i = 5; i < v.Length; i++)
            {
                IdoEredmenyek[i - 5] = TimeSpan.Parse(v[i]);
            }
        }
    }
}
