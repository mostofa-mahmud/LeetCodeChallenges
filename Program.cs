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
            //twosum
            Calculate.Print();
            int[] arrInput = { 3, 2, 1 };
            int[] arrOutput= Calculate.TwoSum(arrInput, 3);
            for (int i = 0; i < arrOutput.Length; i++)
            {
                Console.WriteLine(arrOutput[i]);
            }
            










            Console.ReadLine();
        }
    }
}
