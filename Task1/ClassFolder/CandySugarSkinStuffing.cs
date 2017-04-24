using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.InterfaceFolder;

namespace Task1.ClassFolder
{
    public class CandySugarSkinStuffing : CandySugar, ISkin, IStuffing
    {
     
        public string Skin { get; set; }
        public string Stuffing { get; set; }
       
        public CandySugarSkinStuffing (string n, double w, double spt, string sk, string st) : base (n,w,spt)
        {
            CandyName = n;
            CandyWeight = w;
            SugarPerThing = spt;
            Skin = sk;
            Stuffing = st;

        }

        public void reWrite()
        { Console.WriteLine("название - {0}, Вес - {1}, Содержание сахара - {2}, Оболочка - {3}, Наполнитель - {4}", CandyName, CandyWeight, SugarPerThing, Skin, Stuffing); }
    }
}
