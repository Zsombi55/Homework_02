/*
 * User: Zsombor
 * Date: 2021-02-01
 * Time: 15:46
 * 4th.
 * -----------------
 * Revised Date: 2021-02-15 , 16
 * Revised Time: 22:00
 */

using System;
using System.Collections.Generic;

namespace QuizSystem.Client
{
	class Program
	{
		/// <summary>
		/// 1. Declare & initialize the question database instance to be used.
		/// 2. Declare & create a quiz from the database instance.
		/// 3. Begin the question-answer cycle, and the score counter. 
		/// </summary>
		/// <param name="args">String array: General "Main ()" parameter.</param>
		static void Main(string[] args)
		{
			QuestionDB database = new QuestionDB();
            Quiz quiz = database.CreateQuiz();
            quiz.TakeQuiz();


			Console.WriteLine("\nEnd.\n");
		}
	}
}

// TODO: change per question validation into per choice ?

// TODO: port the more detailed quiz user instructions section from version 2's Console Helper, to explain stuff.. like .. partial good answers still value nothing. 

// TODO: centralize generic instructions applicable to the entire quiz duration, so they only show up before the irst question, at the very beginning.

// TODO: expand question list; extract 2 different sets to list; .. the system selects which of the 2 by  " Random() ".

/* First working version, V_2.
 * 
			List<Question> questions = new List<Question>()
			{
				new Question
				{
					Id = 1,
					QuestionType = "nr",
					Description = "Which of these are vegetables?",
					PossibleAnswers = new string[] {"Banana", "Apple", "Tomato"}, // "Tomato" botanically is a fruit, a berry plant.
                    CorrectTextAnswer = "0"
                        // Non-science Users use "0" as "none", NOT as "first"; most Users begin lists with "1".
                },

				new Question
				{
					Id = 2,
					QuestionType = "nr",
					Description = "Which of these have no curves?",
					PossibleAnswers = new string[] {"Cylinder, Ball", "Sphere, Semi-Circle", "Pyramid, Cube"},
					CorrectTextAnswer = "3" // Only this pair is entirely blocky.
                },

				new Question
				{
					Id = 3,
					QuestionType = "nr",
					Description = "Select all fruits.",
					PossibleAnswers = new string[] {"Carrot", "Cherry", "Tomato"},
					CorrectTextAnswer = "2 3" // "Tomato" botanically is a fruit, a berry plant.
                }
			};


			ConsoleHelper.PrintInstructions();
			//----------------------------------
			ConsoleHelper.PrintChoiceQuestion(questions);
			//----------------------------------
			string[] userAnswers = QuizHelper.GetUserChoice(questions);
			//----------------------------------
			int score = QuizHelper.ValidateUserAnswers(questions, userAnswers);
			//----------------------------------
			ConsoleHelper.PrintTotalScore(points: score, questionCount: questions.Count);


			Console.WriteLine("\nEnd.\n");
*/
