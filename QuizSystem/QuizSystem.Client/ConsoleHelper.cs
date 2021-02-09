using System;
using QuizSystem.Validator;

// Get and Print information from & to the Console.
namespace QuizSystem.Client
{
	public static class ConsoleHelper
	{	
		internal static void PrintIntro()
		{
			Console.WriteLine("Choose the answers by their numbers, if none is found correct use \"0\".\n" +
				"For multiple answers type each in the same line separated by blank whitespaces.\n\n" +
				"NOTE: perfect score equals \"0\", the higher it is the more wrong choices were made!\n" +
				"-------------------------");
		}

		public static void PrintChoiceQuestion(Question question, Answer answers)
		{
			if(question is null) throw new ArgumentNullException(nameof(question), "The question object doesn't exist.");

			Console.WriteLine("-------------------------\n" +
				$"{question.IdNumber}. {question.Description}\n");
			//
			for(int i = 0; i < answers.PossibleAnswer.Length; i++)
			{
				Console.WriteLine($"\t{i+1}.) {answers.PossibleAnswer[i]}\n");
			}
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

/* Unused for number-picking questions.
 * 
		public static void PrintTypeQuestion(Question question)
		{
			if(question is null) throw new ArgumentNullException("The question object doesn't exist.", nameof(question));

			Console.WriteLine($"-------------------------\n" +
							  $"{question.IdNumber}. {question.Description}\n\n");
		}
*/