using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age) && age >= 0)
        {
            double price = (age <= 12 || age >= 65) ? 7.0 : 10.0;
            Console.WriteLine($"Ticket Price: GHC{price}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid non‑negative integer age.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
