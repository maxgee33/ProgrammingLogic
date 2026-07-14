using System;

class Program
{
    static void Main(string[] args)
    {
        // Part 1 //
        int a = 10;
        int b = 5;
        int c = 15;

        Console.WriteLine($"a > b: {a > b}");
        Console.WriteLine($"a < c: {a < c}");
        Console.WriteLine($"a > b && a > c: {a > b && a > c}");
        Console.WriteLine($"a > b || a > c: {a > b || a > c}");

        Console.WriteLine();

        // Part 2 //
        bool isRaining = true;
        bool hasUmbrella = false;

        if (isRaining && !hasUmbrella)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }

        // Part 3 //
        Console.WriteLine("Enter your age: ");
        int age=int.Parse(Console.ReadLine());

        if (age < 5)
        {
            Console.WriteLine("Ticket is free!");
        }
        else if (age >= 5 && age <= 12)
        {
            Console.WriteLine("Child Ticket: $5");
        }
        else if (age >= 13 && age <= 64)
        {
            Console.WriteLine("Standard Ticket: $10");
        }
        else
        {
            Console.WriteLine("Senior Ticket: $6");
        }

        // Part 4 //
        Console.WriteLine();

        Console.WriteLine("Enter a day number (1-7): ");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;

            case 2:
                Console.WriteLine("Tuesday");
                break;

            case 3:
                Console.WriteLine("Wednesday");
                break;

            case 4:
                Console.WriteLine("Thursday");
                break;

            case 5:
                Console.WriteLine("Friday");
                break;

            case 6:
                Console.WriteLine("Saturday");
                break;

            case 7:
                Console.WriteLine("Sunday");
                break;

            default:
                Console.WriteLine("Invalid day!");
                break;
        }
    }
}
