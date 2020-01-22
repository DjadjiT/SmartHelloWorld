using System;
using Xunit;
using App;
using NFluent;

using App.implementation;

namespace Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(7, "", "Good morning world")]
        [InlineData(11, "", "Good morning world")]
        [InlineData(11, "test", "Good morning test")]
        [InlineData(9, "X", "Good morning X")]
        public void should_return_MorningGrettings_when_dayTime_is_morning(int hour, String name, String expected)
        {
            string sut = SmartHelloWorld.WriteAGreetings(name, new DateTimeImpl(hour));
            Check.That(sut).IsEqualTo(expected);
        }

        [Theory]
        [InlineData(15, "", "Good afternoon world")]
        [InlineData(17, "", "Good afternoon world")]
        [InlineData(13, "test", "Good afternoon test")]
        [InlineData(15, "X", "Good afternoon X")]
        public void should_return_AfternoonGrettings_when_dayTime_is_afternoon(int hour, String name, String expected)
        {
            string sut = SmartHelloWorld.WriteAGreetings(name, new DateTimeImpl(hour));
            Check.That(sut).IsEqualTo(expected);
        }

        [Theory]
        [InlineData(23, "", "Good night world")]
        [InlineData(5, "test", "Good night test")]
        [InlineData(21, "", "Good night world")]
        [InlineData(23, "X", "Good night X")]
        public void should_return_NightGrettings_when_dayTime_is_night(int hour, String name, String expected)
        {
            string sut = SmartHelloWorld.WriteAGreetings(name, new DateTimeImpl(hour));
            Check.That(sut).IsEqualTo(expected);
        }

        [Theory]
        [InlineData(23, "X", "Good night X")]
        [InlineData(7, "X", "Good morning X")]
        public void should_return_Grettings_with_name_when_name_in_input(int hour, String name, String expected)
        {
            string sut = SmartHelloWorld.WriteAGreetings(name, new DateTimeImpl(hour));
            Check.That(sut).IsEqualTo(expected);
        }

        [Theory]
        [InlineData(23, "", "Good night world")]
        [InlineData(7, "", "Good morning world")]
        public void should_return_Grettings_without_name_when_no_name_in_input(int hour, String name, String expected)
        {
            string sut = SmartHelloWorld.WriteAGreetings(name, new DateTimeImpl(hour));
            Check.That(sut).IsEqualTo(expected);
        }
    }
}
