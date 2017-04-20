using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.InterfaceFolder;

namespace Task1.ClassFolder
{
    public class CandyWithoutSugarSkin : AbstractCandy, ISkin

    {
        public string Skin { get; set; }

        public CandyWithoutSugarSkin(string n, double w, string sk)
        {
            CandyName = n;
            CandyWeight = w;
            Skin = sk;
        }

        public void reWrite()
        { Console.WriteLine("название - {0}, Вес - {1},  Оболочка - {2}", CandyName, CandyWeight,  Skin); }
    }
}
