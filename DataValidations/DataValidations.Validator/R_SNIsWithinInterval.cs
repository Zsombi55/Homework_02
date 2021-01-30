
namespace DataValidations.ValidatorEngine
{
	public class R_SNIsWithinInterval : R_SIsNumber // Derived from "Rule". Done like this because "input" has to be checked if it's a number >> ** .
	{
        /// <summary>
        /// Constructor. Allows outside numeric data min-max limit access.
        /// </summary>
        /// <param name="fromValue">Minimum number limit.</param>
        /// <param name="toValue">Maximum number limit.</param>
		public R_SNIsWithinInterval(int fromValue, int toValue)
        {
            FromValue = fromValue;
            ToValue = toValue;
        }

        public int FromValue { get; }

        public int ToValue { get; }

        /// <summary>
		/// Checks the given data object wether it is within set limits.
        /// </summary>
        /// <param name="input">Data object to validate.</param>
        /// <returns>Boolean: is within limits?</returns>
        public override bool Validate(object input)
        {
            if (base.Validate(input)) // >> ** which was implemented already in "R_SIsNumber : Rule"; ready for use now.
            // Input is already a number.
            {
                if (int.TryParse(input as string, out int number))
                    return (number >= FromValue) && (number <= ToValue);
            }

            // Not a number !
            return false;
        }
	}
}
