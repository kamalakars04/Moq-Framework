using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting.GettingStarted
{
    public class Calculator : IInstantCalculator
    {
        public int Add(int lhs, int rhs)
        {
            return lhs + rhs;
        }

        public int Subtract(int lhs, int rhs)
        {
            return lhs - rhs;
        }
    }
}
