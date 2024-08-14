using System;
using System.Collections.Generic;

namespace RiotSharp.Misc
{
    public class TestFile
    {
        public static string MY_CONSTANT = "Hello World";
        public static string _another_constant;
        public static string ThirdConstant;
        private readonly string _propertyOne;
        private readonly string _propertyTwo;

        public void Abc()
        {
            Console.WriteLine(_another_constant);
            Console.WriteLine(_propertyOne);
        }

        public void Abcc()
        {
            List<string> myList = new List<string>();
        }
    }
}