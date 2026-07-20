namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Problem 1");

        // Problem 1 //
        for (int i=1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("\nProblem 2");

        // Problem 2 //
        for (int i=1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("\nProblem 3");

        // Problem 3 //
        int count = 5;

        while (count > 1)
        {
            Console.WriteLine(count);
            count--;
        }
        Console.WriteLine("\nProblem 4");

        // Problem 4 //
        int number = 10;

        while (number <= 1000)
        {
            Console.WriteLine(number);
            {
                number += 10;
            }
        }
        Console.WriteLine("\nProblem 5");

        // Problem 5 //
        string[] seasons = { "spring", "summer", "fall", "winter" };
        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }
        Console.WriteLine("\nProblem 6");

        // Problem 6 //
        string [] days =
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        Console.WriteLine("Enter a day number (1-7): ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        if (dayNumber >= 1 && dayNumber <= 7)
        {
            Console.WriteLine(days[dayNumber - 1]);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        Console.WriteLine("\nProblem 7");

        // Problem 7 //
        string[] books =
        {
            "Outliers",
            "To Kill a Mockingbird",
            "Into the Wild"
        };
        string[] authors =
        {
            "Malcolm Gladwell",
            "Harper Lee",
            "Jon Krakauer"
        };

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{books[i]} by {authors[i]}");
        }

        Console.WriteLine("\nProblem 8");

        // Problem 8 //
        int[] temperatures = { 72, 64, 80, 75, 68};

        Array.Sort(temperatures);

        Console.WriteLine("Temperatures in ascending order:");

        foreach (int temp in temperatures)
        {
            Console.WriteLine(temp);
        }

        Console.WriteLine($"Lowest Temperature: {temperatures[0]}");
        Console.WriteLine($"Highest Temperature: {temperatures[temperatures.Length - 1]}");

        Console.WriteLine("\nProblem 9");

        // Problem 9 //
        int[] countdown = { 5, 4, 3, 2, 1 };

        Array.Reverse(countdown);

        for (int i = 0; i < countdown.Length; i++)
        {
            Console.WriteLine(countdown[i]);
        }
    }
}
