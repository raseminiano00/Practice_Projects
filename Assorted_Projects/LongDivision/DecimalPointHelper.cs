using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongDivision
{
    static class DecimalPointHelper
    {
        public static decimal MoveDecimalPoint(decimal value, int places)
        {
            var placeMove = (10 * places);
            if (placeMove == 0)
                return value;
            return value *= placeMove;
        }
        public static int GetDecimalPlacesCount(decimal value)
        {
            if (value.ToString().IndexOf(".") == -1)
                return 0;

            return value.ToString().Remove(0, value.ToString().IndexOf(".") + 1).Count();
        }
    }
}
