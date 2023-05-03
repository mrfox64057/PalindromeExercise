using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("ufotofu" , true)]
        [InlineData("nolemonnomelon" , true)]
        [InlineData("dogeeseseegod", true)]
        [InlineData("lookmanohands", false)]
        [InlineData("oozyratinasanitaryzoo", true)]
        [InlineData("birdrib", true)]
        [InlineData("dennissinned", true)]
        [InlineData("amicodingyet", false)]
        [InlineData("dontnod", true)]
        [InlineData("toohottohoot", true)]
        [InlineData("madamimadam", true)]
        [InlineData("drabasafoolaloofasabard", true)]
        public void Test1(string palindrome, bool expected )
        {
            //ARRANGE
            var test = new WordSmith();

            //ACT
            var actual = test.RaceCar(palindrome);

            //ASSERT
            Assert.Equal( expected, actual );
        }
    }
}
