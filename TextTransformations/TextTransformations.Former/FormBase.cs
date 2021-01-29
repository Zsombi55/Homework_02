
namespace TextTransformations.Former
{
	public abstract class FormBase
	{
		/// <summary>
		/// Takes in a text to (maybe) manipulate and returns it.
		/// Super generic, Parent Function.
		/// </summary>
		/// <param name="input">Text to manipulate.</param>
		/// <returns>Manipulation result.</returns>
		public abstract string FormingProcess(string input);
	}
}
