using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung
{
    public class gebaeude
    {
        string Name; // Attribut der Klasse Gebäude
        public string NameAccessible {

            get { return Name; }

            set { Name = value; }

        }
        public int gebaeudeflaeche
        {
            get { return gebaeudeflaeche; }
            set { gebaeudeflaeche = value; }
        }
    }
}