using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ClassFolder
{
    public class CandyWithoutSugar : AbstractCandy
    {
        public CandyWithoutSugar (string n, double w)
        {
            CandyName = n;
            CandyWeight = w;
        }

        public void reWrite()
        { Console.WriteLine("название - {0}, Вес - {1}", CandyName, CandyWeight); }
    }
}
