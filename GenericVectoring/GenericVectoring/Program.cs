/*
 * User: Zsombor
 * Date: 2021-02-19
 * Time: 21:50
 * 5th.
 */

using System;

/// <summary>
/// Sa se proiecteze o clasa generica, denumita ArrayHelper<T>, care sa implementeze urmatoarele servicii pentru lucrul cu vectori:
///
/// Returnarea indexului unui element dat (ca valoare):
/// 	- Daca elementul nu este continut in tablou sa se returneze -1;
/// 	- Testarea de egalitate sa se realizeze prin impunerea unei restriictii asupra tipului generic, anume ca acesta sa implementeze interfata IEquatable<T> ;
///
/// Returnarea unui sub-sir, pe baza unui index de start si a unei lungimi (cate elemente sa fie incluse in sub-sir):
/// 	- Ordonarea sirului;
/// 	- Pentru acesta puneti o restrictie asupra tipului generic T, astfel incat acesta sa implementeze interfata IComparable<T> .
/// </summary>
namespace GenericVectoring
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayHelper_T<int> ints = new ArrayHelper_T<int>(
				new[] { 4, 5, 1, 2, 8, 3 });
			ints.PrintElements();

			ArrayHelper_T<string> strings = new ArrayHelper_T<string>(
				new[] { "cc", "bb", "aa", "ee", "dd" });
			strings.PrintElements();

			//ArrayHelper_T<string> strings = new ArrayHelper_T<string>()
			//strings.Add(new [] {"cc", "bb", "aa", "ee", "dd"}) ;

			//ArrayHelper_T<int> ints = new ArrayHelper_T<int>
			//{
			//	1, 2, 3, 4, 5
			//};
			//ints.PrintElements();

			int iIndex_OK = ints.GetElementIndex(8);
			int iIndex_FAIL = ints.GetElementIndex(20);
			Console.WriteLine($"Checking for \"cc\": {iIndex_OK} ;\nChecking for \"c\": {iIndex_FAIL} .");

			int sIndex_OK = strings.GetElementIndex("cc");
			int sIndex_FAIL = strings.GetElementIndex("c");
			Console.WriteLine($"Checking for \"cc\": {sIndex_OK} ;\nChecking for \"c\": {sIndex_FAIL} .");

			Console.WriteLine("\n----------\n");
			Console.WriteLine("\nSorted Ints\n");
			int[] sortedInts = ints.Sort(SortDirection.Descending);
			Console.WriteLine(string.Join(", ", sortedInts));

			Console.WriteLine("\n----------\n");
			Console.WriteLine("\nSorted Strings\n");
			string[] sortedStrings = strings.Sort(SortDirection.Ascending);
			Console.WriteLine(string.Join(", ", sortedStrings));

			int sub_start_index = 1;
			int sub_length = 3;

            //ArrayHelper_T<string> sub_strings = new ArrayHelper_T<string>(sub_length);

            string[] sub_strings = strings.GetSubArray(sub_start_index, sub_length);
			Console.WriteLine(string.Join(", ", sub_strings));
			
			//var sub_strings = strings.GetSubArray<ArrayHelper_T<string>>(array: strings, index: sub_start_index, size: sub_length);
			// sub_strings.SortPrintArray();



			Console.WriteLine("\n----- End. -----\n");
		}
	}
}
