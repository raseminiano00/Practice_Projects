using System;
using System.Collections.Generic;
using System.Text;

namespace NumberSystem
{

    enum LetterEquivalent
    {
        A=10,
        B,
        C,
        D,
        E,
        F,
    }

    public class Hexadecimal
    {

        Dictionary<string, int> LetterEquivalent;
        

        public Hexadecimal(string value)
        {
            LetterEquivalent = new Dictionary<string, int>();
            LetterEquivalent.Add("A", 10);
            LetterEquivalent.Add("B", 11);
            LetterEquivalent.Add("C", 12);
            LetterEquivalent.Add("D", 13);
            LetterEquivalent.Add("E", 14);
            LetterEquivalent.Add("F", 15);
            this.value = value;
        }
        public string value { get; set; }
        
        public double GetIndexValue(int index)
        {
            var value = this.value[index].ToString();

            if (double.TryParse(value,out double n))
            {
                return n;
            }
            return LetterEquivalent[value];
        }
        public static string GetLetterEquivalent(int number)
        {
            if (number < 10 || number > 15)
                return number.ToString();
            Dictionary<int, string> LetterEquivalent = new Dictionary<int,string>();
            LetterEquivalent.Add(10,"A");
            LetterEquivalent.Add(11,"B");
            LetterEquivalent.Add(12,"C");
            LetterEquivalent.Add(13,"D");
            LetterEquivalent.Add(14,"E");
            LetterEquivalent.Add(15,"F");
            return LetterEquivalent[number];
        }
    }
}
