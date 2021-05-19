using System;

namespace oehen.arguard.example
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("oehen.arguard example");
            Console.ReadKey();
            TestMethod.TestNullValidation(null);
            Console.ReadKey();
        }
    }
}