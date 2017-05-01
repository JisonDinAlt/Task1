using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.InterfaceFolder;

namespace Task1.ClassFolder
{
    public abstract class BasicSweet : IBasicSweet
    {
        public string SweetName { get; protected set; }
        public double SweetWeight { get; protected set; }
        public double SweetSugar { get; protected set; }

    }
}
