﻿/*
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
			var strings = new ArrayHelper_T<string[]>();
			strings.Add(new string[] {"t-1", "t-2", "t-3", "t-4", "t-5"});
			
			var ints = new ArrayHelper_T<int[]>();
			ints.Add(new int[] {1, 2, 3, 4, 5});


			Console.WriteLine("\nEnd.\n");
		}
	}
}
