using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebaeudeWdhl
{
    public class Stall : gebaeude
    {
        private string farbe { get; set; }
        private int inhalt { get; set; }
       public Stall(string _adresse, int _gebaeudeflaeche, string _farbe, int _inhalt)
       {
            this.adresse = _adresse;
            this.gebaeudeflaeche = _gebaeudeflaeche;
            this.farbe = _farbe;
            this.inhalt = _inhalt;
                      
       }
    }
}
