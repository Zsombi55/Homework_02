
namespace DataValidations.ValidatorEngine
{
	public class R_SIsNumber : Rule
	{
        /// <summary>
		/// Checks the given data object wether it is a number.
        /// </summary>
        /// <param name="input">Data object to validate.</param>
        /// <returns>Boolean: string type?</returns>
		public override bool Validate(object input)
		{
			if (input is null)  return false;
            
            if (input is string stringInput)
            {
                // Done this way because the id.nr is larger than "int" and so much smaller than "long".
                // Plus we haven't gone over Linq yet or it could be just  if(!str.All(..))  without "foreach".
                foreach (char c in stringInput)
                {
                    if (!char.IsDigit(c))  return false;
                }

                return true;
            }

            return false; // Not string !
		}
	}
}
