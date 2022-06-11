using System;
using System.IO;

namespace procesare_caractere
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = args[0];
            fileText file = new fileText(path);

            Console.WriteLine("Total number of characters is: " + file.getNrOfCharacters());
            Console.WriteLine("Total number of vowels is: "+file.getNrOfVowels());
            Console.WriteLine("Total number of consonants is: "+file.getNrOfConsonants());
            Console.WriteLine("Total number of lines is: "+file.getNrOfLines());
            
           
        }
    }
}
