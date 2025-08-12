using Study.CrackingTheCodingInterview.Ch1_ArraysAndStrings;

using Xunit;
using Assert = Xunit.Assert;

namespace Study.CrackingTheCodingInterview.UnitTests.Ch1_ArraysAndStrings
{
    public class Q3_UrlifyTests
    {
        private readonly char[] request1 = "Hi   ".ToCharArray();
        private readonly int trueLen1 = 3;
        private readonly string result1 = "Hi%20";

        private readonly char[] request2 = "Mr John Smith    ".ToCharArray();
        private readonly int trueLen2 = 13;
        private readonly string result2 = "Mr%20John%20Smith";

        [Fact]
        public void UrlifyOpt1_Request1_ReturnsResult1()
        {
            //arrange
            //----

            //act
            var result = Q3_Urlify.UrlifyOpt1(request1,trueLen1);
            //assert
            Assert.Equal(result1, result);
        }

        [Fact]
        public void UrlifyOpt1_Request2_ReturnsResult2()
        {
            //arrange
            //----

            //act
            var result = Q3_Urlify.UrlifyOpt1(request2, trueLen2);
            //assert
            Assert.Equal(result2, result);
        }


    }
}
