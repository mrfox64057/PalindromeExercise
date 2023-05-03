using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool RaceCar(string palindrome)
        {

            int left = 0;
            int right = palindrome.Length - 1;

            while (left < right)
            {
                if (palindrome[left] != palindrome[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;


        }
    }
}
