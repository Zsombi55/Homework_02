/*
 * User: Zsombor
 * Date: 2021-01-22
 * Time: 11:45
 * 1st.
 * --------------------------
 * Revision Date: 2021-01-28, 29
 * Revision Time: 22:38, 09:08
 */

using System;
using System.IO;
using ErrorLogging.Logger;

namespace ErrorLogging.Client
{
	class Program
	{
        static void Main(string[] args)
		{
			Console.WriteLine("Select vector length then enter each element one by one as prompted.\n" +
								"If the input process is successful the program will display the vector in one line.\n" +
								"--------------------");
			//
			AppLogger.LoggerSetup(logger: new LogConsole());
            AppLogger.LoggerSetup(logger: new LogFile(filePath: @"..\..\..\TheLog.log"));
			AppLogger.LoggerSetup(logger: new LogDebugger());

            int[] vector = ConsoleHelper.ReadVector();  Console.WriteLine("----------");

            ConsoleHelper.PrintVector(vector);  Console.WriteLine("----------");

			Console.WriteLine("\nEnd.\n");
        }
	}
}
