namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using Xunit;

    public class FizzBuzzifyAnIntTests
    {
        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedAndInt_ReturnsAString()
        {
            // arrange
            var fizzBuzzIntTest = new FizzBuzz();

            // act
            var output = fizzBuzzIntTest.FizzBuzzValuesForRange(1,10);

            var fizzBuzzIntTest2 = new FizzBuzz();
            var output2 = fizzBuzzIntTest2.pairs.Add(2, "Even");
            output2 = fizzBuzzIntTest2.FizzBuzzValuesForRange(1,10);

            var fizzBuzzIntTest3 = new FizzBuzz();
            var output3 = fizzBuzzIntTest3.pairs.Add(2, "Quack");
            output3 = fizzBuzzIntTest3.pairs.Add(5, "Honk");
            output3 = fizzBuzzIntTest3.FizzBuzzValuesForRange(1,10);
        }
    }
}
