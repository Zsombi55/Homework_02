using System;

namespace QuizSystem.Client
{
	/// <summary>
	/// Base class. All different types have & can do these.
	/// Possible types are: where only 1 choice, or multiple choices have to be made, or even where there are no offered choices & the answer has to be typed in.
	/// </summary>
	public abstract class Question
	{
		/// <summary>
		/// Constructor allowing the creation of various question types.
		/// Each type will have to have an identifier and a text containing the question or instruction itself.
		/// </summary>
		/// <param name="id">Integer: Numeric identifier.</param>
		/// <param name="description">String: Question text.</param>
		public Question(int id, string description)
        {
            Id = id;
            Description = description;
        }

		/// <summary>
		/// Gets the question identifier.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Gets the question text.
		/// </summary>
		public string Description { get; }

		/// <summary>
		/// Gets the points taken for this question.
		/// </summary>
		public int Points { get; protected set; }

		//public string[] PossibleAnswers { get; internal set; }

		//public string CorrectTextAnswer { get; internal set; }

		/// <summary>
		/// Makes the question print its text and its matching list of possible answers (options).
		/// </summary>
		public abstract void Print();

		/// <summary>
		/// Validates the answer and sets the current question's points.
		/// </summary>
		/// <param name="answer">String: User input.</param>
		public abstract void ValidateAnswer(string answer);
	}
}
