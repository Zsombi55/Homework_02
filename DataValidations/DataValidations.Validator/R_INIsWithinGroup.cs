using System;
using System.Collections.Generic;

namespace DataValidations.ValidatorEngine
{
    // Like "R_SNIsWithinInterval" but checking against an integer array.
	public class R_INIsWithinGroup : R_SIsNumber
	{
		/// <summary>
        /// Constructor. Allows outside array access.
        /// </summary>
        /// <param name="values">Array of numbers.</param>
		public R_INIsWithinGroup(int[] numbers)
        {
            Numbers = numbers;
        }

        public int[] Numbers { get; }

        /// <summary>
		/// Checks the given data object wether it is part of the specified group.
        /// </summary>
        /// <param name="input">Data object to validate.</param>
        /// <returns>Boolean: is within limits?</returns>
        public override bool Validate(object input)
        {
            if (base.Validate(input))
            // Input is already a number.
            {
                if (int.TryParse(input as string, out int number))
                    for(int i = 0; i < Numbers.Length; i++)
                    {
                        if(Numbers[i].Equals(number))  return true;
                    }
            }

            // Not found in the array !
            return false;
        }
	}
}
