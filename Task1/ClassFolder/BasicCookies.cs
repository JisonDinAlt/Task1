using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.InterfaceFolder;

namespace Task1.ClassFolder
{
    class BasicCookies : BasicSweet, IBacisCookies
    {
        public BasicCookies() { }
        public BasicCookies (string name, double weight, double sugar, string pastry)
        {
            SweetName = name;
            SweetWeight = weight;
            SweetSugar = sugar;
            CookiesPastry = pastry;
        }

        public string CookiesPastry { get; set; }
    }
}
