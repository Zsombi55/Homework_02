using System.Collections.Generic;

namespace QuizSystem.Client
{
	public class Question
	{
		// TODO: Private setters so members cannot be changed after instantiation.

		/// <summary>
		/// Gets or sets the question identifier.
		/// </summary>
		public int Id { get; internal set; }

		public string QuestionType { get; internal set; } // Used only if there are both number-picking ("nr") & text-typing question-answers ("text").

		/// <summary>
		/// Gets or sets the question text.
		/// </summary>
		public string Description { get; internal set; }


		//public List<Answer> PossibleAnswers { get; internal set; }
			// If the programmer wants to add 50 possibilities let them, so long there is min. 1, all is well.

		/// <summary>
		/// Gets the points taken for this question
		/// </summary>
		public int Points { get; protected set; }

		public string[] PossibleAnswers { get; internal set; }

		public string CorrectTextAnswer { get; internal set; }

		//public int ChosenAnswerId { get; internal set; } // Something to connect possible answers with. Is is too database like ?  May be unnecessary ?

		/// <summary>
		/// Makes the question print its text options.
		/// </summary>
		//public abstract void Print();

		/// <summary>
		/// Validates the answer and sets the current question's ...
		/// </summary>
		/// <param name="answer">user input</param>
		//public abstract void ValidateAnswer(string answer);
	}
}
