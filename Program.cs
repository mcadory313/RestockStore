using System;

namespace RestockStore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial stock values and restock thresholds
            int sodaStock = 100;
            int sodaRestockThreshold = 40;
            
            int chipsStock = 40;
            int chipsRestockThreshold = 20;
            
            int candyStock = 60;
            int candyRestockThreshold = 40;

            Console.WriteLine("Welcome to the restocking tool.\n");

            // Process Soda
            Console.WriteLine($"How many Sodas have been sold today? {sodaStock} in stock");
            int sodaSold = int.Parse(Console.ReadLine());
            if (sodaSold > sodaStock)
            {
                Console.WriteLine("That value is too high. Stock not adjusted\n");
            }
            else
            {
                sodaStock -= sodaSold;
                Console.WriteLine($"There are {sodaStock} Sodas left\n");
            }

            // Process Chips
            Console.WriteLine($"How many Chips have been sold today? {chipsStock} in stock");
            int chipsSold = int.Parse(Console.ReadLine());
            if (chipsSold > chipsStock)
            {
                Console.WriteLine("That value is too high. Stock not adjusted\n");
            }
            else
            {
                chipsStock -= chipsSold;
                Console.WriteLine($"There are {chipsStock} Chips left\n");
            }

            // Process Candy
            Console.WriteLine($"How many Candy have been sold today? {candyStock} in stock");
            int candySold = int.Parse(Console.ReadLine());
            if (candySold > candyStock)
            {
                Console.WriteLine("That value is too high. Stock not adjusted\n");
            }
            else
            {
                candyStock -= candySold;
                Console.WriteLine($"There are {candyStock} Candy left\n");
            }

            // Check which items need restocking
            Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");
            if (sodaStock <= sodaRestockThreshold)
            {
                Console.WriteLine("Soda needs to be restocked");
            }
            if (chipsStock <= chipsRestockThreshold)
            {
                Console.WriteLine("Chips needs to be restocked");
            }
            if (candyStock <= candyRestockThreshold)
            {
                Console.WriteLine("Candy needs to be restocked");
            }
            
            Console.WriteLine("\nGoodbye!");
        }
    }
}
