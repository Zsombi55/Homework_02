
namespace TextTransformations.Former
{
	public class FormUpperCase : FormBase
	{
		public FormUpperCase() {}

		public override string FormingProcess(string text)
		{
			//Console.WriteLine($"To uppper case:\n\t{text.ToUpper()}\n");
			return text.ToUpper();
		}
	}
}
