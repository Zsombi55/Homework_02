
namespace ErrorLogging.Logger
{
	public class AppLogger
	{
        // Initializes a logger module holder without deciding on a specific one.
		private static LogBase logger = null;

        /// <summary>
        /// Prepares the logger system with a specific logger module.
        /// </summary>
        /// <param name="logger">A logger type, eg.: Console Logger, Debug Logger, File Logger.</param>
        public static void LoggerSetup(LogBase logger)
        {
            AppLogger.logger = logger;
        }

        /// <summary>
        /// Super generic log writer, the Parent Function.
        /// </summary>
        /// <param name="level">Error level, eg.: Warning, High, Critical.</param>
        /// <param name="message">Error message.</param>
        public static void Log(LogCategoryLevel severity, string message)
        {
            AppLogger.logger?.Log(severity, message);
        }
	}
}
