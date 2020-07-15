using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalQuestionDotNet
{
    public class CSharpBasic
    {
        public static void CSharpDataTypesExmaple()
        {
            // Single Line Comment Example 

            /* 
             This is Multiline Comment
            */

            /* Data Types In C# :
            Integer - int harry; --> 4 bytes
            Long -->  long harray; --> 8bytes 
            Floating point number - float that --> 4 bytes
            Double  -->  double harray; --> 8bytes 
            Charecter char a = 'A'; --> 2 bytes
            Bollean - bool isGreat = true ; --> 1 bit
            String - string inp = "Yosuf" --> 2 byetes per character        
            */

            /* Data Types Example In C# :   */
            int a = 4;
            float b = 3.5F;
            double c = 5.5D; /* Here D is optional */
            bool isGreate = true;
            char d = 'A'; /* Use always single quote to keep Charecter */
            string e = "This is a string";
            Console.WriteLine("{0},{1},{2},{3},{4},{5}", a, b, c, isGreate, d, e);
        }

        public static void CSharpTypeCastingExmaple()
        {
            /*              
                There are two types of typecasting 
                1) Implicit type casting
                   a) Char to int to long to float to double 
                   b) Small data type to big data type
                   c) Will e done by compiler automatically

                2) Explicit type casting
                   a) Big data type to small data type
                   b) Will be done by using cast operator
                     
             */

            // Implicit type casting 
            int a = 3;
            double b = a;
            Console.WriteLine(b);

            //Explicit type casting
            float c = 20F;
            int d = (int)c;
            Console.WriteLine(d);


            //Type Casting by method for Explicit type casting Example

            double e = 5.66;
            int f = Convert.ToInt32(e);


        }

        public static void CSharpUSerInputExample()
        {

        }
    }
}
