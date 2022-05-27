using System;
using Singleton.Pattern;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Singleton ===");

            var s1 = SingletonClass.GetInstance();
            var s2 = SingletonClass.GetInstance();
            
            Console.WriteLine($"Are they the same instance?: { s1==s2 }");
        }
    }
}