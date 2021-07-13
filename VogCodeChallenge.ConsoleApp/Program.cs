using System;

namespace VogCodeChallenge.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iterate through a collection with no For or Foreach loop");
            QuestionClass.IterateWithoutForLoops();

            Console.WriteLine("TESTModule testing..");
            var result = QuestionClass.TESTModule("test");
            Console.WriteLine(result);
        }
    }
}
