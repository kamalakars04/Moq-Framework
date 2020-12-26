using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting.GettingStarted
{
    public interface IInstantCalculator
    {
        public int Add(int lhs, int rhs);
        public int Subtract(int lhs, int rhs);
    }
}
