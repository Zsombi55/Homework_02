using System;
using DataValidations.ValidatorEngine;

namespace DataValidations.Client
{
	class R_NameIsValid : Rules
    {
        public override bool Validate(object input)
        {
            if (input is Person p)
            {
                R-SIsNotNullOrEmpty rule = new R-SIsNotNullOrEmpty();
                return rule.Validate(p.FirstName) && rule.Validate(p.LastName);
            }

            return false;
        }
	}
}
