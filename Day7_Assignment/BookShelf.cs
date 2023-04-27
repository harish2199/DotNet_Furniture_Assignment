using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Assignment
{
    internal class BookShelf : Furniture
    {
        public int NoOfShelves { get; set; }

        public int Accept()
        {
            base.Accept();
            Console.Write("Enter No. of Shelves: ");
            NoOfShelves = int.Parse(Console.ReadLine());

            return 1;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine($"No. of Shelves: {NoOfShelves}");
        }
    }
}
