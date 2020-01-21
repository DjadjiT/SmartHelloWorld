using System;
using System.Collections.Generic;
using System.Text;
using App.interfaces;

namespace App.implementation
{
    class SmartHelloWorld 
    {
        public static string WriteAGreetings(string name, DateTimeImpl date)
        {
            if (name.Length < 1)
            {
                return Greetings.Good + " " + date.GetTimeOfDay()+" "+Greetings.world;
            }
            return Greetings.Good + " " + date.GetTimeOfDay() + " " + name;
        }
    }
}
