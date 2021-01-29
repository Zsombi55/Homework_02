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

			Console.WriteLine("Enter text, in one paragraph format, maximum 254 characters:");
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

		public static int ReadIndex()
		{
			string i;
			Console.WriteLine("Enter text character position number (index), counting from 0 :");

			try
			{
				i = Console.ReadLine();
				int.TryParse(i, out int result);
				return result;	
			}
			catch(ArgumentException e)
			{
				Console.WriteLine($"\tThe given value is not an integer number, OR is larger than the int32 limit.\n{e}");
				throw;
			}
		}


		// -----COULD NOT MAKE IT WORK FROM HERE INSTEAD OF "Program.cs".-----
		/// <summary>
		/// Takes in a text and selected manipulation data, modifies the text accordingly then returns the result.
		/// </summary>
		/// <param name="input">Text to manipulate.</param>
		/// <param name="transformationRules">Manipulation data (conditions, rules, etc. ).</param>
		/// <returns>Altered text.</returns>
		//public static string ApplyRules(string text, FormBase[] rules)
		//{
		//	if (rules is null) return text;

		//	foreach (FormBase rule in rules) text = rule.FormingProcess(text);

		//	return text;
		//}
	}
}
