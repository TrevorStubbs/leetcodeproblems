using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rough Draft
            int[] TwoSumOne(int[] nums, int target)
            {
                int[] result = { 0, 0 };

                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (j > nums.Length)
                        {
                            break;
                        }
                        int thisOneQQ = nums[i] + nums[j];
                        if (thisOneQQ == target)
                        {
                            result[0] = nums[i];
                            result[1] = nums[j];
                        }
                    }
                }
                return result;
            }
            

            // Cleaned up a bit
            int[] TwoSumTwo(int[] nums, int target)
            {
                int[] result = { 0, 0 };
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] == target - nums[i])
                        {
                            return new int[] { i, j };
                        }
                    }
                }

                return result;
            }           
            
            // Use a dictionary for O(n). (or is it O(log n)?)
            int[] TwoSumOneDictonary(int[] nums, int target)
            {
                var dict = new Dictionary<int, int>();

                for(int i = 0; i<nums.Length; i++)
                {
                    int goal = target - nums[i];

                    if( dict.ContainsKey(goal))
                    {
                        return new int[] { dict[goal], i };
                    }
                    else if (!dict.ContainsKey(nums[i]))
                    {
                        dict.Add(nums[i], i);
                    }                    
                }
                return new int[] { };
            }

            
            void printValues(int[] myArr)
            {
                for (int i = 0; i<myArr.Length; i++)
                {
                    Console.WriteLine("{0}", i);
                }
                Console.WriteLine();
            }
            

            int[] test1 = { 2, 7, 11, 15 };
            int[] test2 = { 3, 3 };
            printValues(TwoSumOne(test1, 9));
            printValues(TwoSumTwo(test1, 9));
            Console.WriteLine();
            printValues(TwoSumOne(test2, 6));
            Console.WriteLine();
            printValues(TwoSumOneDictonary(test2, 6));
            Console.ReadLine();
        }
    }

}
