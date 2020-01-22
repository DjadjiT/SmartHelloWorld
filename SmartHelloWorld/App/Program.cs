using System;
using App.implementation;

namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name :");
            String name = System.Console.ReadLine();
            string str = SmartHelloWorld.WriteAGreetings(name, new DateTimeImpl());
            Console.WriteLine(str);
        }
    }
}
