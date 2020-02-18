using System;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            void EulerProblem2() // rodney
            {
                const int max = 4000000;
                int evenSum = 2;
                
                
                int varFirst = 1;
                int varSecond = 2;
                while (true)
                {
                    int nxt = varFirst + varSecond;
                    if (nxt > max)
                    {
                        break;
                    }
                    else
                    {
                        if (nxt%2 == 0)
                        {
                            evenSum = evenSum + nxt;
                        }
                        varFirst = varSecond;
                        varSecond = nxt;

                    }
                }
                Console.WriteLine("Sum of even fibonacci numbers less than 4 million is "+evenSum);
               
                       
            }
            EulerProblem2();

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
            Console.Read();
        }

    }


}

        
