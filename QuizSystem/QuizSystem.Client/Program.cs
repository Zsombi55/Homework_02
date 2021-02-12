/*
 * User: Zsombor
 * Date: 2021-02-01
 * Time: 15:46
 * 4th.
 */

using System;
using System.Collections.Generic;

namespace QuizSystem.Client
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Question> questions = new List<Question>()
			{
				new Question
                {
                    IdNumber = 1,
                    QuestionType = "nr",
                    Description = "Which of these are vegetables?",
                    PossibleAnswers = new string[] {"Banana", "Apple", "Tomato"}, // "Tomato" botanically is a fruit, a berry plant.
                    CorrectTextAnswer = "0"
                        // Non-science Users use "0" as "none", NOT as "first"; most Users begin lists with "1".
                },

                new Question
                {
                    IdNumber = 2,
                    QuestionType = "nr",
                    Description = "Which of these have no curves?",
                    PossibleAnswers = new string[] {"Cylinder, Ball", "Sphere, Semi-Circle", "Pyramid, Cube"},
                    CorrectTextAnswer = "3" // Only this pair is entirely blocky.
                },

                new Question
                {
                    IdNumber = 3,
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
		}
	}
}

/* Typed answer questions:
 * 
                new Question
                {
                    QuestionType = "text",
                    Number = 4,
                    Description = "What is the ratio of a circle's circumference to its diameter called, and is approximately equal to \"3.14159265359\"?",
                    TypeInChoice = string.Empty, // The User has to type in the answer.
                    TypeInCorrect = "pi" // Discard casing, it matters not.
                },

                new Question
                {
                    QuestionType = "text",
                    Number = 5,
                    Description = "What is the result of the equation \"2 x 2\"? First write it with numbers then with words, separated by a blank space.",
                    TypeInChoice = string.Empty, // The User has to type in the answer.
                    TypeInCorrect = "4 four" // Discard casing, it matters not.
                }
*/