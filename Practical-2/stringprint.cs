﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2
{
    class stringprint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Country");
            string country = Console.ReadLine();
            Console.WriteLine("Hello " + name + " from country " + country);
            Console.ReadLine();

        }
    }
}
