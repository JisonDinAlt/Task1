using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.InterfaceFolder;

namespace Task1.ClassFolder
{
    public class BasicCandy : BasicSweet, IBasicCandy
      {
        public BasicCandy (string name, double weight, double sugar, string filling)
        {
            SweetName = name;
            SweetWeight = weight;
            SweetSugar = sugar;
            CandyFilling = filling;
        }

        public string  CandyFilling { get; set; }
    }
}
