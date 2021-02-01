/*
 * User: Zsombor
 * Date: 2021-02-01
 * Time: 15:46
 * 4th.
 */

using System;
using QuizSystem.Library;

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
                    Number = 1,
                    Ask = "Select all vegetables.",
                    Choices = new string[] {"Banana", "Apple", "Tomato"},
                    Correct = new int[] {0} // "Tomato" botanically is a fruit, a berry plant.
                },

                new Question
                {
                    Number = 2,
                    Ask = "Select all fruits.",
                    Choices = new string[] {"Carrot", "Cherry", "Tomato"},
                    Correct = new int[] {2, 3} // "Tomato" botanically is a fruit, a berry plant.
                },

                new Question
                {
                    Number = 3,
                    Ask = "What is the ratio of a circle's circumference to its diameter called, and is approximately equal to \"3.14159265359\"?",
                    TypeInChoice = string.Empty, // The User has to type in the answer.
                    TypeInCorrect = "pi" // Discard casing, it matters not.
                },

                new Question
                {
                    Number = 4,
                    Ask = "What is the result of the equation \"2 x 2\"? First write it with numbers then with words, separated by a blank space.",
                    TypeInChoice = string.Empty, // The User has to type in the answer.
                    TypeInCorrect = "4 four" // Discard casing, it matters not.
                }
			};


            for(int i = 0; i < questions.Length; i++)
            {
                PrintQuestion(questions[i]); // One question at a time.

                ValidateAnswer( ConsoleHelper.GetAnswer() ); // Get chosen or typed answer, parse & compare to "Corract" / "TypeInCorract", then return some result.

                PrintResult(); // If result is not fully correct, notify User then show correct answers ??
            }
            
            PrintFinalResult(); // Final score, final result ??


			Console.WriteLine("\nEnd.\n");
		}
	}
}
