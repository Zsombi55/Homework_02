
namespace TextTransformations.Former
{
	public class FormLoweCase : FormBase
	{
		public FormLoweCase() {}

		public override string FormingProcess(string text)
		{
			//Console.WriteLine($"To lower case:\n\t{text.ToLower()}\n");
			return text.ToLower();
		}
	}
}
