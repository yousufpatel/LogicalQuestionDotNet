using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalQuestionDotNet
{
    public class SortArray
    {
        public static void SortArrayElements()
        {
            int[] MyArray = new int[] { 5, 9, 1, 4 };

            for (int i = 0; i < MyArray.Length; i++)
            {
                for (int j = 0; j < MyArray.Length - 1; j++)
                {
                    if (MyArray[j] > MyArray[j + 1])
                    {
                        int temp = MyArray[j];
                        MyArray[j] = MyArray[j + 1];
                        MyArray[j + 1] = temp;
                    }
                }

            }

            for (int k =0; k< MyArray.Length; k++)
            {
                Console.WriteLine(MyArray[k]);
            }

        }
    }
}
