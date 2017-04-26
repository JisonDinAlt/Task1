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
           

            List<ICandyBasic> Present = new List<ICandyBasic>();
            Present.Add(Candy1);
            Present.Add(Candy2);
            Present.Add(Candy3);
            Present.Add(Candy4);
            Present.Add(Candy5);


            string temp_sugar_string;
            double temp_sugar_double = 0;
            double temp_weight = 0;
            int z_count = 0;
            string menu_command = "";
            int check_double_flag = 0;

                        
            do {
                Console.WriteLine("1. Что бы вывести все конфеты подарка введите 1 ");
                Console.WriteLine("2. Что бы найти конфету по задданому показателю сахара введите 2 ");
                Console.WriteLine("3. Что бы упорядочить подарок по одному из показателей введите 3 ");
                Console.WriteLine("4. Что бы узнать вес подарка введите 4 ");
                Console.WriteLine("5. Что бы закончить работу введите 5 ");
                menu_command = Console.ReadLine(); 

                switch (menu_command)
                {
                    case "1" :

                        foreach (var i in Present)

                        {
                           var sugar_temp = i as ISugarConcentration;
                           var skin_temp = i as ISkin;
                           var stuffing_temp = i as IStuffing;
                            Console.Write("Название конфеты {0}, вес конфеты {1}", i.CandyName, i.CandyWeight);
                            if (sugar_temp != null) { Console.Write(", содержание сахара {0}", sugar_temp.SugarPerThing ); };
                            if (skin_temp != null) { Console.Write(", оболочка {0}", skin_temp.Skin); };
                            if (stuffing_temp != null) { Console.Write(", начинка {0}", stuffing_temp.Stuffing); };
                            Console.WriteLine();
                        }


                        break;

                    case "2" :
                        
                        do
                        {
                            Console.WriteLine("Введите содержание сахара для поиска конфеты с аналогичными параметрами");
                            temp_sugar_string = Console.ReadLine();

                            if (double.TryParse (temp_sugar_string, out temp_sugar_double) ) { check_double_flag = 0; }
                            else { Console.WriteLine("Введите корректное число"); check_double_flag = 1; };
                        }
                        while (check_double_flag == 1);
                       
                        
                        foreach (var i in Present)
                        {
                            var z = i as ISugarConcentration;
                            if (z != null) { if (z.SugarPerThing == temp_sugar_double) { Console.WriteLine("{0} сахара содержится в конфете {1}", temp_sugar_double, i.CandyName); z_count++; } };
                        }
                        if (z_count == 0) { Console.WriteLine("В подарке нет конфет с содержанием сахара {0}", temp_sugar_double); };
                        z_count = 0;
                        Console.WriteLine();

                        break;


                    case "3" :

                        break;

                    case "4" :

                        foreach (var i in Present)
                        {
                            if (i is ICandyBasic) { temp_weight = temp_weight + i.CandyWeight; };
             
                        }
                        Console.WriteLine("Вес подарка {0} ", temp_weight);
                        Console.WriteLine();
                        
                        break;

                };

             }
            while (menu_command != "5");





        }
           
    }
}
