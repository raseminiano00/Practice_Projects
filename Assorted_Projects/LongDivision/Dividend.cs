using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongDivision
{
    public class Dividend
    {
        public decimal DividendValue { get; set; }

        private DividendIterator indexIterator;

        public Dividend(decimal value)
        {
            DividendValue = value;
            indexIterator = new DividendIterator(0,1);
        }
        public int GetLargestNumberForDivisor(int processedDividend,int divisorValue)
        {
            int returnValue = processedDividend;
            for (int size = 0; size <= DividendValue.ToString().Count();size++ )
            {
                returnValue = int.Parse(returnValue.ToString() + getDividentByLastIndex(size).ToString());
                if(divisorValue <= returnValue)
                {
                    return returnValue;
                }
            }
            return returnValue;
        }
        public void SubtractConsumedDividend(int consumed)
        {
            if(consumed < 0)
            {
                consumed=Convert.ToInt32(consumed.ToString().Remove(0, 2));
            }

            int placeToMove = (DividendValue.ToString().Count()-1 - DecimalPointHelper.GetDecimalPlacesCount(DividendValue)) - consumed.ToString().Count();
            var newConsumed = DecimalPointHelper.MoveDecimalPoint(consumed,placeToMove);
            Console.WriteLine(DividendValue + " " + newConsumed);
            DividendValue -= newConsumed;
        }
        private int getDividentByLastIndex(int index)
        {
            var mainList = DividendValue.ToString().ToList();
            mainList.Remove('.');
            return Convert.ToInt32(mainList[index].ToString());
        }
        
        public int getCurrentDividendValue()
        {
            return Convert.ToInt32(new string(DividendValue.ToString().ToList().Skip(indexIterator.Start).Take(indexIterator.End - indexIterator.Start).ToArray()));
        }
        public void AppendZeroToDividendActualValue()
        {
            DividendValue = Convert.ToDecimal(DividendValue.ToString() + "0");
        }
        public void IncrementDividendEndIndex()
        {
            indexIterator.End += 1;
        }
        public void UpdateDividentIndex()
        {
            indexIterator.Start = indexIterator.End;
            indexIterator.End += 1;
        }
    }
}
