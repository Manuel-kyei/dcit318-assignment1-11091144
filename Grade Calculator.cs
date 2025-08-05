using System;

class GradeCalculator
{
    static void Main()
    {
        int grade;

        while (true)
        {
            Console.Write("Enter your numerical grade (0-100): ");
            if (int.TryParse(Console.ReadLine(), out grade) && grade >= 0 && grade <= 100)
                break;
            else
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }

        if (grade >= 90)
            Console.WriteLine("Grade: A");
        else if (grade >= 80)
            Console.WriteLine("Grade: B");
        else if (grade >= 70)
            Console.WriteLine("Grade: C");
        else if (grade >= 60)
            Console.WriteLine("Grade: D");
        else
            Console.WriteLine("Grade: F");
    }
}
