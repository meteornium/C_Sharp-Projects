using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 88, 98, 90, 76, 85, 94, 72, 95, 86, 88, 73, 64, 23, 74, 85 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}

            //Console.ReadLine();

            //string[] names = { "Adam", "Casey", "Michael", "Danny", "Kyle" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);               
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(88);
            //testScores.Add(78);
            //testScores.Add(93);
            //testScores.Add(84);
            //testScores.Add(39);
            //testScores.Add(73);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}

            //Console.ReadLine();

            //List<string> names = new List<string>() { "Adam", "Casey", "Michael", "Danny", "Kyle" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.ReadLine();

            List<int> testScores = new List<int>() { 94, 88, 98, 90, 75, 84, 93 };
            List<int> passingScores = new List<int>();
            
            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }

            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
