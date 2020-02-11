using System;
using System.Collections.Generic;
namespace PigLatinLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, and welcome to pig latin!  Enter a word: ");
            string input = Console.ReadLine().ToLower();
            string vowel = "aeiou";
            string[] inputArray = input.Split(" ");

            foreach (string w in inputArray)
            {
                if (vowel.Contains(w[0]))
                {
                    Console.Write(Vowel(w) + " ");
                }
                else
                {
                    Console.Write(Consonant(w) + " ");
                }
            }
        }
        private static string Consonant(string input)
        {
            string consonant = "bcdfghjklmnpqrstvwxyz";
            Stack<char> cStack = new Stack<char>();
            //Must initialize the output, or else you can't "+=" to it
            string output = "";
            int i = 0;
            while (consonant.Contains(input[i]))
            {
                cStack.Push(input[i]);
                i++;
            }
            for (int j = 0; j < (input.Length - j); j++)
            {
                output += input[j + j];
            }
            output += cStack.Pop();

            return (output + "ay");
        }

        private static string Vowel(string input)
        {
            return (input + "way");
        }
    }
}