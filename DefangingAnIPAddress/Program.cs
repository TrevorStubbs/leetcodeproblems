using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DefangingAnIPAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Iterating through a string practice (foreach)
            void practiceForEach()
            {
                
                string testStr = "abc123";
                foreach(char c in testStr)
                {
                    Console.WriteLine(c.ToString());
                }
                
            }

            // Iterateing through a string (for)
            void practiceFor()
            {
                string testStr = "abc123";
                for (int counter = 0; counter < testStr.Length; counter++)
                {
                    Console.WriteLine(testStr[counter].ToString());
                }
            }

            // Turn a string into an array of chars
            string value = "Dot Net Perls";

            char[] array = value.ToCharArray();

            for(int i = 0; i<array.Length; i++)
            {
                char letter = array[i];
                Console.Write("Letter: ");
                Console.WriteLine(letter);
            }

            // Assemble the array of chars into a string
            string str = new string(array);
            Console.WriteLine("str = " + str);
            
            // Turn a string into a List of chars
            string data = "ABCDEFGHI";
            List<string> dataList = new List<string>();
            dataList.AddRange(data.Select(c => c.ToString()));
            for(int i = 0; i < dataList.Count; i++)
            {
                Console.Write(dataList[i]);
            }

            Console.WriteLine();

            // List to string
            List<string> dogs = new List<string>();
            dogs.Add("aigi");
            dogs.Add("spitz");
            dogs.Add("mastif");
            dogs.Add("finnish spitz");
            dogs.Add("briard");

            string dogCsv = string.Join(",", dogs.ToArray());
            Console.WriteLine(dogCsv);


            // DefangTest
            // Results= Runtime: 92ms Memory: 22.9mb
            string deFangTest(string address)
            {
                List<string> ipList = new List<string>();
                ipList.AddRange(address.Select(c => c.ToString()));
                Console.WriteLine(ipList);

                for(int i = 0; i < ipList.Count; i++)
                {
                    if (ipList[i] == ".")
                    {
                        ipList[i] = "[.]";
                    }
                }
                string defangedIP = string.Join("", ipList.ToArray());
                return defangedIP;
            }

            //.Replace
            // Result = Runtime 80ms Memory: 22.5mb
            string DefangIPadder(string address)
            {
                return address.Replace(".", @"[.]");
            }

            string testAddress = "1.1.1.1";
            string result = deFangTest(testAddress);
            Console.WriteLine(result);
            Console.WriteLine(DefangIPadder(testAddress));
            Console.ReadKey();

            /*
            practiceForEach();
            practiceFor();
            Console.ReadKey();
            */
        }
    }
}
