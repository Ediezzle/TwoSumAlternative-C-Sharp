using System;
using System.Collections.Generic;

namespace TwoSumAlternative
{
    class Program
    {
        public static void FindTwoSum(IList<int> list, int sum)
        {
            //iterate through all indices checking if there is a combination that adds up to sum
            for (int firstIndex = 0; firstIndex < list.Count - 1; firstIndex++)
            {
                for (int secondIndex = firstIndex + 1; secondIndex < list.Count; secondIndex++)
                {
                    //if there exists such a combination, get the indices and assign them as values to "myTuple"
                    if (list[firstIndex] + list[secondIndex] == sum)
                    {
                        Console.WriteLine(list[firstIndex] + " " + list[secondIndex]);

                    }
                }
            }

        }

        public static void Main(string[] args)
        { 
                FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
        }
    }
}
