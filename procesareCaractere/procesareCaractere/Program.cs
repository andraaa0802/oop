using System;
using System.IO;

namespace procesareCaractere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("TextFile1.txt"); //path: D:\Andra\tema-oop\procesareCaractere\procesareCaractere\bin\Debug\net5.0
            int lines = 0;

            while(!reader.EndOfStream)
            {
                reader.ReadLine();
                lines++;
            }

            TextReader reader2= new StreamReader("TextFile1.txt");

            string text = reader2.ReadToEnd();

            int vowels = 0, consonants = 0, characters = 0; //in characters se numara literele, cifrele si semnele de punctuatie

            for (int i = 0; i < text.Length; i++)
            {
                if (isVowel(text[i]))
                    vowels++;
                if (isConsonant(text[i]))
                    consonants++;
                if(isCharacter(text[i]))
                    characters++;
            }
            
            Console.WriteLine($"Characters: {characters}{Environment.NewLine}Vowels: {vowels}{Environment.NewLine}Consonants: {consonants}{Environment.NewLine}Lines: {lines}");
        }

        private static bool isCharacter(char c)
        {
            if (Char.IsLetterOrDigit(c) || Char.IsPunctuation(c))
                return true;
            return false;
        }

        private static bool isConsonant(char c)
        {
            if (Char.IsLetter(c))
            {
                char v = Char.ToLower(c);
                if (v != 'a' && v != 'e' && v != 'i' && v != 'o' && v != 'u')
                    return true;
            }
            return false;
        }

        private static bool isVowel(char c)
        {
            if (Char.IsLetter(c))
            {
                char v = Char.ToLower(c);
                if (v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u')
                    return true;
            }
            return false;
        }
    }
}
