using System;

namespace QuizSystem.Validator
{
	public class ValidatorEngine
	{
        /// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="rules">Object array for validation rules. If there is none it creates an empty one.</param>
		public ValidatorEngine(Rules[] rules)
        {
            Rules = rules ?? new Rules[] {};
        }

        public Rules[] Rules { get; }

        // Can take any kind of input (object), super generalized.
        public bool Validate(object input)
		{
			//throw new NotImplementedException();
            foreach(Rules rule in Rules)
            {
                bool isValid = rule.Validate(input);

                if(!isValid) return false;
            }
            return true;
		}
	}
}
