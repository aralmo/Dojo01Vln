using FluentAssertions;

namespace SimpleMarsRoverKata
{
    public class MarsRoverShould
    {
        [Fact]
        public void BeOnStartingPosition()
        {
            //According to specs the rover should start in 0:0:N position.

            MarsRover
                .Execute("")
                .Should()
                .Be("0:0:N");
        }

        [Theory]
        [InlineData("L", "0:0:W")]
        [InlineData("LL", "0:0:S")]
        [InlineData("LLL", "0:0:E")]
        [InlineData("LLLL", "0:0:N")]
        [InlineData("LLLLL", "0:0:W")]
        public void TurnLeft(string command, string expected)
        {
            MarsRover
                .Execute(command)
                .Should()
                .Be(expected);
        }

        [Theory]
        [InlineData("R", "0:0:E")]
        [InlineData("RR", "0:0:S")]
        [InlineData("RRR", "0:0:W")]
        [InlineData("RRRR", "0:0:N")]
        [InlineData("RRRRR", "0:0:E")]
        public void TurnRight(string command, string expected)
        {
            MarsRover
                .Execute(command)
                .Should()
                .Be(expected);
        }

        [Theory]
        [InlineData("LR", "0:0:N")]
        public void BeAbleToTurnLeftAndRight(string command, string expected)
        {
            MarsRover
                .Execute(command)
                .Should()
                .Be(expected);
        }

    }
}
