using System;

namespace LogicalQuestionDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleTon Instance = SingleTon.GetSingleTon();
            Instance.GetString();
        }
    }
}
