using System;
using Moq;
using NUnit.Framework;

namespace UIConsole
{
	[TestFixture]
	public class CalculatorTests
	{
		[Test]
		public void TestValidValuesGetsCorrectSum()
		{
			var calculator = new Calculator(Mock.Of<ILogger>());
			Assert.AreEqual(calculator.Sum("1", "1"), 2);
		}

		[Test]
		public void TestInvalidValuesThrows()
		{
			var calculator = new Calculator(Mock.Of<ILogger>());
			Assert.Throws<ArgumentException>(() => calculator.Sum("a", "1"));
		}

		[Test]
		public void TestInvalidValuesLogsErrorMessage()
		{
			var fakeLogger = new Mock<ILogger>();
			var calculator = new Calculator(fakeLogger.Object);
			try
			{
				calculator.Sum("a", "1");
			}
			catch (ArgumentException)
			{
			}
			fakeLogger.Verify(f => f.WriteToLog(It.IsAny<string>()));
		}
	}
}