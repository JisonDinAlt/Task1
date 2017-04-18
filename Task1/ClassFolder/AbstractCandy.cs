using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.InterfaceFolder;

namespace Task1.ClassFolder
{
    public abstract class AbstractCandy : ICandyBasic
    {
        public string  CandyName { get; }
        public double CandyWeight { get; }
    }
}
