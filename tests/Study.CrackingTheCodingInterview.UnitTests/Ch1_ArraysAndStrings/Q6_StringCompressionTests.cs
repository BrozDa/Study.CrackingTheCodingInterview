using Study.CrackingTheCodingInterview.Ch1_ArraysAndStrings;

using Xunit;
using Assert = Xunit.Assert;


namespace Study.CrackingTheCodingInterview.UnitTests.Ch1_ArraysAndStrings
{
    public class Q6_StringCompressionTests
    {
        private readonly string input1 = "aabccccccaa";
        private readonly string result1 = "a2b1c6a2"; //2a is same lenght

        private readonly string input2 = "aa";
        private readonly string result2 = "aa"; //2a is same lenght

        private readonly string input3 = "abdc";
        private readonly string result3 = "abdc";// would not get shorter


        [Fact]
        public void CompressString_Input1_ReturnsResult1()
        {
            //act
            var result = Q6_StringCompression.CompressString(input1);

            //assert
            Assert.Equal(result1, result);
            
        }
        [Fact]
        public void CompressString_Input2_ReturnsResult2()
        {
            //act
            var result = Q6_StringCompression.CompressString(input2);

            //assert
            Assert.Equal(result2, result);

        }
        [Fact]
        public void CompressString_Input3_ReturnsResult3()
        {
            //act
            var result = Q6_StringCompression.CompressString(input3);

            //assert
            Assert.Equal(result3, result);

        }
    }
}
