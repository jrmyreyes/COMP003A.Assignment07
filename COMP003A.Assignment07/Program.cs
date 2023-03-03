/*
 * Author: Ron Jeremy Reyes
 * Course: COMP-003A
 * Purpose: Assignment for week 7
 * 
 */
namespace COMP003A.Assignment07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Array CharacterCounter Section */
            SectionSeparator("Array - CharacterCounter");
            Console.WriteLine("Please enter a letter");
            char characterInput = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter a word");
            string word = Console.ReadLine();

            CharacterCounter(characterInput, word);


            /* Array IsPalindrome Section */
            SectionSeparator("Array - IsPalindrome");
            Console.WriteLine("Please enter a word to check if it is a palindrome");
            string word_1 = Console.ReadLine();
            IsPalindrome(word_1);
        }

        /// <summary>
        /// Separates section using different headers
        /// </summary>
        /// <param name="sectionSeparator">Header name</param>
        static void SectionSeparator(string sectionSeparator)
        {
            Console.WriteLine("".PadLeft(50, '*'));
            Console.WriteLine($"\t{sectionSeparator} Section");
            Console.WriteLine("".PadLeft(50, '*'));
        }

        /// <summary>
        /// Counts inputted character
        /// </summary>
        /// <param name="characterInput">user input character</param>
        /// <param name="word">user input word</param>
        static void CharacterCounter(char characterInput, string word)
        {
            string WordInput = word;
            char ch = characterInput;
            ch = char.ToLower(ch); // convert uppercase {charInput} into lowercase
            word = word.ToLower(); // convert uppercase 

            int freq = word.Count(f => (f == ch));
            Console.WriteLine($"There are {freq} letter {characterInput} in the word {WordInput}");
        }

        /// <summary>
        /// Checks if the word is a Palindrome
        /// </summary>
        /// <param name="word_1">user input string</param>
        static void IsPalindrome(string word_1)
        {
            string input = word_1; // |<----------------------------------------------------------------------- a string is an array of characters
            input = input.ToLower(); // |<--------------------------------------------------------------------- convert uppercase letters to lowercases
            string reverse = new string(input.ToCharArray().Reverse().ToArray()); // |<------------------------ copies {input}'s char into an array and reverses it

            if (word_1 == "") // checks if {reverse}'s array is still == to {input}'s array; if not IsPalindrome() == "false"
            {
                Console.WriteLine("invalid");
            }
            else if (input == reverse)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");
        }


    }
}