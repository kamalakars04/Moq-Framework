using System;
using System.Collections.Generic;
using System.Text;
using UnitTesting.GettingStarted;

namespace UnitTesting.DependencyClass
{
    public class InstantCalculator
    {
        readonly IInstantCalculator instantCalculator;
        public InstantCalculator(IInstantCalculator instantCalculator)
        {
            this.instantCalculator = instantCalculator;
        }

        public int Add(int lhs, int rhs)
        {
            return instantCalculator.Add(lhs, rhs);
        }

        public int Subtract(int lhs, int rhs)
        {
            return instantCalculator.Subtract(lhs, rhs);
        }
    }
}
