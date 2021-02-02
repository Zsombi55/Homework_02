using System;
using QuizSystem.Transformator;
using QuizSystem.Validator;

/*
 * Get and Print indormation from & to the Console.
 */

namespace QuizSystem.Client
{
	public static class ConsoleHelper
	{
		public static void PrintChoiceQuestion(Question question)
		{
			if(question is null) throw new ArgumentNullException("The question object doesn't exist.", nameof(question));

			Console.WriteLine($"-------------------------\n" +
							  $"{question.Number}. {question.Ask}\n" +
							  $"\t1.) {question.Choices[0]}\n" +
							  $"\t2.) {question.Choices[1]}\n" +
							  $"\t3.) {question.Choices[2]}\n");
		}

		public static void PrintTypeQuestion(Question question)
		{
			if(question is null) throw new ArgumentNullException("The question object doesn't exist.", nameof(question));

			Console.WriteLine($"-------------------------\n" +
							  $"{question.Number}. {question.Ask}\n\n");
		}

		public static string GetAnswer()
		{
			string input = Console.ReadLine();
			return input;
		}

		public static void PrintResult()
		{
			throw new NotImplementedException();
		}

		public static void PrintFinalResult()
		{
			throw new NotImplementedException();
		}
	}
}
