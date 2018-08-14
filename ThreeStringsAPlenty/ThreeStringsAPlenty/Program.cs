using System;
using System.Text;

class Program
    {
        static void Main()
        {
        //Haiku (Concatenate) String
        Console.WriteLine("I'm going to teach you how to write a haiku. Press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("First, write a line that has only 5 syllables.");
        string fiveSyllables = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Good. Now write a line that has only 7 syllables.");
        string sevenSyllables = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Finally, write one last line that also has 5 syllables. \nPress enter when you are finished.");
        string fiveAgain = Convert.ToString(Console.ReadLine());
        Console.ReadLine();
        Console.WriteLine("Alright, this is your Haiku:\n");
        Console.WriteLine(fiveSyllables + "\n" +sevenSyllables + "\n" +fiveAgain );
        Console.ReadLine();

        //All Caps (All Uppercase) String
        Console.WriteLine("On a different note, type in anything and see it come back in ALL CAPS!");
        string allCaps = Convert.ToString(Console.ReadLine());
        allCaps = allCaps.ToUpper();
        Console.WriteLine(allCaps);
        Console.ReadLine();

        //Stringbuilder Paragraph String
        Console.WriteLine("Press enter to read about my cat!");
        Console.ReadLine();
        StringBuilder paraGraph = new StringBuilder();

        paraGraph.Append("I have a beautiful cat. \nShe goes by many names, including Chunk Munk, Kitty and Babygirl. \nBabygirl is the name I use the most in our personal life. \nMost people online call her Chunk Munk. \nShe's developing quite a following, over 500 followers on Instagram! \nI'm really grateful others love her as much as I do :).");
        Console.WriteLine(paraGraph);
        Console.ReadLine();
        }
    }

