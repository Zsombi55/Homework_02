/*
 * User: Zsombor
 * Date: 2021-02-01
 * Time: 15:46
 * 4th.
 */

using System;
using System.Collections.Generic;
using QuizSystem.Validator;

namespace QuizSystem.Client
{
	class Program
	{
		static void Main(string[] args)
		{
            QuizProcessor quiz = new QuizProcessor();
			List<Question> questions = new List<Question>()
			{
				new Question
                {
                    IdNumber = 1,
                    QuestionType = "nr",
                    Description = "Which of these are vegetables?",
                    PossibleAnswers = new Answer
                    {
                        Id = 1,
                        PossibleAnswer = new string[] {"Banana", "Apple", "Tomato"}, // "Tomato" botanically is a fruit, a berry plant.
                        CorrectAnswers = "0"
                        // Non-science Users use "0" as "none", NOT as "first"; most Users begin lists with "1".
                    }
                },

                new Question
                {
                    IdNumber = 2,
                    QuestionType = "nr",
                    Description = "Which of these have no curves?",
                    PossibleAnswers = new Answer
                    {
                        Id = 2,
                        PossibleAnswer = new string[] {"Cylinder, Ball", "Sphere, Semi-Circle", "Pyramid, Cube"},
                        CorrectAnswers = "3" // Only this pair is entirely blocky.
                    }
                },

                new Question
                {
                    IdNumber = 3,
                    QuestionType = "nr",
                    Description = "Select all fruits.",
                    PossibleAnswers = new Answer
                    {
                        PossibleAnswer = new string[] {"Carrot", "Cherry", "Tomato"},
                        CorrectAnswers = "2 3" // "Tomato" botanically is a fruit, a berry plant.
                    }
                }
			};

            ConsoleHelper.PrintIntro();
            //----------------------------------

            
		    QuestionHelper questionHelper = new QuestionHelper(questions);
		    quiz.Start(questionHelper);

		    bool thereAreMoreQuestions = true;
		    bool userHasDecidedToExit = false;
		    do
		    {
			    Question next = QuestionHelper.Next();
			    if (next == null)
			    {
				    thereAreMoreQuestions = false;
			    }
			    else
			    {
				    bool isValidInput = false;
				    do
				    {
					    //-------
				    } while(!isValidInput)
			    }
		    } while (thereAreMoreQuestions && !userHasDecidedToExit);

		    int total = quiz.GetTotalScore();



            

            // This would only be useful for User answer input existence (is null /empty /whitespace) validation.
            //QuizProcessor processor = new QuizProcessor(rules: new Validator.Rules[] { new R_InputIsValid() });


            // Due to OOP it might be better to put this in another class or at least a container function ?
             // One question at a time.
            for(int i = 0; i < questions.Length; i++)
            {
                if(questions[i] is null) throw new ArgumentNullException(nameof(questions), "There are no questions.");

                if(questions[i].IdNumber < 1 || string.IsNullOrEmpty(questions[i].Description) || 
                    questions[i].PossibleAnswers is null || questions[i].CorrectAnswers is null)
                    throw new ArgumentException(nameof(questions), "Question elements are missing or incorrectly filled.");

                if(questions[i].QuestionType == "choice")
                    ConsoleHelper.PrintChoiceQuestion(questions[i]);
                else
                    ConsoleHelper.PrintTypeQuestion(questions[i]);

                //processor.Process(questions[i]);

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