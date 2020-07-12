using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalQuestionDotNet
{
    public class ArrayOperations
    {
        /*Iterate Array Elements Using For Loop */
        public static void iterateArrayElements()
        {
            int[] MyArray = new int[] { 1, 2, 3, 4 };

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }
        }

        /* Sort Array Elements In Asscending Order*/
        public static void sortArrayElementsInAscendingOrder()
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

            for (int k = 0; k < MyArray.Length; k++)
            {
                Console.WriteLine(MyArray[k]);
            }
        }

        /* Sort Array Elements In Desscending Order*/
        public static void sortArrayElementsInDesscendingOrder()
        {
            int[] MyArray = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < MyArray.Length - 1; i++)
            {
                for (int j = 0; j < MyArray.Length; j++)
                {
                    if (MyArray[j] < MyArray[j + 1])
                    {
                        int temp = MyArray[j];
                        MyArray[j] = MyArray[j + 1];
                        MyArray[j + 1] = temp;
                    }
                }
                Console.WriteLine(MyArray[i]);
            }
        }
    }
}
