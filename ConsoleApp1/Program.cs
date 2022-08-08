using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Basic Console */
            Console.WriteLine("Enter any subject...");//Enter any subject...
            string str = Console.ReadLine();//user input (maths)
            Console.WriteLine("Entered subject = " + str);// Entered subject = maths

            /* Variables */
            string userName = "John";//declaration & assign the value
            int userAge;//declaration
            userAge = 35;//assign the value
            Console.WriteLine("User name is " + userName);
            Console.WriteLine("User is " + userAge + " old");

            /* Data Types */
            int myInt = 5;
            Console.WriteLine("Integer(whole number) number = " + myInt);
            long myLong = 15000000000L;
            Console.WriteLine("Long number = " + myLong);//15000000000
            float myFloat = 5.75F;
            Console.WriteLine("Floating number = " + myFloat);//5.75
            double myDouble = 19.99D;
            Console.WriteLine("Double number = " + myDouble);//19.99
            myFloat = 35e3F;
            Console.WriteLine("Floating Scientific number = " + myFloat);//35000
            myDouble = 12E4D;
            Console.WriteLine("Double Scientific number = " + myDouble);//120000
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine("CSharp is fun (Boolean) = " + isCSharpFun);//True
            Console.WriteLine("Fish is tasty (Boolean) = " + isFishTasty);//False
            char myCharacter = 'A';
            Console.WriteLine("Character = " + myCharacter);//A
            string myString = "Hello World";
            Console.WriteLine("String = " + myString);//Hello World

            /* Working with String */
            //Create a variable of type string and assign it a value
            string txt = "Hello World";
            Console.WriteLine(txt);//Hello World
            //Get length of a string
            int txtLength = txt.Length;
            Console.WriteLine("The length of the txt string is: " + txtLength);//11
            //change into Uppercase
            txt = txt.ToUpper();
            Console.WriteLine(txt);//HELLO WORLD
            //change into Lowercase
            txt = txt.ToLower();
            Console.WriteLine(txt);//hello world
            string firstName = "John";
            string lastName = "Doe";
            //String Concatenation using +
            string name = firstName + " " + lastName;
            Console.WriteLine(name);//John Doe
            //String Concatenation using Concat method
            name = string.Concat(firstName, " ", lastName);
            Console.WriteLine(name);//John Doe
            //String Interpolation
            string nameString = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(nameString);//My full name is: John Doe
            // Access 1st character by index
            char firstChar = nameString[0];
            Console.WriteLine(firstChar);//M
            // Find Index of J
            int indexOfJ = nameString.IndexOf("J");
            Console.WriteLine(indexOfJ);//17
            // Find Index of z
            int indexOfz = nameString.IndexOf("z");
            Console.WriteLine(indexOfz);//-1
            // Find Index of N (Capital)
            int indexOfN = nameString.IndexOf("N");
            Console.WriteLine(indexOfN);//-1
            // get Substring if String
            string getName = nameString.Substring(indexOfJ);
            Console.WriteLine(getName);//John Doe
            lastName = getName.Substring(5, 3);
            Console.WriteLine(lastName);//Doe
            // Replace in String
            string oldString = "angular developer will develop angular applications";
            string correctString = oldString.Replace("angular", "react");
            Console.WriteLine(correctString);//react developer will develop react applications
            string removedString = oldString.Replace("angular ", null);//2nd string is optional in .Net 6
            Console.WriteLine(removedString);//developer will develop applications
            // String Comparision
            string str1 = "C# Programming";
            string str2 = "C# Programming";
            string str3 = "Programiz";
            // Compare the str1 with str2
            bool check1 = str1.Equals(str2);
            Console.WriteLine("string str1 and str2 are equal: " + check1);//string str1 and str2 are equal: True
            // Compare the str1 with str3
            bool check2 = str1.Equals(str3);
            Console.WriteLine("string str1 and str3 are equal: " + check2);//string str1 and str3 are equal: False
            // Use String.Equals method
            bool stringEquals = String.Equals("A", "A");
            Console.WriteLine(stringEquals);//True
            stringEquals = String.Equals("A", "B");
            Console.WriteLine(stringEquals);//False
            stringEquals = String.Equals("A", "a");
            Console.WriteLine(stringEquals);//False
            // Use String.Compare method
            int stringCompared = String.Compare("A", "A");
            Console.WriteLine(stringCompared);//0 , Both strings are equal in value
            stringCompared = String.Compare("A", "B");
            Console.WriteLine(stringCompared);//-1, <0 means 1st string precedes the 2nd string in the sort order
            stringCompared = String.Compare("B", "A");
            Console.WriteLine(stringCompared);//1, >0 means 1st string follows the 2nd string in the sort order
            // Include the single quote
            str = "It\'s alright";
            Console.WriteLine(str);//It's alright
            // Include the double quotes
            str = "This is the \"String\" class";
            Console.WriteLine(str);//This is the "String" class
            // Include the backspace
            str = "Hel\blo World";
            Console.WriteLine(str);//Helo World
            // Include the backslash
            str = "Filepath = C:\\Folder";
            Console.WriteLine(str);//Filepath = C:\Folder
            // Include null
            str = "Filename = A\0B";
            Console.WriteLine(str);//Filename = AB
            // Include new line
            str = "1st Line\n2nd Line";
            Console.WriteLine(str);//1st Line
                                   //2nd Line
                                   // Include horizontal tab
            str = "A\tB";
            Console.WriteLine(str);//A   B
            // Splitting Strings by delimiter
            string[] subs = name.Split(' ');
            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
                //Substring: John
                //Substring: Doe
            }
            // Adding Numbers and Strings
            string addStrings = "10" + "20";
            Console.WriteLine(addStrings);//1020 as string
            int addNumbers = 10 + 20;
            Console.WriteLine(addNumbers);//30 as integer/number

            /* Working with Numbers */
            //Create a variable of type integer and assign it a value
            myInt = 10;
            Console.WriteLine(myInt);//10
            //Addition
            Console.WriteLine(1 + 3);//4
            //Subtraction
            Console.WriteLine(4 - 2);//2
            //Multiplication
            Console.WriteLine(4 * 2);//8
            //Division
            Console.WriteLine(6 / 2);//3
            //Modulus / Mod / Reminder
            Console.WriteLine(7 % 2);//1
            //Order of operators
            Console.WriteLine(20 - 2 + 8);//18 + 8 = 26
            Console.WriteLine(20 - 2 * 8);//20 - 16 = 4
            //Return type in operations
            Console.WriteLine(5 / 2);//2 as integer
            Console.WriteLine(5 / 2.0);//2.5 as double
            //Increment / Decrement
            myInt = 5;
            myInt++;
            Console.WriteLine(myInt);//6
            myInt--;
            Console.WriteLine(myInt);//5
            //Math methods
            Console.WriteLine(Math.Abs(-40));//40, absolute(positive) value
            Console.WriteLine(Math.Pow(3, 3));//3*3*3 = 27, returns specified number to the specified power
            Console.WriteLine(Math.Sqrt(36));//6, square root of value
            Console.WriteLine(Math.Max(4, 90));//90, maximum value
            Console.WriteLine(Math.Min(4, 90));//4, minimum value
            Console.WriteLine(Math.Truncate(4.6));//4 , truncate the given number
            Console.WriteLine(Math.Round(4.68));//5 , round to nearest whole number
            Console.WriteLine(Math.Round(4.68, 1));//4.7 , round to nearest decimal number
            double myDoublenum = 54.65;
            Console.WriteLine(Math.Floor(myDoublenum));//54, largest integer smaller than or equal to
            Console.WriteLine(Math.Ceiling(myDoublenum));//55, smallest integer greater than or equal to

            /* Getting User Input */
            Console.Write("Enter your name : ");//write to console & execute next step in same line
            name = Console.ReadLine();//wait for user input, store it to variable
            Console.Write("Enter your age : ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " your age is " + age);//write to console

            /* Array */
            // declare the array
            int[] myArray = new int[2];
            // assign values to array using index
            myArray[0] = 1;
            myArray[1] = 2;
            // access the array elements
            Console.WriteLine(myArray[1]);//2
            // declare & assign values using object initialization syntax
            myArray = new int[3] { 3, 4, 5 };
            Console.WriteLine(myArray[2]);//5

            /* 2D Array */
            // declare the array, 3 rows, 2 elements in each row aka columns
            int[,] numberGrid = new int[3, 2];
            // assign values to array using row index & column index
            numberGrid[0, 0] = 1;
            numberGrid[0, 1] = 2;
            // access the array elements
            Console.WriteLine(numberGrid[0, 1]);//2, 1st row, 2nd column
            // declare & assign values using object initialization syntax
            numberGrid = new int[3, 2] {
                {1, 2},
                {3, 4},
                {5, 6}
            };
            Console.WriteLine(numberGrid[2, 0]);//5, 3rd row, 1st column

            /* Methods */
            // method without any return (or) void method
            consoleMethod("John", 30);//Hi John, your age is 30
            // method with return something
            int cubedNumber = cubeNumber(5);
            Console.WriteLine(cubedNumber);//125

            /* IF Statements */
            bool isMale = true;
            bool isTall = true;
            if(isMale && isTall) {
                Console.WriteLine("You are a tall male");
            } else if (isMale && !isTall) {
                Console.WriteLine("You are a male, but not tall");
            } else if (!isMale && isTall) {
                Console.WriteLine("You are not a male, but tall");
            } else {
                Console.WriteLine("You are not a male and not tall");
            }

            /* Switch/Case */
            Console.WriteLine(getDay(0));// Sunday
            Console.WriteLine(getDay(4));// Week day

            /* Loops */
            // while loop (check the condition before execution, continue if true)
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);//1 //2 //3 //4 //5
                index++;
            }
            //do while loop (execute one time, then check the condition, continue if true)
            index = 6;
            do
            {
                Console.WriteLine(index);//6
                index++;
            } while (index <= 5);
            // for loop
            int[] numbers = { 1, 2, 3, 4 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                //1 //2 //3 //4
            }

            /* Comments */
            // This is a single line Comment
            /*
             This is a
             Multi line Comment
            */

            /* Exception Handling */
            // try something
            try
            {
                Console.Write("Enter number 1 : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter number 2 : ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            // catch divide by zero exception
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            // catch format exception
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            // catch any kind of exception
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            /* Classes, Objects, Constructors */
            // Create object using default constructor
            Movie movie1 = new Movie();
            // assign values to the fields
            movie1.title = "Harry Potter";
            movie1.minutes = 45;

            // Create object using overloaded constructor with parameters
            Movie movie2 = new Movie("Lord of the Rings", 120);

            //Access object methods
            Console.WriteLine(movie1.LongMovie());//False
            Console.WriteLine(movie2.LongMovie());//True

            //Using getters & Setters for rating
            Movie movie3 = new Movie("THe Hobbit", 55);
            movie3.Rating = "R";//set with valid value
            Console.WriteLine(movie3.Rating);//R
            movie3.Rating = "other value";//set with invalid value
            Console.WriteLine(movie3.Rating);//NR

            //Static Fields/Attributes
            //Static field 'movieCount' will not accessible via class instance
            //Accessible through class only
            Console.WriteLine(Movie.movieCount);//3
            //Access static field from the class instance(object)
            Console.WriteLine(movie3.getMovieCount());//3

            //Static Methods
            Console.WriteLine(Movie.sayHi("John"));//Hi John

            //Static Class
            Console.WriteLine(StaticClass.greeting());//Hello Max Your age is 35

            //Class Inheritance
            //Inherits the field
            Console.WriteLine(IndianMovie.movieCount);//3
            //Inherits the method
            Console.WriteLine(IndianMovie.sayHi("Jack"));//Hi Jack
            
            //Base class virtual method
            Console.WriteLine(movie1.greeting("Jack"));//Hello Jack
            //Inherits & overides the virtual method in child class
            IndianMovie indianMovie1 = new IndianMovie();
            Console.WriteLine(indianMovie1.greeting("Jack"));//Hey Jack














        }

        static void consoleMethod(string name, int age)
        {
            Console.WriteLine("Hi " + name + ", your age is " + age);
        }

        static int cubeNumber(int myInt)
        {
            return myInt * myInt * myInt;
        }

        static string getDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 7:
                    dayName = "Saturday";
                    break;
                case 0:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Week day";
                    break;
            }

            return dayName;
        }


    }
}