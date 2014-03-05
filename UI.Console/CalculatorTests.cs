using System;
using NUnit.Framework;

namespace UIConsole
{
	[TestFixture]
	public class CalculatorTests
	{
		[Test]
		public void TestValidValuesGetsCorrectSum()
		{
			var calculator = new Calculator(new FakeLogger());
			Assert.AreEqual(calculator.Sum("1", "1"), 2);
		}

		[Test]
		public void TestInvalidValuesThrows()
		{
			var calculator = new Calculator(new FakeLogger());
			Assert.Throws<ArgumentException>(() => calculator.Sum("a", "1"));
		}
	}
}