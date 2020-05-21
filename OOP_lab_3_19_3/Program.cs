using System;
using System.IO;

namespace OOP_lab_3_19_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("input.txt");

            string str = file.ReadToEnd();

            string[] words = str.Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

            int minLength = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length <= minLength)
                {
                    minLength = word.Length;
                }
            }

            StreamWriter newFile = File.CreateText("output.txt");

            foreach (string word in words)
            {
                if (word.Length == minLength)
                {
                    newFile.Write("{0} ", word);
                }
            }

            newFile.Close();
        }
    }
}
