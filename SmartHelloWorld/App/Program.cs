using System;
using App.implementation;

namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = SmartHelloWorld.WriteAGreetings("Djadji", new DateTimeImpl(13));
            Console.WriteLine(str);
        }
    }
}
