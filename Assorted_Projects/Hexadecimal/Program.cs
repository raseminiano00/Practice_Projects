using System;

namespace NumberSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var sampleHex = new Decimal(14);
            var sampleDec = NumberConverter.ToHexaDecimal2(sampleHex);
            Console.WriteLine(Math.Min(255, 14).ToString("X2"));
        }
    }
}
