
namespace QuizSystem.Client
{
	public class Question
	{
		// Empty constructor.
		public Question() {}

		public string QuestionType { get; internal set; }

		public int Number { get; internal set; }

		public string Ask { get; internal set; }

		public string[] Choices { get; internal set; }

		public int[] Correct { get; internal set; }

		public string TypeInChoice { get; set; }

		public string TypeInCorrect { get; internal set; }
	}
}
