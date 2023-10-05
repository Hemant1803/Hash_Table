using System.Diagnostics;

namespace Hash_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "“Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations”";
            string wordToRemove = "avoidable";
            string[] words = sentence.Split(' ');

            UC1_2_3 counter = new UC1_2_3(10); // Choose an appropriate bucket count

            foreach (var word in words)
            {
                counter.AddWord(word);
            }

            Console.WriteLine("Word Frequencies:");
            Console.WriteLine(sentence);
            foreach (var word in words)
            {
               
                int frequency = counter.GetWordFrequency(word);
                Console.WriteLine($"{word}: {frequency}");
            }
           Console.WriteLine("**************************************");
            counter.RemoveWord(wordToRemove);

            Console.WriteLine("Phrase after removing the word:");
            foreach (var word in words)
            {
                if (word != wordToRemove)
                {
                    Console.Write(word + " ");
                }
            }
            Console.WriteLine();
        
    }
    }
}