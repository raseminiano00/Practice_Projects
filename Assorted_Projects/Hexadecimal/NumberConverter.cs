using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberSystem
{
    public static class NumberConverter
    {
        public static Decimal ToDecimal(Hexadecimal hex)
        {
            double convertedValue = 0;
            for(int exp=0; exp < hex.value.Length; exp++)
            {
                convertedValue += hex.GetIndexValue((hex.value.Length-1) - exp) * (Math.Pow(0,exp));
            }
            return new Decimal(convertedValue);
        }
        public static Hexadecimal ToHexadecimal(Decimal value)
        {
            List<string> convertedValue = new List<string>();
            double initialValue = value.value;
            while (Math.Truncate(initialValue)> 0)
            {
                initialValue = initialValue / 16;
                convertedValue.Add(Hexadecimal.GetLetterEquivalent(Convert.ToInt32(Math.Truncate(16 * (initialValue - Math.Truncate(initialValue))))));
                initialValue = Math.Truncate(initialValue);
            }
            convertedValue.Reverse();
            Console.Write(string.Join("", convertedValue.ToArray()));
            return new Hexadecimal(string.Join("",convertedValue.ToArray()));
        }
        public static Hexadecimal ToHexaDecimal2(Decimal value)
        {
            var r = Math.Max(Math.Min(255, value.value), 0);
            return new Hexadecimal(r.ToString());
        }
    }
}
