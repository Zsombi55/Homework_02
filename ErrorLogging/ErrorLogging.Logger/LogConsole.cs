using System;

namespace ErrorLogging.Logger
{
	// Child of the main generic logger module specialized for Console Output.
	public class LogConsole : LogBase
	{
		public override void Log(int level, string category, string message)
		{
            lock (lockObj)
            {
                Console.Error.WriteLine($"Level {level} {category.ToUpper()} >> {message}");
            }
        }
	}
}
