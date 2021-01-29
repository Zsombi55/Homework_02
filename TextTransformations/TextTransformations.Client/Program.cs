/*
 * User: Zsombor
 * Date: 2021-01-26
 * Time: 10:40
 * 2nd.
 * --------------------------
 * Revision Date: 2021-01-29
 * Revision Time: 10:48
 */

using System;
using TextTransformations.Former;

namespace TextTransformations.Client
{// Goal: Get text from User, perform string manipulations (replace a section with something else, remove a section, insert something to position, turn all cases upper & lower, make 2 linked transformations each using at least 2 variations) + Use OOP.
	class Program
	{
		static void Main(string[] args)
		{
			string baseText = ConsoleHelper.ReadText();  //ConsoleHelper.PrintText(text);
			
            // Manipulation Batch 1
			//string result1 = ConsoleHelper.ApplyRules(baseText,
			string result1 = ApplyRules(baseText, rules:
                new FormBase[] 
                {
                    //new FormInsertSection(index: ConsoleHelper.ReadIndex(), part_a: ConsoleHelper.ReadText()),
                    //new FormRemoveSection(part_a: ConsoleHelper.ReadText()),
					new FormInsertSection(index: 0, part_a: "O x O x O x O "),
                    new FormRemoveSection(part_a: "x"),
                    new FormLoweCase()
                });

            // Manipulation Batch 2
			//string result2 = ConsoleHelper.ApplyRules(baseText,
            string result2 = ApplyRules(baseText, rules:
                new FormBase[]
                {
                    new FormInsertSection(index: baseText.Length - 1, part_a: " = potato."),
                    new FormReplaceSection(part_a: "a", part_b: "G")
                });


            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Modified text 1 is:\n");
            Console.WriteLine(result1);

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Modified text 2 is:\n");
            Console.WriteLine(result2);


			Console.WriteLine("\nEnd.\n");
		}

		/// <summary>
		/// Takes in a text and selected manipulation data, modifies the text accordingly then returns the result.
		/// </summary>
		/// <param name="input">Text to manipulate.</param>
		/// <param name="transformationRules">Manipulation data (conditions, rules, etc. ).</param>
		/// <returns>Altered text.</returns>
		public static string ApplyRules(string text, FormBase[] rules)
		{
			if (rules is null) return text;

			foreach (FormBase rule in rules) text = rule.FormingProcess(text);

			return text;
		}
	}
}
