using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== C# Console Tools ===");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option (1-4): ");

            switch (Console.ReadLine())
            {
                case "1":
                    RunGradeCalculator();
                    break;
                case "2":
                    RunTicketPriceCalculator();
                    break;
                case "3":
                    RunTriangleIdentifier();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Press any key to try again...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void RunGradeCalculator()
    {
        Console.Clear();
        Console.Write("Enter grade (0–100): ");
        if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
        {
            string letter = grade >= 90 ? "A"
                          : grade >= 80 ? "B"
                          : grade >= 70 ? "C"
                          : grade >= 60 ? "D"
                          : "F";
            Console.WriteLine($"Letter Grade: {letter}");
        }
        else
        {
            Console.WriteLine("Please enter a valid integer between 0 and 100.");
        }
        PauseReturn();
    }

    static void RunTicketPriceCalculator()
    {
        Console.Clear();
        Console.Write("Enter age: ");
        if (int.TryParse(Console.ReadLine(), out int age) && age >= 0)
        {
            double price = (age <= 12 || age >= 65) ? 7.0 : 10.0;
            Console.WriteLine($"Ticket Price: GHC{price:F2}");
        }
        else
        {
            Console.WriteLine("Invalid age. Enter a non-negative integer.");
        }
        PauseReturn();
    }

    static void RunTriangleIdentifier()
    {
        Console.Clear();
        Console.Write("Enter side1: "); bool ok1 = double.TryParse(Console.ReadLine(), out double s1);
        Console.Write("Enter side2: "); bool ok2 = double.TryParse(Console.ReadLine(), out double s2);
        Console.Write("Enter side3: "); bool ok3 = double.TryParse(Console.ReadLine(), out double s3);

        if (!ok1 || !ok2 || !ok3 || s1 <= 0 || s2 <= 0 || s3 <= 0)
        {
            Console.WriteLine("Enter valid positive numbers for all sides.");
        }
        else if (!(s1 + s2 > s3 && s1 + s3 > s2 && s2 + s3 > s1))
        {
            Console.WriteLine("These sides do not form a valid triangle.");
        }
        else if (s1 == s2 && s2 == s3)
        {
            Console.WriteLine("Triangle Type: Equilateral");
        }
        else if (s1 == s2 || s1 == s3 || s2 == s3)
        {
            Console.WriteLine("Triangle Type: Isosceles");
        }
        else
        {
            Console.WriteLine("Triangle Type: Scalene");
        }
        PauseReturn();
    }

    static void PauseReturn()
    {
        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
}
