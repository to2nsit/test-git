﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello {
    class Program {
        static void Main(string[] args) {
            string name;

            Console.Write("=====================================");   

            Console.Write("Your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello, {name.ToUpper()}!");

            Console.Write("=====================================");
        }
    }
}
