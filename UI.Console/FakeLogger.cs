namespace UIConsole
{
	public class FakeLogger:ILogger
	{
		public void WriteToLog(string text)
		{
			CalledWriteToLog = true;
		}

		public bool CalledWriteToLog { get; set; }
	}
}