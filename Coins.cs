﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine_Proj
{
    abstract class Coins
    {
        public double amount;
        public List<double> coins;
        public Coins()
        {
            coins = new List<double>() { };
        }
        
    }
}
