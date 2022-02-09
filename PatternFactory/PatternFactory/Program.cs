﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternFactoryLib;

namespace PatternFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            NowYorkFactory factory = new NowYorkFactory();
            StorePizza store = new NowYorkPizzaStore(factory);
            Console.ReadLine();
        }
    }
}
