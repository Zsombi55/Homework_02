/*
 * User: Zsombor
 * Date: 2021-02-01
 * Time: 15:46
 * 4th.
 */

using System;
using QuizSystem.Validator;

namespace QuizSystem.Client
{
	class Program
	{
		static void Main(string[] args)
		{
			Question[] questions = new Question[]
			{
				new Question
                {
                    QuestionType = "choice",
                    IdNumber = 1,
                    Description = "Which of these are vegetables?",
                    new Answer
                    {
                        Answers = new string[] {"Banana", "Apple", "Tomato"}, // "Tomato" botanically is a fruit, a berry plant.
                        CorrectAnswers = new int[] {0}
                        // This for non-science Users means "none" NOT "first"; most Users begin lists with "1", they are not science people.
                    }
                },

                new Question
                {
                    QuestionType = "choice",
                    IdNumber = 2,
                    Description = "Which of these have no curves?",
                    Choices = new string[] {"Cylinder, Ball", "Sphere, Semi-Circle", "Pyramid, Cube"},
                    Answers = new int[] {3} // Only this pair are entirely blocky.
                },

                new Question
                {
                    QuestionType = "choice",
                    IdNumber = 3,
                    Description = "Select all fruits.",
                    Choices = new string[] {"Carrot", "Cherry", "Tomato"},
                    Answers = new int[] {2, 3} // "Tomato" botanically is a fruit, a berry plant.
                }

			};

            QuizProcessor processor = new QuizProcessor(rules:
                new Validator.Rules[]
                {
                    new R_InputIsValid()
                });

            // Due to OOP it might be better to put this in another class or at least a container function ?

             // One question at a time.
            for(int i = 0; i < questions.Length; i++)
            {
                if(questions[i] is null) throw new ArgumentNullException("There are no questions.", nameof(questions));

                if(questions[i].IdNumber < 1 || string.IsNullOrEmpty(questions[i].Description) || questions[i].Answers is null || questions[i].CorrectAnswers is null)
                    throw new ArgumentException("Question elements are missing or incorrectly filled.", nameof(questions));

                if(questions[i].QuestionType == "choice")
                    ConsoleHelper.PrintChoiceQuestion(questions[i]);
                else
                    ConsoleHelper.PrintTypeQuestion(questions[i]);

                processor.Process(questions[i]);

                Validator.Validate( ConsoleHelper.GetAnswer() ); // Get chosen or typed answer, parse & compare to "Corract" / "TypeInCorract", then return some result.

                ConsoleHelper.PrintResult(); // If result is not fully correct, notify User then show correct answers ??
            }
            
            ConsoleHelper.PrintFinalResult(); // Final score, final result ??


			Console.WriteLine("\nEnd.\n");
		}
	}
}

/* Typed answer questions:
 * 
                new Question
                {
                    QuestionType = "typed",
                    Number = 3,
                    Ask = "What is the ratio of a circle's circumference to its diameter called, and is approximately equal to \"3.14159265359\"?",
                    TypeInChoice = string.Empty, // The User has to type in the answer.
                    TypeInCorrect = "pi" // Discard casing, it matters not.
                },

                new Question
                {
                    QuestionType = "typed",
                    Number = 4,
                    Ask = "What is the result of the equation \"2 x 2\"? First write it with numbers then with words, separated by a blank space.",
                    TypeInChoice = string.Empty, // The User has to type in the answer.
                    TypeInCorrect = "4 four" // Discard casing, it matters not.
                }
*/