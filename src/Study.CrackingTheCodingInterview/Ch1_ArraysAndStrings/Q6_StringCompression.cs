using System.Text;

namespace Study.CrackingTheCodingInterview.Ch1_ArraysAndStrings
{
    public static class Q6_StringCompression
    {
        //implement a method fora basic string compression using counts of repeated letters
        //Example: aabccccccaa ->a2b15c3a
        //If the compressed string wont become shorter, then return original string
        
        public static string CompressString(string input)
        {
            char currentChar = input[0];
            int currentCount = 1;
            StringBuilder resultBuilder = new StringBuilder();

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == currentChar)
                {
                    currentCount++;
                }
                else
                {
                    resultBuilder.Append($"{currentChar}{currentCount}");
                    currentChar = input[i];
                    currentCount = 1;
                }
            }

            resultBuilder.Append($"{currentChar}{currentCount}");
            return resultBuilder.Length < input.Length ? resultBuilder.ToString() : input;

            //Big O -> O(n)
        }
    }
}
