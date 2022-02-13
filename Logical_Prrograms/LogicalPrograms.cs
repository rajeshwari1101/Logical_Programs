using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Prrograms
{
    internal class LogicalPrograms
    {
        public static int GetPositiveInt(string message)
        {
            int n;
            string input;
            bool IS_INT32;
            do
            {
                do
                {
                    Console.Write(message);
                    input = Console.ReadLine();
                    IS_INT32 = Int32.TryParse(input, out n);
                } while (IS_INT32 is false);
                n = Convert.ToInt32(input);
            } while (n < 0);
            return n;
        }

        // fibonacci Series program
        public static void Fibonacci()
        {
            int current = 1;
            int previous = 0;
            int sum;
            Console.WriteLine("----------Fibonacci Series----------");
            int n = GetPositiveInt("Enter a +ve no: ");
            Console.WriteLine("The series is: ");
            Console.Write("0 1 ");
            for (int i = 2; i <= n; i++)
            {
                sum = current + previous;
                previous = current;
                current = sum;
                Console.Write(sum + " ");
            }
        }

    }
}
