using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.InterfaceFolder;

namespace Task1.ClassFolder
{
   

        public class CandySugar : AbstractCandy, ISugarConcentration
        {
                         
        public double SugarPerThing
        { get; set; }

        public CandySugar (string n, double w, double spt)
        {
            CandyName = n;
            CandyWeight = w;
            SugarPerThing = spt;

        }


        public void reWrite()
        { Console.WriteLine("название - {0}, Вес - {1}, Содержание сахара - {2}", CandyName, CandyWeight, SugarPerThing); }

    }

     



   

}
