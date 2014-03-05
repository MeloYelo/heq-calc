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

		[Test]
		public void TestInvalidValuesLogsErrorMessage()
		{
			var fakeLogger = new FakeLogger();
			var calculator = new Calculator(fakeLogger);
			try
			{
				calculator.Sum("a", "1");
			}
			catch (ArgumentException)
			{
			}
			Assert.IsTrue(fakeLogger.CalledWriteToLog);
		}
	}
}