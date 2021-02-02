/*
 * User: Zsombor
 * Date: 2021-02-01
 * Time: 15:46
 * 4th.
 */

using System;

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
                    Number = 1,
                    Ask = "Select all vegetables.",
                    Choices = new string[] {"Banana", "Apple", "Tomato"},
                    Correct = new int[] {0} // "Tomato" botanically is a fruit, a berry plant.
                },

                new Question
                {
                    QuestionType = "choice",
                    Number = 2,
                    Ask = "Select all fruits.",
                    Choices = new string[] {"Carrot", "Cherry", "Tomato"},
                    Correct = new int[] {2, 3} // "Tomato" botanically is a fruit, a berry plant.
                },

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
			};


            // Due to OOP it might be better to put this in another class or at least a container function ?

             // One question at a time.
            for(int i = 0; i < questions.Length; i++)
            {
                if(questions[i] is null) throw new ArgumentNullException("There are no questions.", nameof(questions));

                if(questions[i].Number < 1 || string.IsNullOrEmpty(questions[i].Ask) || questions[i].Choices is null || questions[i].Correct is null)
                    throw new ArgumentException("Question elements are missing or incorrectly filled.", nameof(questions));

                if(questions[i].QuestionType == "choice")
                    ConsoleHelper.PrintChoiceQuestion(questions[i]);
                else
                    ConsoleHelper.PrintTypeQuestion(questions[i]);

                QuizSystem.Validators.ValidateAnswer( ConsoleHelper.GetAnswer() ); // Get chosen or typed answer, parse & compare to "Corract" / "TypeInCorract", then return some result.

                ConsoleHelper.PrintResult(); // If result is not fully correct, notify User then show correct answers ??
            }
            
            ConsoleHelper.PrintFinalResult(); // Final score, final result ??


			Console.WriteLine("\nEnd.\n");
		}
	}
}
