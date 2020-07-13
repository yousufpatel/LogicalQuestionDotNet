using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalQuestionDotNet
{
    public sealed class SingleTon
    {
        private static SingleTon Instance = null;
        private SingleTon()
        {

        }

        public static SingleTon GetSingleTon()
        {
            if (Instance == null)
            {
                Instance = new SingleTon();
            }

            return Instance;
        }

        public void GetString()
        {
            Console.WriteLine("Hello World");
        }
    }
}
