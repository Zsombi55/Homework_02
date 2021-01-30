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
                R-StringIsNotNullOrEmpty rule = new R-StringIsNotNullOrEmpty();
                return rule.Validate(p.FirstName) && rule.Validate(p.LastName);
            }

            return false;
        }
	}
}
