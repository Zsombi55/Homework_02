
using DataValidations.ValidatorEngine;

namespace DataValidations.Client
{
	public class R_CNPIsValid : Rule
	{
		public override bool Validate(object input)
        {
		    if (input is Person p)
            {
                R_SIsNumber rule = new R_SIsNumber();
                return rule.Validate(p.CNP);
            }

            return false;
        }
	}
}
