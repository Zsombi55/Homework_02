
namespace QuizSystem.Client
{
	public class Answer
	{
		// Empty constructor.
		public Answer() {}
		
		// Private setters so members cannot be changed after instantiation.
		public int Id { get; private set; }

		public string[] PossibleAnswer { get; private set; }

		//public int[] CorrectAnswers { get; private set; }

		public string CorrectTextAnswer { get; private set; }
		// Just this should be enough,
		// Console Input is "string" type anyway,
		// there is no need to convert to another,
		// as long as "string" input fits the required "string" answer, everything should be all right.
	}
}
