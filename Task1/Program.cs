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
            

            CandySugar Candy1 = new CandySugar("Candy1",15,25);
            Candy1.reWrite();
            Console.ReadKey();

            CandySugarSkin Candy2 = new CandySugarSkin("Candy2", 10, 20, "Глазурь");
            Candy2.reWrite();
            Console.ReadKey();

            CandySugarSkinStuffing Candy3 = new CandySugarSkinStuffing("Candy3", 20, 30, "Глазурь", "Орехи");
            Candy3.reWrite();
            Console.ReadKey();

            CandyWithoutSugar Candy4 = new CandyWithoutSugar("Candy4", 12);
            Candy4.reWrite();
            Console.ReadKey();

            CandyWithoutSugarSkin Candy5 = new CandyWithoutSugarSkin("Candy5", 18, "Шоколад");
            Candy5.reWrite();
            Console.ReadKey();

            List<AbstractCandy> Present = new List<AbstractCandy>();
            Present.Add(Candy1);
            Present.Add(Candy2);
            Present.Add(Candy3);
            Present.Add(Candy4);
            Present.Add(Candy5);

            foreach (var i in Present)
                { Console.WriteLine(i); Console.ReadKey(); }

        }
           
    }
}
