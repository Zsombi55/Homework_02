using System;
using System.Collections.Generic;

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
	/// <summary>
	/// Generic class for creating various types of 1-dimensinsal Arrays.
	/// </summary>
	/// <typeparam name="T">Generic: any type desired.</typeparam>
	public class ArrayHelper_T<T>
	{
		private T[] array;

		/// <summary>
		/// Constructor for creating an array of type T of a certain size.
		/// </summary>
		/// <param name="size">Integer: length of the desired array.</param>
		public ArrayHelper_T(int size)
		{
			array = new T[size];
		}

		/// <summary>
		/// Indexer for a T type array.
		/// </summary>
		/// <param name="index">Integer: size/ length of the connected T type array.</param>
		/// <returns>T: the value at the specified index.</returns>
		/// <remarks>Would have used one try-catch containing the get-set with only one Ex.-throw, but the indexer only allows get-set for its first layer.</remarks>
		public T this[int index]
		{
			get
			{
				try { return array[index]; }
				catch { throw new IndexOutOfRangeException("The specified index value is either smaller or larger than the array's size."); }
			}

			set
			{
				try { array[index] = value; }
				catch { throw new IndexOutOfRangeException("The specified index value is either smaller or larger than the array's size."); }
			}
		}

		/// <summary>
		/// Gets the size of the T type array.
		/// </summary>
		public int Size
		{
			get { return array.Length; }
		}


		// TODO: this may print gibberish if the elements are not of string or a number type ?
		/// <summary>
		/// Prints out an array, each element in a new line. 
		/// </summary>
		public void PrintElements()
		{
			//for(int i = 0; i < array.Length; i++)
			//{
			//	Console.WriteLine(array[i]);
			//}
			Console.WriteLine(string.Join("  ", array) + "\n");
		}

		/// <summary>
		/// Looks for the specified value inside a target array.
		/// </summary>
		/// <typeparam name="T">Generic: any type desired.</typeparam>
		/// <param name="value">Generic: a value of the desired type.</param>
		/// <param name="array">Generic: an array of the desired type.</param>
		/// <returns>Integer: the index of the matching value; " -1 "  if not found.</returns>
		//public int GetElementIndex<T>(T value) where T : IComparable		// This was my first attempt, before reading the instructions in detail.
		//{
		//	for(int i = 0; i < array.Length; i++)
		//	{
		//		if(value.CompareTo(array[i]) == 0)
		//		{
		//			return i;
		//		}
		//	}
		//	return -1;
		//}
		public int GetElementIndex<T>(T value) where T : IEquatable<T>
		{
			for(int i = 0; i < array.Length; i++)
			{
				if(value.Equals(array[i]))
				{
					return i;
				}
			}
			return -1;
		}
	}
}
