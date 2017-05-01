using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ClassFolder
{
    class CookiesGingerbreadMan : BasicCookies
    {
        public CookiesGingerbreadMan(string name, double weight, double sugar, string pastry) : base (name, weight, sugar, pastry)
        {
            SweetName = name;
            SweetWeight = weight;
            SweetSugar = sugar;
            CookiesPastry = pastry;
        }
    }
}
