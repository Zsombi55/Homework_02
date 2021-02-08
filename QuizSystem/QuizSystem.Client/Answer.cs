
namespace QuizSystem.Client
{
	public class Answer
	{
		// Empty constructor.
		public Answer() {}

		public int Id { get; internal set; }

		public string[] Answers { get; internal set; }

		public int[] CorrectAnswers { get; internal set; }

		public string CorrectTextAnswer { get; internal set; }
	}
}
