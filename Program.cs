using LeetCodeChallenges.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<int> numbers = new List<int> {2, 7, 11, 15};
            int[] numbers = { 2, 7, 11, 15};
            int[] abc = Calculate.TwoSum(numbers,9);
            Console.WriteLine(abc);
            Console.ReadLine();
           
        }
    }
}
