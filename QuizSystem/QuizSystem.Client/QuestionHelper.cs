using System;
using System.Collections.Generic;

// Question selection.
namespace QuizSystem.Client
{
	public class QuestionHelper
	{
		private IList<Question> theQuestions; // A temporary question collection for app runtime duration.

		public QuestionHelper(IList<Question> questions)
		{
			if (questions == null)
			{
				throw new ArgumentNullException(nameof(questions), "ERROR.. There are no \"questions\".");
			}
			
			this.theQuestions = questions;
		}

		/// <summary>
		/// Returns the next question or null if there are no more questions.
		/// Always select the first in the list, save it for use then remove it from the list.
		///		so next call the second will be seen as the first.
		/// </summary>
		/// <returns>A question if there is any.</returns>
		public Question Next()
		{
			if (this.theQuestions.Count == 0)
			{
				return null; // No more new questions ot ask.
			}
			Question nextQuestion = this.theQuestions[0]; // Select the next one to return.
			this.theQuestions.RemoveAt(0); // Take it out of the list, we don't return it again.

			return nextQuestion;
		}

		public IEnumerable<Question> Questions { get; private set; } // May need an indexer ?
	}
}
