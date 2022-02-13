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


        //Perfect Number Program
        public static void PerfectNo()
        {
            int sumOfDivisors = 0;
            Console.WriteLine("----------Perfect Number----------");
            Console.WriteLine("Checks if sum of divisors of n = n");
            int n = GetPositiveInt("Enter a +ve no: ");
            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0)
                    sumOfDivisors += i;
            if (sumOfDivisors == n)
                Console.WriteLine("It is a Perfect Number!");
            else
                Console.WriteLine("It is not a Perfect Number");
        }

    }
}
