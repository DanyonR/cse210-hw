using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        List<int> positiveNumbers = new List<int>();

        bool loop = true;
        string userEntry = "";
        int number = 0;

        Console.WriteLine("\nEnter a list of numbers; type 0 when finished.");
        while (loop != false)
        {
            Console.Write("Enter a number: ");
            userEntry = Console.ReadLine();
            number = int.Parse(userEntry);
            if (number == 0)
            {
                loop = false;
            }
            else
            {
                numbers.Add(number);
            }
        }
        
        foreach (int num in numbers)
        {
            if (num > 0)
            {
                positiveNumbers.Add(num);
            }
        }

        int total = numbers.Sum();
        Console.WriteLine($"The sum of all the numbers is {total}");

        int average = total / numbers.Count;
        Console.WriteLine($"The average of all the numbers is {average}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is {largest}");

        if (positiveNumbers.Count > 0)
        {
            int smallest = positiveNumbers.Min();
            Console.WriteLine($"The smallest positive number is {smallest}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }

        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}