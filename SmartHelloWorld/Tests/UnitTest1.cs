using System;
using Xunit;
using App;
using NFluent;

namespace Tests
{
    public class UnitTest1
    {
        [Theory]
        [InLineData(7, "", "Good morning world")]
        public void should_return_MorningGrettings_when_dayTime_is_morning(int hour, String name, String expected)
        {
            string sut = SmartHelloWorld.WriteAGreetings(name, new DateTimeImpl(hour));
            Check.That(sut).isEqualsTo(expected);
        }

        [Theory]
        [InLineData(15, "", "Good afternoon world")]
        public void should_return_AfternoonGrettings_when_dayTime_is_afternoon(int hour, String name, String expected)
        {
            string sut = SmartHelloWorld.WriteAGreetings(name, new DateTimeImpl(hour));
            Check.That(sut).isEqualsTo(expected);
        }

        [Theory]
        [InLineData(23, "", "Good night world")]
        public void should_return_NightGrettings_when_dayTime_is_night(int hour, String name, String expected)
        {
            string sut = SmartHelloWorld.WriteAGreetings(name, new DateTimeImpl(hour));
            Check.That(sut).isEqualsTo(expected);
        }

    }
}
