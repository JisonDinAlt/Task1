using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.ClassFolder;
using Task1.InterfaceFolder;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gift Present1 = new Gift("Gift1", new List<IBasicSweet>());

            var Sweet1 = new CandyAlenka ();
            var Sweet2 = new CandyFondant();
            var Sweet3 = new CandyFondant();
            var Sweet4 = new CandyTruffle();
            var Sweet5 = new CookiesBiscuit();
            var Sweet6 = new CookiesGingerbreadMan();

            Present1.AddSweet(Sweet1);
            Present1.AddSweet(Sweet2);
            Present1.AddSweet(Sweet3);
            Present1.AddSweet(Sweet4);
            Present1.AddSweet(Sweet5);
            Present1.AddSweet(Sweet6);
            Present1.DeletedSweet(Sweet2);
            Present1.AddSweet(Sweet2);

            Present1.ShowAll();
            Present1.SortByWeight();
            Present1.SortByName();
            var resultWeightSum = Present1.WeigtSum.ToString();
            Present1.CopmareBySugar(20);
        }
    }
}
