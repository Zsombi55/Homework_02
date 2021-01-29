using System;

namespace TextTransformations.Former
{
	public class FormRemoveSection : FormBase
	{
		/// <summary>
		/// Constructor. Declares a section variables. Allows the User to Set it.
		/// </summary>
		/// <param name="part_a">Old text section to mark "what" to remove.</param>>
		public FormRemoveSection(string part_a)
        {
            OldPart = part_a;
        }

        public string OldPart { get; }

		public override string FormingProcess(string text)
		{
			if(!text.Contains(OldPart))
			{
				throw new ArgumentException("Requested section not found.");
			}
			
			return text.Replace(OldPart, "");
		}
	}
}
