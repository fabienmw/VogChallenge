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

        public static object TESTModule(object args)
        {
            //NOTE: This switch statement can be written as a switch expression below, achieving the same result.
            object result;
            switch (args)
            {
                case int input when input == 1 || input == 2 || input == 3 || input == 4:
                    result = input * 2;
                    break;
                case int input when input > 4:
                    result = input * 3;
                    break;
                case int input when input < 1:
                    throw new ArgumentException($"Value cannot be less than 1: {nameof(args)}");
                case float input when input == 1.0f || input == 2.0f:
                    result = 3.0f;
                    break;
                case string input:
                    result = input.ToUpper();
                    break;
                default:
                    result = args;
                    break;
            }

            return result;
        }

        public static object TESTModuleWithSwitchExpressions(object args)
        {
            object result = args switch
            {
                int input when input == 1 || input == 2 || input == 3 || input == 4 => input * 2,
                int input when input > 4 => input * 3,
                int input when input < 1 => throw new ArgumentException($"Value cannot be less than 1: {nameof(args)}"),
                float input when input == 1.0f || input == 2.0f => 3.0f,
                string input => input.ToUpper(),
                _ => args,
            };
            return result;
        }
    }
}
