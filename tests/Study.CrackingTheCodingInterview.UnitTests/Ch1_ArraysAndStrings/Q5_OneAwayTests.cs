using Study.CrackingTheCodingInterview.Ch1_ArraysAndStrings;

using Xunit;
using Assert = Xunit.Assert;


namespace Study.CrackingTheCodingInterview.UnitTests.Ch1_ArraysAndStrings
{
    public class Q5_OneAwayTests
    {
        private readonly (string first, string second) _validOneAwayByAdd = ("pale", "pales");
        private readonly (string first, string second) _invalidOneAwayByAdd = ("pale", "paales");

        private readonly (string first, string second) _validOneAwayByRemove = ("pale", "ple");
        private readonly (string first, string second) _invalidOneAwayByRemove = ("pale", "pl");

        private readonly (string first, string second) _validOneAwayByReplace= ("pale", "bale");
        private readonly (string first, string second) _invalidOneAwayByReplace = ("pale", "bake");

        [Fact]
        public void IsOneAway_ValidOneAwayByAdd_ReturnsTrue()
        {
            //arrange
            //act
            var result = Q5_OneAway.IsOneAway(_validOneAwayByAdd.first, _validOneAwayByAdd.second);
            //assert
            Assert.True(result);
        }
        [Fact]
        public void IsOneAway_InvalidOneAwayByAdd_ReturnsFalse()
        {
            //arrange
            //act
            var result = Q5_OneAway.IsOneAway(_invalidOneAwayByAdd.first, _invalidOneAwayByAdd.second);
            //assert
            Assert.False(result);
        }

        [Fact]
        public void IsOneAway_ValidOneAwayByRemove_ReturnsTrue()
        {
            //arrange
            //act
            var result = Q5_OneAway.IsOneAway(_validOneAwayByRemove.first, _validOneAwayByRemove.second);
            //assert
            Assert.True(result);
        }
        [Fact]
        public void IsOneAway_InvalidOneAwayByRemove_ReturnsFalse()
        {
            //arrange
            //act
            var result = Q5_OneAway.IsOneAway(_invalidOneAwayByRemove.first, _invalidOneAwayByRemove.second);
            //assert
            Assert.False(result);
        }

        [Fact]
        public void IsOneAway_ValidOneAwayByReplace_ReturnsTrue()
        {
            //arrange
            //act
            var result = Q5_OneAway.IsOneAway(_validOneAwayByReplace.first, _validOneAwayByReplace.second);
            //assert
            Assert.True(result);
        }
        [Fact]
        public void IsOneAway_InvalidOneAwayByReplace_ReturnsFalse()
        {
            //arrange
            //act
            var result = Q5_OneAway.IsOneAway(_invalidOneAwayByReplace.first, _invalidOneAwayByReplace.second);
            //assert
            Assert.False(result);
        }
    }
}
