using System;
using System.Text.RegularExpressions;

namespace TextTransformations.Former
{
	public class FormReplaceSection : FormBase
	{
		/// <summary>
		/// Constructor. Declares old and new section variables. Allows the User to Set them.
		/// </summary>
		/// <param name="part_a">Old text section to mark "what" to remove.</param>
		/// <param name="part_b">New text (section) to replace the Old with.</param>
		public FormReplaceSection(string part_a, string part_b)
        {
            OldPart = part_a;
            NewPart = part_b;
        }

        public string OldPart { get; }

        public string NewPart { get; }

        public override string FormingProcess(string text)
        {
            if(!text.Contains(OldPart))
			{
				throw new ArgumentException("Requested section not found.");
			}

			//return input.Replace(OldPart, NewPart);

			return Regex.Replace(text, @$"{OldPart}", NewPart); // IF casing matters not, add  " RegexOptions.IgnoreCase ".
		}
	}
}
