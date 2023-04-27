﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Assignment
{
    internal class DiningTable : Furniture
    {
        public int NoOfLegs { get; set; }

        public int Accept()
        {
            base.Accept();
            Console.Write("Enter No. of Legs: ");
            NoOfLegs = int.Parse(Console.ReadLine());

            return 1;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"No. of Legs: {NoOfLegs}");
        }

       
    }
}