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
        public ICollection<IBasicSweet> Items { get; protected set; }
        public string Name { get; protected set; }
        public Gift(string name, ICollection<IBasicSweet> items)
        {
            Name = name;
            Items = items;
        }

        public void SortByWeight ()
        {
            var result = from item in Items
                         orderby item.SweetWeight
                         select item;
            foreach (var u in result)
            { u.ToString(); }
        }

        public void SortByName()
        {
            var result = from item in Items
                         orderby item.SweetName
                         select item;
            foreach (var u in result)
            { u.ToString(); }
        }

        public double WeigtSum
        {
            get { return Items.Sum(x => x.SweetWeight); }
        }

        public void AddSweet(IBasicSweet item)
        {
            Items.Add(item);
        }

        public void DeletedSweet (IBasicSweet item)
        {
            Items.Remove(item);
        }

        public void ShowAll()
        {
            foreach (var item in this.Items)
            { item.ToString(); }
        }

        public void CopmareBySugar(double Sugar_value_for_compare)
        {
            var result = from item in Items
                         where item.SweetSugar == Sugar_value_for_compare
                         select item;
                         
            foreach (var u in result)
            { u.ToString(); }
        }
    }
}
