using System;
using System.Collections.Generic;

// Question selection.
namespace QuizSystem.Client
{
	public class QuizHelper
	{
		/// <summary>
		/// Asks the user to provide answers to all questions one after another, line by line.
		/// </summary>
		/// <param name="questions">Question list, each element object contains the array of possible answers to choose from.</param>
		/// <returns>String array: the collected answers.</returns>
		internal static string[] GetUserChoice(List<Question> questions)
		{
			string[] userChoices = new string[questions.Count]; // One answer string per question.
			
			Console.WriteLine("Enter your answer choices in a nwe line for each indicated question.\n" +
				"To enter multiple coices for the same question type them in the same line separated by a blank /whitespace character.\n\n" +
				"WARNING: In multiple choice cases enter answer numbers in the same order they are listed !\n"); // TODO: Validate User Answer per choice instead !
			//
			for(int i = 0; i < questions.Count; i++)
			{
				if(questions[i] is null)  throw new ArgumentNullException(nameof(questions), "A \"question\" does not exist !");

				Console.Write($"Q { questions[i].Id }.: ");

				userChoices[i] = Console.ReadLine().Trim();
			}

			return userChoices;
		}

		/// <summary>
		/// Validates the received answers against the expected answers.
		/// If a wrong answer is found the user is notified of it as well as the correct answer.
		/// Also calculates and prints the final score.
		/// </summary>
		/// <param name="questions">Question list, each element object contains the string of correct answer(s).</param>
		/// <param name="userInput">String array: collection of user's answers to every question.</param>
		/// <returns>Int: total accumulated points. Zero means no wrong answers.</returns>
		internal static int ValidateUserAnswers(List<Question> questions, string[] userInput)
		{
			int points = 0;

			Console.WriteLine("\n------------------------------\n");
			for(int j = 0; j < userInput.Length; j++)
			{
				if( ! userInput[j].Equals(questions[j].CorrectTextAnswer)) // Not much validation.. the 2 strings are either equal or not.
				{
					// TODO: check each choice in the string agains the correct answer string to validate per choice, not just per question.
					points++;

					Console.WriteLine($"\tInvalid answer: { j + 1 }.\t{userInput[j]}\tThe correct is: {questions[j].CorrectTextAnswer} .");
				}
			}

			return points;
		}
	}

	/* first ver.
	 * 
		private IList<Question> theQuestions; // A temporary question collection for app runtime duration.

		public QuestionHelper(IList<Question> questions)
		{
			if (questions == null)
			{
				throw new ArgumentNullException(nameof(questions), "ERROR.. There are no \"questions\".");
			}
			
			this.theQuestions = questions;
		}

		/// <summary>
		/// Returns the next question or null if there are no more questions.
		/// Always select the first in the list, save it for use then remove it from the list.
		///		so next call the second will be seen as the first.
		/// </summary>
		/// <returns>A question if there is any.</returns>
		public Question Next()
		{
			if (this.theQuestions.Count == 0)
			{
				return null; // No more new questions ot ask.
			}
			Question nextQuestion = this.theQuestions[0]; // Select the next one to return.
			this.theQuestions.RemoveAt(0); // Take it out of the list, we don't return it again.

			return nextQuestion;
		}

		public IEnumerable<Question> Questions { get; private set; } // May need an indexer ?
	}
	*/
}
