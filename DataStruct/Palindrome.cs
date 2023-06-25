using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    class Palindrome
    {
        private static char[] characters;
        private static int left = 0, right;
        public static bool isPalindrome(string input)
        {
            characters = input.ToCharArray();
            right = characters.Length - 1;
            while (left < right)
            {
                if(characters[left] != characters[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        public static bool isPalindromeLinq(string input)
        {
            // Remove any whitespace and convert to lowercase
            input = input.Replace(" ", "").ToLower();

            // Reverse the string
            char[] charArray = input.ToCharArray();
            var reversed = charArray.Reverse().Select(x => x).ToList();
            var strings = string.Join("", reversed);
            // Compare the original string with the reversed string
            return input == strings;
        }
        bool isPalindromeForLoop(string test)
        {
            string revs = "";
            var a = test.Length - 1;

            for (int i = a; i >= 0; i--) //String Reverse  
            {
                revs += test[i].ToString();
            }
            if (revs == test) // Checking whether string is palindrome or not  
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void print()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            if (isPalindromeLinq(input))
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }
    }
}
