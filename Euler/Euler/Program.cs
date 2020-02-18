using System;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            void EulerProblem6()
            {
                int num = 1;
                int sumOfSq = 0;
                int sqOfSum = 0;

                while (num <= 100)
                {
                    sumOfSq += num * num;
                    sqOfSum += num;
                    num++;
                }

                sqOfSum = sqOfSum * sqOfSum;
                Console.WriteLine("The sum of the squares of the first 100 natural numbers is " + sumOfSq.ToString());
                Console.WriteLine("The square of the sum of the first 100 natural numbers is " + sqOfSum.ToString());
                Console.WriteLine("The difference is " + (sqOfSum - sumOfSq).ToString());
                Console.Read();
            }
            EulerProblem6();

        }
    }
}
