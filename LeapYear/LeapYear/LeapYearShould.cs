
using FluentAssertions;

namespace LeapYear
{
    public class LeapYearShould
    {
        
        [Theory]
        [InlineData(2024)]
        [InlineData(2016)]
        public void ReturnTrue_YearDivisibleBy4(int year)
        {
            var leapYear =LeapYear.IsLeapYear(year);
            leapYear.Should().BeTrue();

        }

        [Theory]
        [InlineData(2025)]
        [InlineData(2017)]
        public void ReturnFalse_YearNotDivisibleBy4(int year)
        {
            var leapYear = LeapYear.IsLeapYear(year);
            leapYear.Should().BeFalse();
        }

        [Theory]
        [InlineData(1992)]
        public void ReturnTrue_YearDivisibleBy4ButNotBy100(int year)
        {
            var leapYear = LeapYear.IsLeapYear(year);
            leapYear.Should().BeTrue();
        }

        [Theory]
        [InlineData(2000)]
        [InlineData(2400)]
        public void ReturnTrue_YearDivisibleBy400(int year)
        {
            var leapYear = LeapYear.IsLeapYear(year);
            leapYear.Should().BeTrue();
        }

        [Theory]
        [InlineData(2100)]
        [InlineData(2200)]
        public void ReturnFalse_YearDivisibleBy100ButNotBy400(int year)
        {
            var leapYear = LeapYear.IsLeapYear(year);
            leapYear.Should().BeFalse();
        }


        [Fact]
        public void ThrowsException_NegativeInput()
        {
            Assert.Throws<ArgumentException>(() => LeapYear.IsLeapYear(-2024));
        }

    }
}