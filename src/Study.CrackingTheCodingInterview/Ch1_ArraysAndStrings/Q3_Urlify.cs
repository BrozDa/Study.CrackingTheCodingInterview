using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.CrackingTheCodingInterview.Ch1_ArraysAndStrings
{
    //replace all spaces with "%20"
    //Constraints: string has sufficient space to hold additional characters
    //Bonus - no additional DS
    // Example: input (char arr) "Mr_John_Smith____", truelen = 13 (without the end buffer)
    public static class Q3_Urlify
    {
        public static string UrlifyOpt1(char[] input, int trueLen)
        {
            int endIndex = input.Length - 1;
            int charIndex = trueLen-1;

            while(charIndex >= 0)
            {
                if (input[charIndex] == ' ')
                {
                    input[endIndex--] = '0';
                    input[endIndex--] = '2';
                    input[endIndex--] = '%';
                }
                else
                {
                    input[endIndex--] = input[charIndex];
                }
                charIndex--;
            }

            return new string(input);
            

        }

    }
}
