using System.Diagnostics;

namespace ErrorLogging.Logger
{
	// Child of the main generic logger module specialized for IDE Debugger Output.
	public class LogDebugger : LogBase
	{
		public override void Log(int level, string category, string message)
		{
            lock (lockObj)
            {
                Debugger.Log(level, category, message);
            }
        }
	}
}
