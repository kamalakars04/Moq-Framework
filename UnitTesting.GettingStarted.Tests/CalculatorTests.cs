using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTesting.DependencyClass;

namespace UnitTesting.GettingStarted.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Mock<IInstantCalculator> instantCalculator;

        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            var systemUnderTest = new Calculator();
            Assert.That(systemUnderTest.Add(1, 2), Is.EqualTo(3));
        }

        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 5)]
        [TestCase(1000, 1)]
        public void Subtract_Always_ReturnsExpectedResult(int lhs, int rhs)
        {
            var systemUnderTest = new Calculator();
            var expected = lhs - rhs;
            Assert.That(systemUnderTest.Subtract(lhs, rhs), Is.EqualTo(expected));
        }

        // Simple moq testing
        [TestCase(1, 2,3)]
        public void MoqAdd_Always_ReturnsExpectedResult(int lhs,int rhs, int expectedResult)
        {
            instantCalculator = new Mock<IInstantCalculator>(MockBehavior.Strict);
            instantCalculator.Setup(p => p.Add(lhs, rhs)).Returns(expectedResult);
            var systemUnderTest = new InstantCalculator(instantCalculator.Object);
            Assert.That(systemUnderTest.Add(lhs, rhs), Is.EqualTo(expectedResult));
            instantCalculator.VerifyAll();
        }

        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 5)]
        [TestCase(1000, 1)]
        public void MoqSubtract_Always_ReturnsExpectedResult(int lhs, int rhs)
        {
            var expectedResult = lhs - rhs;
            instantCalculator = new Mock<IInstantCalculator>(MockBehavior.Strict);
            instantCalculator.Setup(p => p.Subtract(lhs, rhs)).Returns(expectedResult);
            var systemUnderTest = new InstantCalculator(instantCalculator.Object);
            Assert.That(systemUnderTest.Subtract(lhs, rhs), Is.EqualTo(expectedResult));
            instantCalculator.VerifyAll();
        }

    }
}
