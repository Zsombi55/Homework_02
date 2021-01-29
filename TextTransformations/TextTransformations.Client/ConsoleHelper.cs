using System;
using System.IO;

namespace TextTransformations.Client
{
	public static class ConsoleHelper
	{
		/// <summary>
		/// Asks the User for a single paragraph text input.
		/// </summary>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown when entered text exceeds the maximum number of characters, 254.</exception>
		/// <exception cref="System.IO.IOException">Thrown when no text was entered OR only consists only of whitespace.</exception>
		/// <returns>User input text.</returns>
		public static string ReadText()
		{
			string s;
			Console.WriteLine("------------\n");

			try
			{
				s = Console.ReadLine();
			}
			catch(ArgumentOutOfRangeException e)
			{
				Console.WriteLine($"\tInput too long. Exceeded the maximum 254 character limit.\n{e}");
				throw;
			}

			if(string.IsNullOrWhiteSpace(s))
			{
				throw new IOException("\tNo text input found.");
			}

			Console.WriteLine("------------\n");
			return s;
		}

		/// <summary>
		/// Takes a string then prints it to the standard output of the app.
		/// </summary>
		/// <param name="text">A string.</param>
		public static void PrintText(string text)
		{
			Console.WriteLine(text);
		}

		/// <summary>
		/// Takes in a text and selected manipulation data, modifies the text accordingly then returns the result.
		/// </summary>
		/// <param name="input">Text to manipulate.</param>
		/// <param name="transformationRules">Manipulation data (conditions, rules, etc. ).</param>
		/// <returns>Altered text.</returns>
		public static string ApplyTransformationRules(
            string input,
            TransformationRule[] transformationRules)
        {
            if (transformationRules is null)
            {
                return input;
            }

            foreach (TransformationRule rule in transformationRules)
            {
                input = rule.Process(input);
            }

            return input;
        }
	}
}
