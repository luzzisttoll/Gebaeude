using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebaeudeWdhl
{
    public class Schule : gebaeude
    {
        private string name { get; set; }
        private int klassen { get; set; }
        public Schule(string _adresse, int _gebaeudeflaeche, string _name, int _klassen)
        {
            this.adresse = _adresse;
            this.gebaeudeflaeche = _gebaeudeflaeche;
            this.name = _name;
            this.klassen = _klassen;

        }
    }
}
