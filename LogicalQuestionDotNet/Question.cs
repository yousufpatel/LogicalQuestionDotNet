using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalQuestionDotNet
{
    public class Question
    {
        public static void Test()
        {
            int a = 4;
            string InputString = "afdsse";
            string CheckString = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0;i < CheckString.Length;i++)
            {
                if (CheckString[i] == InputString[i])
                {
                    Console.WriteLine(CheckString[i + a]);
                }
                
            }
        }
    }
}
