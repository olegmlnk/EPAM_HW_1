using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_HW_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 40;
            Console.WriteLine("Вартість одного зошита: {0}", x);

            int y = 25;
            Console.WriteLine("Вартість однієї ручки: {0}", y);

            Console.WriteLine("Введіть значення m(ручки): ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення n(зошити): ");
            int n = int.Parse(Console.ReadLine());
            

            int sum = (n * x) + (m * y);

            Console.WriteLine("\nСума всієї покупки складає: {0}", sum);

        }
    }
}
