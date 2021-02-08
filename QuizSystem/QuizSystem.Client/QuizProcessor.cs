using System;
using QuizSystem.Validator;

namespace QuizSystem.Client
{
	class QuizProcessor
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
					if(question.QuestionType == "choice")
						if(ConsoleHelper.GetAnswer() == string.Join(" ", question.Choices.ToString().ToLower()))
							Console.WriteLine("\nVALID");
						else
							Console.WriteLine($"\nINVALID. The correct answer is: " +
								$"{string.Join(" ", question.Correct.ToString().ToLower())}\n");
					else // Question Type = "typed"
						if(ConsoleHelper.GetAnswer() == string.Join(" ", question.TypeInChoice.ToString().ToLower()))
							Console.WriteLine("\nVALID");
						else
							Console.WriteLine($"\nINVALID. The correct answer is: " +
								$"{string.Join(" ", question.TypeInCorrect.ToString().ToLower())}\n");
				}
				else
					throw new ArgumentException("Client/QuizProcessor/Process: bool isValid = false !");
				
				return;
			}
		}
	}
}
