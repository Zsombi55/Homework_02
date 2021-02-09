using System.Collections.Generic;

namespace QuizSystem.Client
{
	public class Question
	{
		// Empty constructor.
		public Question() {}

		// Private setters so members cannot be changed after instantiation.

		public int IdNumber { get; private set; }

		public string QuestionType { get; private set; } // Used only if there are both number-picking ("nr") & text-typing question-answers ("text").

		public string Description { get; private set; }

		public List<Answer> PossibleAnswers { get; private set; } // If the programmer wants to add 50 possibilities let them, so long there is min. 1, all is well.


		public int ChosenAnswerId { get; set; } // Something to connect possible answers with. Is is too database like ?  May be unnecessary ?
	}
}
