using System;
using System.IO;

namespace procesare_caractere
{
    internal class fileText
    {
        StreamReader reader;
        TextReader reader2;
        string text;
        int nrOfLines = 0, nrOfVowels=0, nrOfConsonants=0, nrOfCharacters=0;
        public fileText(string path)
        {
            reader = new StreamReader(path);
            while(!reader.EndOfStream)
            {
                reader.ReadLine();
                nrOfLines++;
            }
            reader2 = new StreamReader(path);
            text = reader2.ReadToEnd();
        }

        bool isVowel (char c)
        {
            if (Char.IsLetter(c))
            {
                char v = Char.ToLower(c);
                if (v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u')
                    return true;
            }
            return false;
        }
        public int getNrOfVowels()
        {
            for (int i = 0; i < text.Length; i++)
                if (isVowel(text[i]))
                    nrOfVowels++;
            return nrOfVowels;
        }

        bool isConsonant(char c)
        {
            if (Char.IsLetter(c))
            {
                char v = Char.ToLower(c);
                if (v != 'a' && v != 'e' && v != 'i' && v != 'o' && v != 'u')
                    return true;
            }
            return false;
        }
        public int getNrOfConsonants()
        {
            for (int i = 0; i < text.Length; i++)
                if (isConsonant(text[i]))
                    nrOfConsonants++;
            return nrOfConsonants;
        }

        bool isCharacter(char c) //character=letter, digit or punctuation mark
        {
            if (Char.IsLetterOrDigit(c) || Char.IsPunctuation(c))
                return true;
            return false;
        }
        public int getNrOfCharacters()
        {
            for (int i = 0; i < text.Length; i++)
                if (isCharacter(text[i]))
                    nrOfCharacters++;
            return nrOfCharacters;
        }

        public int getNrOfLines()
        {
            return nrOfLines;
        }
    }
}