namespace Study.CrackingTheCodingInterview.Ch1_ArraysAndStrings
{
    public static class Q4_PalindromePermutation
    {
        //given input - check if its permutation of palindrome - palindrome does not need to be limitedto dictionary letters
        //Contraints: Ignore casing and non-letter chars
        // example: Tact Coa -> True; Eg: taco cat, atco cta,....
        public static bool IsPalindromePermutation(string input)
        {
            if(input.Length == 0)
            {
                return false;
            }

            int letterCount = 0;
            Dictionary<char, int> charMap = new Dictionary<char, int>();

            foreach (char c in input) 
            {
                if (char.IsLetter(c)) 
                {
                    if (!charMap.ContainsKey(c)) 
                        charMap.Add(c, 1);
                    else
                        charMap[c]++;

                    letterCount++;
                }
            }

            // if input len is even - each character needs to be even
            // if input len is odd - each but one char have to be even, one have to be odd
            if (letterCount % 2 == 0)
            {
                foreach(var key in charMap.Keys)
                {
                    if (charMap[key] %2 != 0 )
                        return false;
                }
            }
            else
            {
                bool haveOdd = false;

                foreach (var key in charMap.Keys)
                {
                    if (charMap[key] % 2 != 0)
                    {
                        if (!haveOdd)
                            haveOdd= true;
                        else
                            return false;
                    }
                        
                }

            }

            return true;
             
        }
    }
}
