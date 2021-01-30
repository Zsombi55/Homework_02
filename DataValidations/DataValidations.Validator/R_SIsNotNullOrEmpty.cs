
namespace DataValidations.ValidatorEngine
{
	public class R_SIsNotNullOrEmpty : Rule
	{
		/// <summary>
		/// Type checks the given data object for "string".
        /// </summary>
        /// <param name="input">Data object to validate.</param>
        /// <returns>Boolean: string type?</returns>
		public override bool Validate(object input)
		{
			if (input is null)  return false;
            
            if (input is string stringInput)  return !string.IsNullOrEmpty(stringInput);
            
            return false; // Not string !
		}
	}
}
