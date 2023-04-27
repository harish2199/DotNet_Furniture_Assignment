using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Assignment
{
    internal class Furniture
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public int Accept()
        {
            Console.Write("Enter height: ");
            Height = double.Parse(Console.ReadLine());

            Console.Write("Enter width: ");
            Width = double.Parse(Console.ReadLine());

            Console.Write("Enter color: ");
            Color = Console.ReadLine();

            Console.Write("Enter quantity: ");
            Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter price: ");
            Price = double.Parse(Console.ReadLine());

            return 1;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Price: {Price}");
        }

        public double TotalCost()
        {
            return Quantity * Price;
        }
    }
}
