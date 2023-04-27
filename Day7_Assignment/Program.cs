using System.Security.Cryptography.X509Certificates;

namespace Day7_Assignment
{
    internal class Program
    {
        Furniture[] stock = new Furniture[2];


        static void AcceptStockSetails(Furniture[] stock)
        {
            Console.WriteLine("Please select the type of furniture:");
            Console.WriteLine("1. Bookshelf");
            Console.WriteLine("2. Dining table");

            for (int i = 0; i < stock.Length; i++)
            {
                Console.Write($"Enter the type of furniture-{i + 1}: ");
                string furnitureType = Console.ReadLine();

                if (furnitureType.ToLower() == "bookshelf")
                {
                    BookShelf bookShelf = new BookShelf();
                    bookShelf.Accept();
                    stock[i] = bookShelf;
                }
                else if (furnitureType.ToLower() == "dining table")
                {
                    DiningTable diningTable = new DiningTable();
                    diningTable.Accept();
                    stock[i] = diningTable;
                }
                else
                {
                    Console.WriteLine("Invalid furniture type entered. Please try again.");
                    i--;
                    continue;
                }

                Console.WriteLine($"Furniture #{i + 1} details accepted.");
                Console.WriteLine();
            }
        }

        static double TotalStockPrice(Furniture[] stock)
        {
            double totalStockValue = 0;

            for (int i = 0; i < stock.Length; i++)
            {
                totalStockValue += stock[i].Price * stock[i].Quantity;
            }

            return totalStockValue;
        }
        static int ShowStockDetails(Furniture[] stock)
        {
            int i = 0;
            foreach (Furniture f in stock)
            {
                Console.WriteLine($"Furniture details {++i}:");
                f.Display();
                Console.WriteLine("----------------------------------------------------------------");
            }
            return 1;
        }
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("1:Accept Stock Details");
                Console.WriteLine("2:Display Total Stock Value");
                Console.WriteLine("3: Show all Stock Details");
                Console.WriteLine("Enter your choice:");
                int choice = int.Parse(Console.ReadLine()); 

                switch (choice)
                {
                    case 1:
                        AcceptStockSetails(stock);
                        Console.WriteLine("---------------------------------------------------------");
                        break;
                    case 2:
                        Console.WriteLine($"Total Stock Value = {TotalStockPrice(stock)}");
                        Console.WriteLine("---------------------------------------------------------");
                        break;
                    case 3:
                        Console.WriteLine(ShowStockDetails(stock));
                        Console.WriteLine("---------------------------------------------------------");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            
        }
    }
}