namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using Xunit;

    public class FizzBuzzifyAnIntTests
    {
        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedAndInt_ReturnsAString()
        {
            // test here
            // arrange
            var fizzBuzzIntTest = new FizzBuzz();

            // act
            var output = fizzBuzzIntTest.FizzBuzzifyAnInt(2);

            //assert
            output.Should().Be("2");

            output = fizzBuzzIntTest.FizzBuzzifyAnInt(6);
            output.Should().Be("Fizz");

            output = fizzBuzzIntTest.FizzBuzzifyAnInt(10);
            output.Should().Be("Buzz");

            output = fizzBuzzIntTest.FizzBuzzifyAnInt(15);
            output.Should().Be("FizzBuzz");

            output = fizzBuzzIntTest.FizzBuzzValuesForRange(1,3);
            output = fizzBuzzIntTest.FizzBuzzValuesForRange(9,15);
            output = fizzBuzzIntTest.FizzBuzzValuesForRange(40,66);
            output = fizzBuzzIntTest.FizzBuzzValuesForRange(1,100);
            
        }
    }
}
