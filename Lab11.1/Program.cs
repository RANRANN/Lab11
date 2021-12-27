using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = Convert.ToDouble(Console.ReadLine());
            double k = Convert.ToDouble(Console.ReadLine());

            Count count = new Count(b,k);
            Console.WriteLine(count.Root());
            Console.ReadKey();
        }
    }
}
