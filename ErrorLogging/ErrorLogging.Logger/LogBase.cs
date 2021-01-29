
namespace ErrorLogging.Logger
{
	public abstract class LogBase
    {
        // To prevent several calls to the same object at the same time.
        protected readonly object lockObj = new object();

        /// <summary>
        /// Super generic Parent Function of the logger module. 
        /// </summary>
        /// <param name="level">Error level: 0, 1, 2.</param>
        /// <param name="category">Error type: Warning, high, Critical.</param>
        /// <param name="message">Error message.</param>
        public abstract void Log(int level, string category, string message);
    }
}
