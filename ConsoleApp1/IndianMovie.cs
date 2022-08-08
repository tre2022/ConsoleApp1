using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class IndianMovie : Movie
    {
        //Overrides the base class virtual method
        public override string greeting(string name)
        {
            return "Hey " + name;
        }

    }
}
