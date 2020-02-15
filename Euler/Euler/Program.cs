using System;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            void EulerProblem2()
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
                Console.Read();
                       
            }
            EulerProblem2();

            
        }

        
    }
    
}
