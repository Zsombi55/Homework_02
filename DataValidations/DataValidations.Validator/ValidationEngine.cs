
namespace DataValidations.ValidatorEngine
{
	public class ValidationEngine
	{
        /// <summary>
        /// Constructor. Allows outside "Rule" instance access.
        /// </summary>
        /// <param name="rules">Array of 0 or more "Rule" type objects.</param>
		public ValidationEngine(Rule[] rules)
        {
            Rules = rules ?? new Rule[] {};
        }

        public Rule[] Rules { get; }

        // Can take any kind of input, super generalized.
        public bool Validate(object input)
        {
            foreach(Rule rule in Rules) 
            {
                bool isValid = rule.Validate(input);

                if(!isValid) return false;
            }

            return true;
        }
	}
}
