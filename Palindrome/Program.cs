using System;

namespace Palindrome
{
    class Program
    {
        //function to check if a string is palindrome or not
        static bool IsItPalindrome(string Word)
        {
            {
                int i = 0;
                int end = Word.Length - 1;

                while (end > 1)
                {
                    // checks if mirrored letters are equal
                    if (Word[i++] != Word[end--])
                    {
                        return false;
                    }
                }
                // returns true if they are equal
                return true;

            }
        }

        //function to make a string from the odd indices 
        static string MakeOddString(string Word)
        {
            string Odds = "";
            for (int i = 1; i < Word.Length; i = i + 2)
            {
                Odds = Odds + Word[i];

            }
            return Odds;
        }

        //function to make an even string

        static string MakeEvenString(string Word)
        {
            string Evens = "";
            for (int i = 0; i < Word.Length; i = i + 2)
            {
                Evens = Evens + Word[i];

            }

            return Evens;

        }

        // function to check if even AND odd strings are palindromes

        static void CheckOddEven(string Word)
        {
            //generate odd indices string
            string Odd = MakeOddString(Word);

            //generate even indices string
            string Even = MakeEvenString(Word);

            if (IsItPalindrome(Odd) && IsItPalindrome(Even))
            {
                Console.WriteLine("The input " + Word + " is an Even/Odd palindrome");
            }
            else
            {
                Console.WriteLine("The input " + Word + " is not a Even/Odd palindrome");
            }


        }




        // main function where the CheckOddEven funcitno is called
        static void Main()
        {
            //enter the word
            Console.WriteLine("Please enter the word you want to check if it is a palindrome:");
            string Word = Console.ReadLine();
            // run the palindrome function
            CheckOddEven(Word);
        }
    }
}
