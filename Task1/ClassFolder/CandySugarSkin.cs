using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.InterfaceFolder;

namespace Task1.ClassFolder
{
    class CandySugarSkin : CandySugar, ISkin
    {
       

        public string Skin { get; set; }

        public CandySugarSkin(string n, double w, double spt, string sk) : base(n, w, spt)
        {
            CandyName = n;
            CandyWeight = w;
            SugarPerThing = spt;
            Skin = sk;
        }

       

    }
}
