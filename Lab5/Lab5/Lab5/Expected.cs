using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Lab5
{
    public class Expected
    {
        public static int GetAreaRectangle([Range(0, 20)] int i, [Range(0, 20)] int n)
        {
            var SR = i * n;
            return SR;
        }

        public static int GetLengthRectangle([Range(0, 20)] int i, [Range(0, 20)] int n)
        {
            var PR = (i + n) * 2;
            return PR;
        }

        public static int GetAreaSquare([Range(0, 20)] int i)
        {
            var SS = i * i;
            return SS;
        }

        public static int GetLengthSquare([Range(0, 20)] int i)
        {
            var PS = i * 4;
            return PS;
        }

        public static double GetAreaTreangle([Range(0, 20)] int i, [Range(0, 20)] int n, [Range(0, 20)] int m)
        {
            var p = 0.5 * (i + n + m);
            var ST1 = p * (p - i) * (p - n) * (p - m);
            double ST = Math.Sqrt(ST1);
            return ST;
        }

        public static int GetLengthTreangle([Range(0, 20)] int i, [Range(0, 20)] int n, [Range(0, 20)] int m)
        {
            var PT = i + n + m;
            return PT;
        }
    }
}
