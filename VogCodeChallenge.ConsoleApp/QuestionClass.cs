using System;
using System.Collections.Generic;
using System.Text;

namespace VogCodeChallenge.ConsoleApp
{
    public static class QuestionClass
    {
        static List<string> NameList = new List<string>
        {
            "Jimmy",
            "Jeffrey",
            "John"
        };

        public static void IterateWithoutForLoops()
        {
            int index = 0;
            while (index < NameList.Count)
            {
                Console.WriteLine(NameList[index]);
                index++;
            }
        }
    }
}
