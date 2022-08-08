using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class StaticClass
    {
        //static fields
        private static string name;
        private static int age;

        //static constructor is used to initialise the static data members
        static StaticClass()
        {
            name = "Max";
            age = 35;
        }

        public static string greeting()
        {
            return "Hello " + name + " Your age is " + age;
        }
    }
}
