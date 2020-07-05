using System;
using System.Collections.Generic;
using System.Text;

namespace LongDivision
{
    class Matrix
    {
        public static int[,] multiplyMatrices(int[,] a, int[,] b)
        {
            var ret = new int[a.GetLength(0), b.GetLength(1)];
            for (int iteGroupA = 0;iteGroupA < a.GetLength(0); iteGroupA++)
            {
                Console.WriteLine("Group A loop");
                for (int groupB = 0; groupB < b.GetLength(1); groupB++)
                {
                    Console.WriteLine("Group B loop");

                    for (int innerGroupA = 0; innerGroupA < a.GetLength(1); innerGroupA++)
                    {
                        Console.WriteLine("Group A inner loop");

                        ret[iteGroupA, groupB] += a[iteGroupA, innerGroupA] * b[innerGroupA, groupB];
                    }
                }
            }
            return ret;
        }
        public static int[,] multiplyMatrices2(int[,] a, int[,] b)
        {
            var ret = new int[a.GetLength(0), b.GetLength(1)];
            int firstMatrixIterator=0;
            int secondMatrixIterator = 0;
            var tempValue = 0;
            for (int groupB = 0; groupB < b.GetLength(1)*2; groupB++)
            {
                for (int innerGroupA = 0; innerGroupA < a.GetLength(1); innerGroupA++)
                {
                    Console.WriteLine(firstMatrixIterator+","+innerGroupA +" X "+ innerGroupA+" "+ secondMatrixIterator);
                    
                    ret[firstMatrixIterator, secondMatrixIterator] += a[firstMatrixIterator, innerGroupA] * b[innerGroupA, secondMatrixIterator];
                }
                firstMatrixIterator += 1;
                secondMatrixIterator += 1;
                if(firstMatrixIterator == a.GetLength(0))
                {
                    firstMatrixIterator = 0;
                }
                if(secondMatrixIterator == b.GetLength(1))
                {
                    secondMatrixIterator = 0;
                }
            }
            return ret;
        }
    }
}
