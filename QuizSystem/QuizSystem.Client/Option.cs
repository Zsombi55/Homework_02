using System;

namespace QuizSystem.Client
{
    /// <summary>
    /// "Actual & Possible Answer" oprion object.
    /// </summary>
	public class Option
	{
        /// <summary>
        /// Constructor for creating answer options and marking which are the expected correct ones.
        /// </summary>
        /// <param name="text">String: a possible answer to a question.</param>
        /// <param name="isCorrectOne">Boolean: marks the answer option as the expected &-or correct one. By default all is false/ incorrect.</param>
        /// <exception cref="System.ArgumentNullException">When the "text" element of the answer option is missing.</exception>
		public Option(string text, bool isCorrectOne = false)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
            IsCorrectOption = isCorrectOne;
        }


        /// <summary>
        /// Gets an option text content.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Gets the validity /the correctness of an option.
        /// </summary>
        public bool IsCorrectOption { get; }
	}
}
