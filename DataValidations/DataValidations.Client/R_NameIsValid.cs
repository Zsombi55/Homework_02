using DataValidations.ValidatorEngine;

namespace DataValidations.Client
{
	public class R_NameIsValid : Rule
    {
        /// <summary>
        /// Checks wether the given data object's "FirstName" & "LastName" elements have any value or not.
        /// However, it does not otherwise check for information correctness.
        /// </summary>
        /// <param name="input">Data object to validate.</param>
        /// <returns>Boolean: is null or empty?</returns>
        public override bool Validate(object input)
        {
            if (input is Person p)
            {
                R_SIsNotNullOrEmpty rule = new R_SIsNotNullOrEmpty(); // Create a new instance of the respective "rule-describing" class.
                return rule.Validate(p.FirstName) && rule.Validate(p.LastName); // Use its implementation of "Rule"'s generic function.
            }

            return false; // Null or Empty.
        }
	}
}
