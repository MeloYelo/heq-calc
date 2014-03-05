using System;

namespace UIConsole
{
	public class Calculator
	{
		private readonly ILogger _logger;

		public Calculator(ILogger logger)
		{
			_logger = logger;
		}

		public float Sum(string value1, string value2)
		{
			float fval1, fval2;
			bool valid = true;

			if (!float.TryParse(value1, out fval1))
			{
				valid = false;
				_logger.WriteToLog("Not a valid number: " + value1);
			}

			if (!float.TryParse(value2, out fval2))
			{
				valid = false;
				_logger.WriteToLog("Not a valid number: " + value2);
			}

			if (!valid)
			{
				throw new ArgumentException("One of the values is not valid");
			}
			return fval1 + fval2;
		}
	}
}