using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebaeudeWdhl
{
    public class Haus : gebaeude
    {
        private int stoecke { get; set; }
        private bool garten{ get; set; }
        public Haus(string _adresse, int _gebaeudeflaeche, int _stoecke, bool _garten)
        {
            this.adresse = _adresse;
            this.gebaeudeflaeche = _gebaeudeflaeche;
            this.stoecke = _stoecke;
            this.garten = _garten;

        }
    }
}
