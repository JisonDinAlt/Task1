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
            CandySugarSkinStuffing Candy3 = new CandySugarSkinStuffing("Candy3", 20, 30, "Глазурь", "Орехи");
            CandyWithoutSugar Candy4 = new CandyWithoutSugar("Candy4", 12);
            CandyWithoutSugarSkin Candy5 = new CandyWithoutSugarSkin("Candy5", 18, "Шоколад");
           

            List<ICandyBasic> Present = new List<ICandyBasic>();
            Present.Add(Candy1);
            Present.Add(Candy2);
            Present.Add(Candy3);
            Present.Add(Candy4);
            Present.Add(Candy5);


            string temp_sugar_string;
            double temp_sugar_double = 0;
            double temp_weight = 0;

            Console.WriteLine("Введите содержание сахара для поиска конфеты с аналогичными параметрами");
            temp_sugar_string = Console.ReadLine();

            try
            { temp_sugar_double = double.Parse(temp_sugar_string); }
            catch { Console.WriteLine("Введите корректное число"); }

           // Console.WriteLine(temp_sugar_double);

            foreach (var i in Present)

            {
                 // Console.WriteLine(i.CandyName); Console.ReadKey();

            if (i is ISugarConcentration) { temp_weight = temp_weight + i.CandyWeight; };
                             

               
            }
            
       


            Console.WriteLine("Вес подарка {0} ", temp_weight);
            Console.ReadKey();
        }
           
    }
}
