using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99Bottles_of_Beer
{

    class Program
    {

        static void Main(string[] args)
        {
            void ninetyNineBottlesofBeer()
            {
                for (int i = 99; i > 0; i--)
                {
                    if (i == 1)
                    {
                        Console.WriteLine($"{i} bottle of beer on the wall");
                        Console.WriteLine($"{i} bottle of beer");
                        Console.WriteLine("Take none down, pass it around");
                        Console.WriteLine($"{i-1} bottles of beer on the wall");
                    }
                    else
                    {
                        Console.WriteLine($"{i} bottles of beer on the wall");
                        Console.WriteLine($"{i} bottles of beer");
                        Console.WriteLine(@"Take one down pass it around");
                        if (i - 1 == 1)
                        {
                            Console.WriteLine($"{i} bottle of beer on the wall \n");
                        }
                        else
                        {
                            Console.WriteLine($"{i-1} bottles of beer on the wall \n");
                        }
                    }

                }
            }

            ninetyNineBottlesofBeer();
            Console.ReadLine();
        }

        
       
        

    }
}
