using System;
using System.IO;

namespace WriteIntoText.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method 1
            string[] lines = { "First 250", "Second 242", "Third 240" };

            File.WriteAllLines(@"C:\Users\txa334\Desktop\Assets\highscores.txt", lines);

            /*//Method 2
            Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\txa334\Desktop\Assets" + fileName + ".txt" , input);*/

            //Method3
            using (StreamWriter file = new StreamWriter(@"C:\Users\txa334\Desktop\Assets\myText.txt"))
            {
                foreach(string line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }
    }
}
