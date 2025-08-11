using Study.CrackingTheCodingInterview.Ch1_ArraysAndStrings;

using Xunit;
using Assert = Xunit.Assert;

namespace Study.CrackingTheCodingInterview.UnitTests;

public class Q1_IsUniqueTests
{

    private readonly string _validInput = "valid";
    private readonly string _invalidInput = "invalid";

    [Fact]
    public void IsUniqueOpt1_ValidInput_ReturnsTrue()
    {
        //arrange
        /*Nothing to do*/

        //act
        var result = Q1_IsUnique.IsUniqueOpt1(_validInput);

        //assert
        Assert.True(result);
    }

    [Fact]
    public void IsUniqueOpt1_InvalidInput_ReturnsFalse()
    {
        //arrange
        /*Nothing to do*/

        //act
        var result = Q1_IsUnique.IsUniqueOpt1(_invalidInput);

        //assert
        Assert.False(result);
    }

 



    [Fact]
    public void IsUniqueOpt2_ValidInput_ReturnsTrue()
    {
        //arrange
        /*Nothing to do*/

        //act
        var result = Q1_IsUnique.IsUniqueOpt2(_validInput);

        //assert
        Assert.True(result);
    }

    [Fact]
    public void IsUniqueOpt2_InvalidInput_ReturnsFalse()
    {
        //arrange
        /*Nothing to do*/

        //act
        var result = Q1_IsUnique.IsUniqueOpt2(_invalidInput);

        //assert
        Assert.False(result);
    }

  


    [Fact]
    public void IsUniqueOpt3_ValidInput_ReturnsTrue()
    {
        //arrange
        /*Nothing to do*/

        //act
        var result = Q1_IsUnique.IsUniqueOpt3(_validInput);

        //assert
        Assert.True(result);
    }

    [Fact]
    public void IsUniqueOpt3_InalidInput_ReturnsFalse()
    {
        //arrange
        /*Nothing to do*/

        //act
        var result = Q1_IsUnique.IsUniqueOpt3(_invalidInput);

        //assert
        Assert.False(result);
    }


}
