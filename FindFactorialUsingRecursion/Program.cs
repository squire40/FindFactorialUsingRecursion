using System;

namespace FindFactorialUsingRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine($"Enter integer from 1 to {FindMaxValue()}");
            input = int.Parse(Console.ReadLine());

            long result = FindFactorial(Convert.ToInt64(input));

            Console.WriteLine($"The factorial of {input} is {result}");
            Console.ReadKey();
        }

        static long FindFactorial(long num)
        {
            if (num == 1)
            {
                return 1;
            }

            return num * FindFactorial(num - 1);
        }

        public static int FindMaxValue()
        {
            int res = 2;
            long fact = 2;
            while (true)
            {
                // when fact crosses its size,  
                // it gives negative value 
                if (fact < 0)
                {
                    break;
                }
                res++;
                fact = fact * res;
            }

            return res - 1;
        }


    }
}
