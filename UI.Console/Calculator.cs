using System;
using System.IO;

namespace UIConsole
{
	public class Calculator
	{
		public float Sum(string value1, string value2)
		{
			float fval1, fval2;
			bool valid = true;

			if (!float.TryParse(value1, out fval1))
			{
				valid = false;
				WriteToLog("Not a valid number: " + value1);
			}

			if (!float.TryParse(value2, out fval2))
			{
				valid = false;
				WriteToLog("Not a valid number: " + value2);
			}

			if (!valid)
			{
				throw new ArgumentException("One of the values is not valid");
			}
			return fval1 + fval2;
		}

		private void WriteToLog(string text)
		{
			if (text != null)
			{
				var fi = new FileInfo(@"C:\Temp\CalculatorLog\calc-log-" + DateTime.Now.ToString("yyyyMMdd") + ".log");
				if (!fi.Exists)
				{
					using (var file = fi.CreateText())
					{
						file.WriteLine(text);
					}
				}
				else
				{
					using (var file = fi.AppendText())
					{
						file.WriteLine(text);
					}
				}
			}

		}
	}
}