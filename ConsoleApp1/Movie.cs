using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Movie
    {
        public string title;
        public int minutes;
        private string rating;// private field
        //valid ratings = PG-13, R, NR
        public static int movieCount = 0;// static field

        //This is a default & parameterless constructor
        public Movie()
        {
            // auto increment count with every class call
            movieCount++;
        }

        //This is a overloaded & parameter constructor
        public Movie(string aTitle, int aMinutes)
        {
            //Assign values to the fields during object creation
            title = aTitle;
            minutes = aMinutes;
            rating = Rating;
            // auto increment count with every class call
            movieCount++;
        }

        //Class method
        public bool LongMovie()
        {
            if(minutes > 60)
                return true;
            else
                return false;
        }

        //Property
        public string Rating
        {
            //getter to get rating from the object
            get 
            { 
                return rating;
            }
            //setter to set rating of the object after validate incoming value
            set
            {
                if(value == "PG-13" || value == "R")
                    rating = value;
                else
                    rating = "NR";
            }
        }

        //getter method to access static fields from the class instance(object)
        public int getMovieCount()
        {
            return movieCount;
        }

        //Static method to access directly from class
        public static string sayHi(string name)
        {
            //cannot access non-static member from the static method
            //Console.WriteLine(title);
            return "Hi " + name;
        }

        //Virtual method
        public virtual string greeting(string name)
        {
            return "Hello " + name;
        }


    }
}