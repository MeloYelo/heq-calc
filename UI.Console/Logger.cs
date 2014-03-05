using System;
using System.IO;

namespace UIConsole
{
	public class Logger
	{
		public void WriteToLog(string text)
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