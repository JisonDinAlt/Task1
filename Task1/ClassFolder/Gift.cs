using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.InterfaceFolder;

namespace Task1.ClassFolder
{
    class Gift 
    {

        public ICollection<ICandyBasic> Items { get; protected set; }
        public string Name { get; protected set; }


        public void SortByWeight ()
        {
            var result = from item in Items
                         orderby item.CandyWeight
                         select item;
            foreach (var u in result)
                Console.WriteLine("{0} - {1}", u.CandyName, u.CandyWeight);
            Console.WriteLine();

        }

        public void SortByName()
        {
            var result = from item in Items
                         orderby item.CandyName
                         select item;
            foreach (var u in result)
                Console.WriteLine("{0} - {1}", u.CandyName, u.CandyWeight);
            Console.WriteLine();

        }



        public double WeigtSum
        {
            get { return Items.Sum(x => x.CandyWeight); }
        }

        public void AddCandy(ICandyBasic item)
        {
            Items.Add(item);
        }

        public void DeletedCandy(ICandyBasic item)
        {
            Items.Remove(item);
        }

        public void ShowAll()
        {
            foreach (var item in this.Items)
            {
                Console.WriteLine("Название - {0}, вес - {1}", item.CandyName, item.CandyWeight);
            }
        }



        public void  CopmareBySugar(double Sugar_value_for_compare)

        {
            double z_count = 0;
            foreach (var i in Items)
            {
                var z = i as ISugarConcentration;
                if (z != null) { if (z.SugarPerThing == Sugar_value_for_compare) { Console.WriteLine("{0} сахара содержится в конфете {1}", Sugar_value_for_compare, i.CandyName); z_count++; } };
            }
            if (z_count == 0) { Console.WriteLine("В подарке нет конфет с содержанием сахара {0}", Sugar_value_for_compare); };
            z_count = 0;
            Console.WriteLine();
                               
        }

             

        public Gift(string name, ICollection<ICandyBasic> items)
        {
            Name = name;
            Items = items;
        }

    }
}
