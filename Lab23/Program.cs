using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int n = Convert.ToInt32(Console.ReadLine());
                FactorialAsync(n);

                Console.ReadKey();
        }

            static void Factorial(int n)
            {                 
               int factorial = 1;   

                for (int i = 2; i <= n; i++) 
                {
                    factorial = factorial * i;
                }
                 Console.WriteLine(factorial);
            }

            static async void FactorialAsync(int n)
            {
                await Task.Run(() => Factorial(n));
            }

    }
}
    

