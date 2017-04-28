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
            CandySugarSkin Candy2 = new CandySugarSkin("Candy2", 10, 20, "Глазурь");
            CandySugarSkinStuffing Candy3 = new CandySugarSkinStuffing("Candy3", 20, 25, "Глазурь", "Орехи");
            CandyWithoutSugar Candy4 = new CandyWithoutSugar("Candy4", 12);
            CandyWithoutSugarSkin Candy5 = new CandyWithoutSugarSkin("Candy5", 18, "Шоколад");



            Gift Present1 = new Gift("Gift1", new List<ICandyBasic>());

            Present1.AddCandy(Candy1);
            Present1.AddCandy(Candy2);
            Present1.AddCandy(Candy3);
            Present1.DeletedCandy(Candy2);
            Present1.AddCandy(Candy4);
            Present1.AddCandy(Candy2);


           

            Present1.ShowAll();

            Present1.CopmareBySugar(25);

            Present1.SortByWeight();

            Present1.SortByName();

            Console.WriteLine(Present1.WeigtSum);

            Console.ReadKey();




        }
           
    }
}
