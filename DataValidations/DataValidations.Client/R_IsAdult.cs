using DataValidations.ValidatorEngine;

namespace DataValidations.Client
{
	public class R_IsAdult : Rule
	{
        /// <summary>
        /// Checks wether the given data object's "Age" element is within certain bounds or not, or wether is a legal Adult or not.
        /// However, it does not otherwise check for information correctness (eg.: does it correspond to the given birth date).
        ///     But the instructions did not ask for realism.
        /// </summary>
        /// <param name="input">Data object to validate.</param>
        /// <returns>Boolean: is the Person old enough to legally be considered an Adult?</returns>
		public override bool Validate(object input)
        {
			if (input is Person p)
            {
                // NOTE: "18" is already considered an "Adult" in .. pretty much everywhere, legally speaking, so it is not really a good check.
                // Also, unless a person is.. say a clam, a sponge or one of those giant tortoise, the max limit is way too much.. and even then.
                // But this is what the instructions asked for.
                R_SNIsWithinInterval rule = new R_SNIsWithinInterval(
                    fromValue: 18,
                    toValue: int.MaxValue
                );

                return rule.Validate(p.Age.ToString());
            }

            return false;
		}
	}
}
