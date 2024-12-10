using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verseny
{
    internal class verseny
    {
        public string Nev { get; set; }

        public string Nem { get; set; }

        public string csapat { get; set; }

        public string kategoria { get; set; }

        public string egyesület { get; set; }

        public verseny(string sor)
        {
            string[] sprite = sor.Split(';');

            Nev = sprite[0];
            Nem = sprite[1];
            csapat = sprite[2];
            kategoria = sprite[3];
            egyesület = sprite[4];
        }
    }
}
