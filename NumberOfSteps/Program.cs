using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfSteps(int num)
            {
                int counter = 0;

                while (num > 0)
                {
                    if(num % 2 != 0)
                    {
                        num--;
                        counter++;
                    }
                    else
                    {
                        num = num / 2;
                        counter++;
                    }                    
                }
                return counter;
            }

            Console.WriteLine(NumberOfSteps(14)); //output should be 6
            Console.WriteLine(NumberOfSteps(5)); // should be 4
            Console.ReadKey();
        }
    }
}
