
namespace QuizSystem.Client
{
	public class Question
	{
		// Empty constructor.
		public Question() {}

		public int Number { get; set; }

		public string Ask { get; set; }

		public string[] Choices { get; set; }

		public int[] Correct { get; set; }

		public string TypeInChoice { get; set; }

		public string TypeInCorrect { get; set; }
	}
}
