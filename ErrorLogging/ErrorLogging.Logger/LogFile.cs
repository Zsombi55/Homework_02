using System;
using System.IO;

namespace ErrorLogging.Logger
{
    // Child of the main generic logger module specialized for IDE Debugger Output.
	public class LogFile : LogBase
	{
        public LogFile() : this (null) {}

        public LogFile(string filePath)
        {
            FilePath = filePath ?? string.Empty;
        }

        public string FilePath { get; }

        //public string filePath = @"..\..\..\TheLog.log";

		public override void Log(int level, string category, string message)
		{
            //lock (lockObj)
            //{
            //    // Writing to text file.
            //    using (StreamWriter streamWriter = new StreamWriter(filePath))
            //    {
            //        streamWriter.WriteLine($"Level {level} {category.ToUpper()} >> {message}");
            //        streamWriter.Close();
            //    }
            //}

            string filePath = FilePath;
            if (string.IsNullOrWhiteSpace(filePath))
            {
                filePath = @"..\..\..\TheLog.log";
            }

            string entry = $"{DateTime.Now} -  {level} - {message}";
            File.AppendAllLines(filePath, new[] { entry });
        }
	}
}
