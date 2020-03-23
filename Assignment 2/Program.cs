using System;
using System.IO;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which of the files would you like to compare to?");
            int fileGroup = 0;
            while (fileGroup <= 0 || fileGroup > 3)//User is given choices 
            {
                Console.WriteLine("Please select the number of the files you wish to compare, between 1 and 3:");//User must pick from the 3 options
                Console.WriteLine("1. Files 1a and 1b.");
                Console.WriteLine("2. Files 2a and 2b.");
                Console.WriteLine("3. Files 3a and 3b.");
                bool userInputChecker = int.TryParse(Console.ReadLine(), out fileGroup);
                if (userInputChecker == false)
                {
                    Console.WriteLine("That is an invalid input, please try again.");
                }
            }
            String fileOne = "";
            String fileTwo = "";
            if (fileGroup == 1)
            {
                fileOne = "File_1a";
                fileTwo = "File_1b";
            }
            else if (fileGroup == 2)
            {
                fileOne = "File_2a";
                fileTwo = "File_2b";
            }
            else
            {
                fileOne = "File_3a";
                fileTwo = "File_3b";
            }

            StreamReader reader = new StreamReader(fileOne);

            while (reader.EndOfStream == false)
            {

            }
            reader.Close();
            
        }
    }
}
