using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите желаемое количество товаров");
            int n = int.Parse(Console.ReadLine());
            Price[] arrayOfPrices=new Price[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Товар номер {i+1}");
                Console.Write("Введите название товара:");
                string name = Console.ReadLine();
                Console.Write("Введите название магазина:");
                string shop= Console.ReadLine();
                Console.Write("Введите цену товара:");
                int cost = int.Parse(Console.ReadLine());

                Price price = new Price(name, shop, cost);
                arrayOfPrices[i] = price;
            }

            while (true)
            {
                Console.WriteLine("Введите название магазина");
                string s = Console.ReadLine();
                if(string.IsNullOrEmpty(s))
                    break;

                foreach (var price in arrayOfPrices)
                {
                    if(s==price.Shop)
                        Console.WriteLine(price.ToString());
                }
            }

        }
    }
}
