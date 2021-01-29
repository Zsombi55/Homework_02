using System;

namespace TextTransformations.Former
{
	public class FormInsertSection : FormBase
	{
		/// <summary>
		/// Constructor. Declares old section & text index variables. Allows the User to Set them.
		/// </summary>
		/// <param name="part_a">Old text section to mark "what" to insert.</param>
		/// <param name="index">Text character index to mark where to put the new part.</param>
		public FormInsertSection(int index, string part_a)
        {
			TextIndex = index;
            NewPart = part_a;
        }

		public int TextIndex { get; }

        public string NewPart { get; }

		public override string FormingProcess(string text)
		{
			try
			{
				if(TextIndex >= 0 && TextIndex <= text.Length)
					return text.Insert(TextIndex, NewPart);
			}
			catch(IndexOutOfRangeException e)
			{
				Console.WriteLine($"\tPosition value is negative OR larger than text length !\n{e}");
				throw;
			}
			return text;
		}
	}
}
