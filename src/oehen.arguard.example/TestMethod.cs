using System;

namespace oehen.arguard.example
{
    public static class TestMethod
    {
        public static void TestNullValidation(string argument)
        {
            argument.ThrowIfNull(nameof(argument));
            
            Console.Write(argument);
        }
    }
}