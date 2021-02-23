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
			ArrayHelper_T<string> strings = new ArrayHelper_T<string>(size: 5);
			//strings[0] = "aa";
			//strings[1] = "bb";
			//strings[2] = "cc";
			//strings[3] = "dd";
			//strings[4] = "ee";
			strings[0] = "cc";
			strings[1] = "bb";
			strings[2] = "aa";
			strings[3] = "ee";
			strings[4] = "dd";

			//var ints = new ArrayHelper_T<int>(size: 5);     // WHY DOES THIS NOT WORK ??
			//ints = { 1, 2, 3, 4, 5 };
			//var ints = new ArrayHelper_T<int>()
			//{
			//	1, 2, 3, 4, 5
			//};
			//ints.PrintElements();


			strings.PrintElements();

			int eIndex_OK = strings.GetElementIndex("cc");
			int eIndex_FAIL = strings.GetElementIndex("c");
			Console.WriteLine($"Checking for \"cc\": {eIndex_OK} ;\nChecking for \"c\": {eIndex_FAIL} .");

			Console.WriteLine("\n----------\n");
			strings.SortPrintArray();
			
			int sub_start_index = 1;
			int sub_length = 3;
			//ArrayHelper_T<string> sub_strings = new ArrayHelper_T<string>(sub_length);
			//strings.GetSubArray(array: strings, index: sub_start_index, size: sub_length);
			var sub_strings = strings.GetSubArray(array: strings, index: sub_start_index, size: sub_length);
			
			sub_strings.SortPrintArray(); //	this fails, I believe, because the above fails.

			Console.WriteLine("\n----- End. -----\n");
		}
	}
}
