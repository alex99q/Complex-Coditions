using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            double comissions = -1;

            if (city == "sofia")
            {
                if (0 <= sales && sales <= 500)
                {
                    comissions = 5;
                }
                else if (500 < sales && sales <= 1000)
                {
                    comissions = 7;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comissions = 8;
                }
                else if (sales > 10000)
                {
                    comissions = 12;
                }
            }

            else if (city == "varna")
            {
                if (0 <= sales && sales <= 500)
                {
                    comissions = 4.5;
                }
                else if (500 < sales && sales <= 1000)
                {
                    comissions = 7.5;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comissions = 10;
                }
                else if (sales > 10000)
                {
                    comissions = 13;
                }
            }

            else if (city == "plovdiv")
            {
                if (0 <= sales && sales <= 500)
                {
                    comissions = 5.5;
                }
                else if (500 < sales && sales <= 1000)
                {
                    comissions = 8;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comissions = 12;
                }
                else if (sales > 10000)
                {
                    comissions = 14.5;
                }
            }

            if (comissions == -1)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:f2}", sales * (comissions / 100));
            }
        }
    }
}
