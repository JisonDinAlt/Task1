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
            CandyAlenka Sweet1 = new CandyAlenka("Alenka", 100, 10, "Chokolate");
            CandyAlenka Sweet2 = new CandyAlenka("Alenka", 150, 15, "Chokolate");
            CandyFondant Sweet3 = new CandyFondant ("Fondant", 200, 20, "Fondant");
            CandyTruffle Sweet4 = new CandyTruffle ("Truffle", 300, 30, "Ganache");
            CookiesBiscuit Sweet5 = new CookiesBiscuit("Biscuit", 400, 40, "Biscuit");
            CookiesGingerbreadMan Sweet6 = new CookiesGingerbreadMan("CookiesGingerbreadMan", 500, 50, "Gingerbread");

            Gift Present1 = new Gift("Gift1", new List<IBasicSweet>());

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
            Console.WriteLine(Present1.WeigtSum);
            Present1.CopmareBySugar(20);
            Console.ReadKey();
        }
    }
}
