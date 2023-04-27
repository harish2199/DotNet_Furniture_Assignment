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

        public void Accept()
        {
            base.Accept();
            Console.Write("Enter No. of Shelves: ");
            NoOfShelves = int.Parse(Console.ReadLine());

            
        }

        public void Display()
        {
            Console.WriteLine("BookShelf Details:");
            base.Display();
            Console.WriteLine($"No. of Shelves: {NoOfShelves}");
        }
    }
}
