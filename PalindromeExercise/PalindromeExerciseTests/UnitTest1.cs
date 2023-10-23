using System;
using System.Linq.Expressions;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("james", false)]
        [InlineData("kayak", true)]
        [InlineData("jim", false)]
        [InlineData("rotator", true)]

        public void IsAPalindromeTest(string wordToCheck, bool expected)
        {
            //Arrange
            var shakespeare = new WordSmith();

            //Act
            var actual = shakespeare.IsAPalindrome(wordToCheck);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
