using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.CrackingTheCodingInterview.Ch1_ArraysAndStrings
{
    //given two strings check if they are permutation one of another test, tset - permutations
    //constaints - only lower characters
    public static class Q2_CheckPermutation
    {
        public static bool IsPermutationOpt1(string first, string second)
        {
            //Efficient - create charMap, then empty it - in case of permutation will be empty at the end + early exit

            if(first.Length != second.Length) return false;

            Dictionary<char, int> charMap = new();  //char, count

            // fill char map from 1st string
            foreach (char c in first) 
            {
                if (charMap.TryGetValue(c, out _))
                    charMap[c]++;

                else charMap[c] = 1;
            }

            //empty charmap from 2nd string
            foreach (char c in second)
            {
                if (!charMap.TryGetValue(c, out _))
                    return false;

                else charMap[c]--;

                if(charMap[c] == 0)
                    charMap.Remove(c);
            }

            return charMap.Count == 0;
            //Big O -> O(n+m)
        }

        public static bool IsPermutationOpt2(string first, string second)
        {
            //Naive - sorting strings then comparing them

            if (first.Length != second.Length) return false;

            char[] firstArr = first.ToCharArray();
            char[] secondArr = second.ToCharArray();  

            Array.Sort(firstArr);
            Array.Sort(secondArr);

            first = string.Concat(firstArr);
            second = string.Concat(secondArr);

            return first == second;
            
            
            //Big O -> O(n*logn + m*logm)

        }

    }
}
