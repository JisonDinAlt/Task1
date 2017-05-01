﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ClassFolder
{
    class CandyFondant : BasicCandy
    {
        public CandyFondant (string name, double weight, double sugar, string filling): base (name, weight, sugar, filling)
        {
            SweetName = name;
            SweetWeight = weight;
            SweetSugar = sugar;
            CandyFilling = filling;
        }
    }
}