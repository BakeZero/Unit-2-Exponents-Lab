using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Learn your squares and cubes!\n");
        while (true)
        {
            Console.Write("Enter an integer greater than 0 and less than 1291: ");
            double input = double.Parse(Console.ReadLine());
            if (input <= 0)
            {
                Console.WriteLine("Invalid input, please try again.");
                continue;
            }
            else if (input > 1290)
            {
                Console.WriteLine("Input too large, please try again.");
                continue;
            }

            Console.WriteLine();
            Console.WriteLine("Number\t\tSquared\t\tCubed");
            Console.WriteLine("=======\t\t=======\t\t======");

            for (double i = 1; i <= input; i++)
            {
                double squared = i * i;
                double cubed = i * i * i;
                Console.WriteLine(String.Format("{0,7}\t\t{1,7}\t\t{2,6}", i, squared, cubed));
            }

            Console.Write("Continue? y/n: ");
            string prompt = Console.ReadLine();
            if (prompt == "n")
                break;
        }
    }
}