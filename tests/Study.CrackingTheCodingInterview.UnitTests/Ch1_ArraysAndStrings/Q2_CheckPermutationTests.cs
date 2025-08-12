using Study.CrackingTheCodingInterview.Ch1_ArraysAndStrings;

using Xunit;
using Assert = Xunit.Assert;

namespace Study.CrackingTheCodingInterview.UnitTests.Ch1_ArraysAndStrings
{
    public class Q2_CheckPermutationTests
    {
        private readonly (string first, string second) _validInput = ("valid", "dilav");
        private readonly (string first, string second) _invalidInput = ("valid", "tests");
        private readonly (string first, string second) _diffLenghts = ("valid", "validd");
        private readonly (string first, string second) _singleCharInput = ("a", "a");

        [Fact]
        public void IsPermutationOpt1_ValidInput_ReturnsTrue() 
        { 
            //arrange
            // -------

            //act
            var result = Q2_CheckPermutation.IsPermutationOpt1(_validInput.first, _validInput.second);

            //assert
            Assert.True(result);
        }
        [Fact]
        public void IsPermutationOpt1_InvalidInput_ReturnsFalse()
        {
            //arrange
            // -------

            //act
            var result = Q2_CheckPermutation.IsPermutationOpt1(_invalidInput.first, _invalidInput.second);

            //assert
            Assert.False(result);
        }
        [Fact]
        public void IsPermutationOpt1_DiffLengths_ReturnsFalse()
        {
            //arrange
            // -------

            //act
            var result = Q2_CheckPermutation.IsPermutationOpt1(_diffLenghts.first, _diffLenghts.second);

            //assert
            Assert.False(result);
        }
        [Fact]
        public void IsPermutationOpt1_SingleCharInput_ReturnsTrue()
        {
            //arrange
            // -------

            //act
            var result = Q2_CheckPermutation.IsPermutationOpt1(_singleCharInput.first, _singleCharInput.second);

            //assert
            Assert.True(result);
        }




        [Fact]
        public void IsPermutationOpt2_ValidInput_ReturnsTrue()
        {
            //arrange
            // -------

            //act
            var result = Q2_CheckPermutation.IsPermutationOpt2(_validInput.first, _validInput.second);

            //assert
            Assert.True(result);
        }
        [Fact]
        public void IsPermutationOpt2_InvalidInput_ReturnsFalse()
        {
            //arrange
            // -------

            //act
            var result = Q2_CheckPermutation.IsPermutationOpt2(_invalidInput.first, _invalidInput.second);

            //assert
            Assert.False(result);
        }
        [Fact]
        public void IsPermutationOpt2_DiffLengths_ReturnsFalse()
        {
            //arrange
            // -------

            //act
            var result = Q2_CheckPermutation.IsPermutationOpt2(_diffLenghts.first, _diffLenghts.second);

            //assert
            Assert.False(result);
        }
        [Fact]
        public void IsPermutationOpt2_SingleCharInput_ReturnsTrue()
        {
            //arrange
            // -------

            //act
            var result = Q2_CheckPermutation.IsPermutationOpt2(_singleCharInput.first, _singleCharInput.second);

            //assert
            Assert.True(result);
        }

    }
}
