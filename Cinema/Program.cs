using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine().ToLower();
            var redove = int.Parse(Console.ReadLine());
            var koloni = int.Parse(Console.ReadLine());
            double price = 0;

            if (projection == "premiere")
            {
                price = 12;
            }
            else if (projection == "normal")
            {
                price = 7.5;
            }
            else if (projection == "discount")
            {
                price = 5;
            }

            Console.WriteLine("{0:f2}", redove * koloni * price);
        }
    }
}
