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
			strings[0] = "aa";
			strings[1] = "bb";
			strings[2] = "cc";
			strings[3] = "dd";
			strings[4] = "ee";
			
			//var ints = new ArrayHelper_T<int>(size: 5);
			//ints = {1, 2, 3, 4, 5};

			strings.PrintElements();
			//for(int i = 0; i < strings.Size; i++)	Console.WriteLine(string.Join(' ', strings[i]));

			int eIndex = strings.GetElementIndex("c");
			Console.WriteLine(eIndex);

			Console.WriteLine("\nEnd.\n");
		}
	}
}
