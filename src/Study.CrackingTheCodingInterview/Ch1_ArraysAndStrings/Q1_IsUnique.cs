namespace Study.CrackingTheCodingInterview.Ch1_ArraysAndStrings
{

    //Implement an alg to determine if string has all unique characters
    //Bonus: Do not use additional data structure

    //constraint, input is all lowerCase
    public static class Q1_IsUnique
    {

        public static bool IsUniqueOpt1(string input)
        {
            //sort it, then check if neighboring are always different

            char[] chars = input.ToCharArray();
            Array.Sort(chars);

            for (int i = 1; i < chars.Length; i++) 
            {
                if (chars[i] == chars[i - 1])
                    return false;
            }

            return true;

            //Big O -> O(nlogn)

        }
        public static bool IsUniqueOpt2(string input)
        {

            // check if rest of string for each character
            bool result = true;

            for (int i = 0; i < input.Length && result; i++) 
            {
                for( int j = i+1; j < input.Length-1; j++)
                {
                    if (input[i] == input[j])
                    {
                        result = false;
                        break;
                    }
                        
                }
            }
            //Big O -> O(n^2)
            return result;
        }
        public static bool IsUniqueOpt3(string input)
        {
            HashSet<char> charMap = new HashSet<char>();

            foreach (char c in input) 
            {
                if(!charMap.Add(c))
                    return false;
            }

            //Big O -> O(n) ; single iteration
            return true; 
         }

    }
}
