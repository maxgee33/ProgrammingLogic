using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /* Maxwell Gee
            IT-1050 - Lab 1 */

            // Step 2 //
            Console.WriteLine("Maxwell Gee");
            Console.WriteLine("IT-1050 - Programming Logic");

            // Step 3 //
            int favoriteNumber = 3;
            string favoriteLanguage = "Java";
            double programsWritten = 0;
            bool hasExperience = false;

            Console.WriteLine("My Favorite Number is " + favoriteNumber + ".");
            Console.WriteLine("My favorite Programming language is " + favoriteLanguage + ".");
            Console.WriteLine("The number of programs I've written before this is " + programsWritten + ".");
            Console.WriteLine("It is " + hasExperience + " that I have prior programming experience.");

            // Step 4 //
            const string SchoolName = "Cuyahoga Community College";
            Console.WriteLine("I am taking this course at " + SchoolName + ".");

            // Step 5 //
            double myDouble = 9.78;
            int castedInt = (int)myDouble;

            int sampleInt = 25;
            bool sampleBool = false;

            string stringFromInt = Convert.ToString(sampleInt);
            string stringFromBool = Convert.ToString(sampleBool);

            Console.WriteLine("double: " + myDouble);
            Console.WriteLine("explicit int: " + castedInt);
            Console.WriteLine("int to string: " + stringFromInt);
            Console.WriteLine("bool to string: " + stringFromBool);

            // Step 6 //
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine() ?? "0");
            Console.WriteLine("Hello " + userName + "! You are " + userAge + " years old.");

            // Step 7 //
            int num1 = 20;
            int num2 = 5;

            int addResult = num1 + 10;
            int subResult = num1 - 2;
            int multResult = num1 * 3;
            int divResult = num1 / 2;
            int modResult = num1 % 2;

            Console.WriteLine("The result of adding 10 to num1 is: " + addResult);
            Console.WriteLine("The result of subtracting 2 from num1 is: " + subResult);
            Console.WriteLine("The result of multiplying num1 by 3 is: " + multResult);
            Console.WriteLine("The result of dividing num1 by 2 is: " + divResult);
            Console.WriteLine("The result of num1 modulus 2 is: " + modResult);

            // Step 8 //
            float myFloat = 1.123456789f;
            double myPrecisionDouble = 1.123456789;

            Console.WriteLine("Float value: " + myFloat);
            Console.WriteLine("Double value: " + myPrecisionDouble);

            // Step 9 //
            int trackingNum = 10;

            trackingNum++;
            Console.WriteLine("Value after increment (++): " + trackingNum);

            trackingNum--;
            Console.WriteLine("Value after decrement: " + trackingNum);
        }
    }
}










