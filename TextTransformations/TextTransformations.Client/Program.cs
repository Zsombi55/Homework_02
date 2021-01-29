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
			Console.WriteLine("Enter text, in one paragraph format, maximum 254 characters:");

			string baseText = ConsoleHelper.ReadText();  //ConsoleHelper.PrintText(text);
			
            // Manipulation Batch 1
			string result1 = ConsoleHelper.ApplyTransformationRules(baseText,
                new TransformationRule[] 
                {
                    new InsertStringTransformationRule(0, "Petre "),
                    new DeleteTextTransformationRule("test"),
                    new ReplaceTextTransformationRule("a", "test123")
                });

            // Manipulation Batch 2
            string result2 = ConsoleHelper.ApplyTransformationRules(baseText,
                new TransformationRule[]
                {
                    new InsertStringTransformationRule(0, "Rodica "),
                    new ReplaceTextTransformationRule("test", "test123")
                });


            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Modified text 1 is:");
            Console.WriteLine(result1);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Modified text 2 is:");
            Console.WriteLine(result2);


			Console.WriteLine("\nEnd.\n");
		}
	}
}
