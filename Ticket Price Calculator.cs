using System;

class TicketPriceCalculator
{
    static void Main()
    {
        int age;

        while (true)
        {
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
                break;
            else
                Console.WriteLine("Invalid input. Please enter a valid non-negative number for age.");
        }

        int price = (age <= 12 || age >= 65) ? 7 : 10;
        Console.WriteLine($"Your ticket price is: GHC{price}");
    }
}
