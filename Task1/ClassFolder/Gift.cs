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

        public string CopmareBySugar(ISugarConcentration item)

        {

             IEnumerable<ICandyBasic> query = from n in Items
                                                     where n.CandyWeight == 10
                                                     select n;
            return "";
        }





        public Gift(string name, ICollection<ICandyBasic> items)
        {
            Name = name;
            Items = items;
        }

    }
}
