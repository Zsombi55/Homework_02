using System;
using System.Text;

/*
 * Get and Print indormation from & to the Console.
 */

namespace QuizSystem.Client
{
	public class ConsoleHelper
	{
		public void PrintChoiceQuestion(Question question)
		{
			Console.WriteLine($"-------------------------\n" +
							  $"{question.Number}. {question.Ask}\n" +
							  $"\t1.) {question.Choices[0]}\n" +
							  $"\t2.) {question.Choices[1]}\n" +
							  $"\t3.) {question.Choices[2]}\n");
		}

		public void PrintTypeQuestion(Question question)
		{
			Console.WriteLine($"-------------------------\n" +
							  $"{question.Number}. {question.Ask}\n\n");
		}

		public string GetAnswer()
		{
			return Console.ReadLine();
		}
	}
}
