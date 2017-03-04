using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo10_y_12.Capitulo12Debug
{
    public class Factorial
    {
        public static void main()
        {
            factorial(5);
        }

        public static void factorial(int num)
        {
            int factorial = num;

            for (int i = num - 1; i > 0; --i)
            {
                factorial *= i;
                Console.WriteLine(factorial);
            }

            Console.WriteLine("\nEl Factorial de " + num + " es: " + factorial);
            Console.ReadKey();
        }
    }
}
