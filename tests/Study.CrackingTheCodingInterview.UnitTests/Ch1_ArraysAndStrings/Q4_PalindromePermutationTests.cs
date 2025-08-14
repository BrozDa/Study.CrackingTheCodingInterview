using Study.CrackingTheCodingInterview.Ch1_ArraysAndStrings;

using Xunit;
using Assert = Xunit.Assert;


namespace Study.CrackingTheCodingInterview.UnitTests.Ch1_ArraysAndStrings
{
    public class Q4_PalindromePermutationTests
    {
        private readonly string _validInput = "taco cat";
        private readonly string _invalidInput = "coat";

        [Fact]
        public void IsPalindromePermutation_ValidInput_ReturnsTrue()
        {
            //arrange
            //act
            var result = Q4_PalindromePermutation.IsPalindromePermutation(_validInput);
            //assert
            Assert.True(result);
        }
        [Fact]
        public void IsPalindromePermutation_InvalidInput_ReturnsFalse()
        {
            //arrange
            //act
            var result = Q4_PalindromePermutation.IsPalindromePermutation(_invalidInput);
            //assert
            Assert.False(result);
        }

    }
}
