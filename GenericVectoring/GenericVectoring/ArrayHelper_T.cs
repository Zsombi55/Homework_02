using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
    public class ArrayHelper_T<T> : IEnumerable<T>
        where T : IEquatable<T>, IComparable<T>
    {
        private T[] array;
        //private int index = 0;

        /// <summary>
        /// Constructor for creating an array of type T of a certain size.
        /// </summary>
        /// <param name="size">Integer: length of the desired array.</param>
        // public ArrayHelper_T(int size)
        public ArrayHelper_T(T[] array)
        {
            // array = new T[size];
            //this.array = Array.Copy(array);
            this.array = ArrayHelper_T<T>.Clone(array);
        }

        /// <summary>
        /// Collection initializer.
        /// </summary>
        /// <param name="value">T: an element to be added to an array.</param>
        /// <param name="index">Integer: array element index.</param>
        //public void Add(T value, int index)
        //{
        //	if (index < array.Length)
        //	{
        //		array[index] = value;
        //		index++;
        //	}
        //	else
        //	{
        //		throw new IndexOutOfRangeException();
        //	}
        //}

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }


        /// <summary>
        /// Indexer for a T type array.
        /// </summary>
        /// <param name="index">Integer: size/ length of the connected T type array.</param>
        /// <returns>T: the value at the specified index.</returns>
        /// <remarks>Would have used one check containing the get-set with only one Ex.-throw, but the indexer only allows get-set for its first layer.</remarks>
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else throw new ArgumentException("The specified index value is either smaller or larger than the array's size.", nameof(index));
            }

            set
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value;
                }
                else throw new ArgumentException("The specified index value is either smaller or larger than the array's size.", nameof(index));
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
        /// Prints out an array, in a single line, the elements Join -ed by double blank /whitespace.
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
        public int GetElementIndex(T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool equals = ((IEquatable<T>)value).Equals(array[i]);
                if (equals)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Sorts an array in Ascending order using IComparable<T> then,
        /// Prints out the array, in a single line, the elements Join -ed by double blank /whitespace. 
        /// IF the array size is only 1 there is no sorting just printing with accompanying explanation.
        /// </summary>
        public void SortPrintArray()
        {
            if (array.Length > 1)
            {
                Array.Sort<T>(array);
                Console.WriteLine($"Sorted sub-vector: {string.Join("  ", array)} .\n");
            }
            else
                Console.WriteLine($"There is only one element: {array[0]} .\n");
        }

        public T[] Sort(SortDirection sortDirection)
        {
            T[] result = ArrayHelper_T<T>.Clone(array);

            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    bool isSwapNeeded;
                    switch (sortDirection)
                    {
                        case SortDirection.Descending:
                            isSwapNeeded = ((IComparable<T>)result[i]).CompareTo(result[j]) < 0; // <
                            break;

                        case SortDirection.Ascending:
                        default:
                            isSwapNeeded = ((IComparable<T>)result[i]).CompareTo(result[j]) > 0; // >
                            break;
                    }

                    if (isSwapNeeded)
                    {
                        T temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Extracts a sub-array from an array beginning from the specified index until the specified length.
        /// </summary>
        /// <param name="array">T: a generic array.</param>
        /// <param name="index">Integer: array index marker.</param>
        /// <param name="size">Integer: size of the extracted section and size of the sub-array.</param>
        /// <returns>T[]: the extracted sub-array.</returns>
        public T[] GetSubArray(int index, int size)
        //public T[] GetSubArray<T>(T[] array, int index, int size) // old
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (size < 0)
            {
                throw new ArgumentException("Size must be positive", nameof(size));
            }

            if (index + size > array.Length)
            {
                size = array.Length - index + 1;
            }

            T[] result = new T[size];
            for (int i = index; i < index + size; i++)
            {
                result[i - index] = array[i];
            }

            return result;
        }

        private static T[] Clone(T[] array)
        {
            T[] result = new T[array?.Length ?? 0];

            for (int i = 0; i < (array?.Length ?? 0); i++)
            {
                result[i] = array[i];
            }

            return result;
        }
    }
}

/* Sub-Array size counter help
// "size"  to  "end index" conversion :  index + size - 1  ||  max size :  array.Length - index + 1
// 0 1 2 3 (4) 5 6 7 (8) 9 10 ||  I = 4 , size = 5  =>>  max Sub L = 7   =>>  Sub = 5 , end I = 8
 */
