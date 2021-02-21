using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int num;
            Console.Write("\n\nCalculating the Fibonacci number of a specific term using Recursive Function\n");
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe Fibonacci of the {0}th term  is {1} \n", num, Fib(num));
            Console.ReadKey();
        }
        public static int Fib(int n1)
        {
            if (n1 <= 2)
                return 1;
            else
                return Fib(n1 - 1) + Fib(n1 - 2); //using recursion
        }
    }
}
