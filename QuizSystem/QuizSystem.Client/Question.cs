
namespace QuizSystem.Client
{
	public class Question
	{
		// Empty constructor.
		public Question() {}

		public string QuestionType { get; internal set; }

		public int IdNumber { get; internal set; }

		public string Description { get; internal set; }
	}
}
