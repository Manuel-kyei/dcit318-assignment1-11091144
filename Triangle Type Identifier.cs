using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        int a, b, c;

        while (true)
        {
            Console.Write("Enter side A: ");
            bool validA = int.TryParse(Console.ReadLine(), out a) && a > 0;

            Console.Write("Enter side B: ");
            bool validB = int.TryParse(Console.ReadLine(), out b) && b > 0;

            Console.Write("Enter side C: ");
            bool validC = int.TryParse(Console.ReadLine(), out c) && c > 0;

            if (validA && validB && validC)
            {
                if (a + b > c && a + c > b && b + c > a) // Triangle inequality
                    break;
                else
                    Console.WriteLine("These sides do not form a valid triangle. Try again.");
            }
            else
            {
                Console.WriteLine("Invalid input. All sides must be positive numbers. Try again.");
            }
        }

        if (a == b && b == c)
            Console.WriteLine("Triangle type: Equilateral");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Triangle type: Isosceles");
        else
            Console.WriteLine("Triangle type: Scalene");
    }
}
