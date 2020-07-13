using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalQuestionDotNet
{
    public static class ExtensionMethodDemo
    {
        public static string StringUpperCaseExtensionMethod(this string str)
        {
            return str.ToUpper();
        }
    }
}
