using System;
using System.IO;

namespace WriteIntoText.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "250", "242", "240" };

            File.WriteAllLines(@"C:\Users\txa334\Desktop\Assets\highscores.txt", lines);

            Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();

            
        }
    }
}
