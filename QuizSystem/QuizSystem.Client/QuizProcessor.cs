using System;
using System.Collections.Generic;
using QuizSystem.Validator;

// Handle question and answer pairing.
namespace QuizSystem.Client
{
	public class QuizProcessor
	{
		private QuestionHelper questionHelper;
		
		public void Start(QuestionHelper questionHelper)
		{
			if (questionHelper == null)
			{
				throw new  ArgumentNullException(nameof(questionHelper), "ERROR.. Missing \"QuestionHelper\", cannot manage question selection.");
			}

			this.questionHelper = questionHelper;
		}

		public int GetTotalScore()
		{
			throw new NotImplementedException();

			//ScoreCalculator.Calculate(...); // Basically 0 == max score, anything above == at least one wrong answer, cannot go negative.
		}
	}

/*	class QuizProcessor
	{
		/// <summary>
		/// Constuctor. Provides outside access.
		/// </summary>
		/// <param name="rules">Object array for validation rules.</param>
		public QuizProcessor(Rules[] rules)
		{
			ValidatorEngine = new Validator.ValidatorEngine(rules);
		}

		public Validator.ValidatorEngine ValidatorEngine { get; }

		public void Process(Question[] questions)
		{
			if(questions is null)
			{
				Console.WriteLine("Question array is NULL ! Can't process.");
				return;
			}

			if(questions.Length == 0)
			{
				Console.WriteLine("Question array is EMPTY ! Can't process.");
				return;
			}

			foreach(Question question in questions)
			{
				bool isValid = ValidatorEngine.Validate(question);

				if(isValid)
				{
					if(ConsoleHelper.GetAnswer() == string.Join(" ", question.PossibleAnswers.ToString().ToLower()))
					{
						Console.WriteLine("\nVALID");
					}
					else
					{
						Console.WriteLine($"\nINVALID. The correct answer is: " +
							$"{string.Join(" ", question.PossibleAnswers.ToString().ToLower())}\n");
					}
				}
				else
					throw new ArgumentException("Client/QuizProcessor/Process: bool isValid = false !");
				
				return;
			}
		}
	}
	*/
}

/* Unused for number-picking questions.
 * 
					if(question.QuestionType == "choice")
					{ ... }
					else // Question Type = "typed"
					{
						if(ConsoleHelper.GetAnswer() == string.Join(" ", question.TypeInChoice.ToString().ToLower()))
						{
							Console.WriteLine("\nVALID");
						}
						else
						{
							Console.WriteLine($"\nINVALID. The correct answer is: " +
								$"{string.Join(" ", question.TypeInCorrect.ToString().ToLower())}\n");
						}
					}
*/