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
					Console.WriteLine($"VALID: {question.FirstName} {question.LastName}");
				}
				else
				{
					Console.WriteLine($"INVALID: {question.FirstName} {question.LastName}");
				}
			}
		}
	}
}
