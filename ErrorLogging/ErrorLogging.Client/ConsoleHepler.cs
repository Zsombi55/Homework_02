using System;
using ErrorLogging.Logger;

namespace ErrorLogging.Client
{
	public static class ConsoleHelper
	{
        /// <summary>
        /// Creates and returns an integer array representing a vector.
        /// 1. Asks for the desired vector size to create an empty integer array accordingly.
        /// 2. Asks for the array elements and validates them to be integer numbers to fill the array.
        /// </summary>
        /// <returns name="vector" type="int array">A number array representing a vector.</returns>
        /// <exceptions name="size" first_type="string" parsed_type="int">
        ///     Not a number.
        ///     Is negative or zero.
        /// </exception>
        /// <exceptions name="element" first_type="string" parsed_type="int">
        ///     Not a number.
        ///     Is negative or zero.
        /// </exception>
		public static int[] ReadVector()
		{
			Console.WriteLine("How many elements will the vector have? - Use numbers:");
			string size = Console.ReadLine();

			if (!int.TryParse(size, out int result))
            {
                AppLogger.Log(LogCategoryLevel.Warning, "Input is not a number!");
                return new int[0];
            }

            if (result <= 0)
            {
                AppLogger.Log(LogCategoryLevel.Warning, "Input number is negative or zero! Array size too small!");

                return new int[0];
            }

            int[] vector = new int[result]; // Size.

			for (int i = 0; i < result; i++)
            {
                Console.Write($"Element[{i}] = ");
                string element = Console.ReadLine();

                if (!int.TryParse(element, out int eValue))  AppLogger.Log(LogCategoryLevel.Warning, "Input is not a number!");

                if (result < 0) // Size.
                {
                    AppLogger.Log(LogCategoryLevel.Warning, "Input number is negative or zero!");
                    result = 0;
                }

                vector[i] = eValue;
            }

            return vector;
		}

        /// <summary>
        /// Takes an array of numbers representing a vector then prints it to the console.
        /// </summary>
        /// <param name="vector">A number array representing a vector.</param>
        /// <exceptions name="vector" type="int array">
        ///     Null.
        ///     Enmpty.
        /// </exception>
        public static void PrintVector(int[] vector)
        {
            if (vector is null)
            {
                AppLogger.Log(LogCategoryLevel.Warning, "Array is null!");
                return;
            }

            if (vector.Length == 0)
            {
                AppLogger.Log(LogCategoryLevel.Warning, "Array is empty!");
                return;
            }

            string elements = string.Join(", ", vector);

            Console.WriteLine($"Array = [{elements}]");
        }
	}
}
