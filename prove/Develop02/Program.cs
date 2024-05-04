// I exceeded requirements by adding the Console.Clear(); function strategically to clean up
// the output. I also added acknowledgements to show that the saving and loading processes have 
// been successfully completed.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        bool menuSelection = true;
        
        Console.Clear();
        Console.WriteLine("\nYou are welcome here.");
        Console.WriteLine("This is a safe space for your deepest thoughts and feelings.\n");
        
        while (menuSelection != false)
        {
            Console.WriteLine
            (
                @"Type a menu number to continue.
1. New Journal Entry
2. View Entries
3. Load Entries from a File
4. Save Entries to a File
5. I'm Done Reflecting for the Day"
            );
            Console.Write("> ");
            string userSelection = "";
            userSelection = Console.ReadLine();
            Console.Clear();

            if (userSelection == "1")
            {
                Entry entry = new Entry();
                journal.AddEntry(entry);
            }
            else if (userSelection == "2")
            {
                journal.DisplayEntries();
            }
            else if (userSelection == "3")
            {
                journal.LoadFromFile("Journal.txt");
                Console.Clear();
                Console.WriteLine("Done.");
            }
            else if (userSelection == "4")
            {
                journal.SaveToFile("Journal.txt");
                Console.Clear();
                Console.WriteLine("Done.");
            }
            else if (userSelection == "5")
            {
                Console.WriteLine("\nCome back and write your adventures!\n");
                menuSelection = false;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine
                (
                    @"Your frustration is valid. You are safe here.
Your feelings will serve you much better once 
they are recorded in your journal."
                );
                Console.WriteLine();
            }
        }
    }
}