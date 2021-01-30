using DataValidations.ValidatorEngine;

namespace DataValidations.Client
{
	public class R_CNPIsValid : Rule
	{
        /// <summary>
        /// Checks wether the given data object's "CNP" (id.nr) element is numeric or not.
        /// However, it does not otherwise check for information correctness.
        /// </summary>
        /// <param name="input">Data object to validate.</param>
        /// <returns>Boolean: is numeric?</returns>
		public override bool Validate(object input)
        {
            // https://ro.wikipedia.org/wiki/Cod_numeric_personal_(Rom%C3%A2nia)

            //              1             90           08           31          05            505              4
            //      male, 1900~1999    year 1990   month August    day 31      county      reg.order.nr    security.nr
                
            int sexCentury, year, month, day, county, regOrderNr, securityNr;
            bool isCNP = false;
		    
            if (input is Person p)
            {    
                // 1. Length check = 13 .
                if(p.CNP.Length != 13)  return false;

                // 2. Type check = all numeric, whole .
                R_SIsNumber rule = new R_SIsNumber();
                //return rule.Validate(p.CNP);
                if(!rule.Validate(p.CNP))  return false;

                // 3. Security check = ?
                
                // 4. Sex & century check = IF male: 1, 3, 5, or 7 . IF female: 2, 4, 6, or 8 .

                // 5. Year check = min. 18 less than current DateTime.Year .
                
                // 6. Month check = 1 ~ 12 .

                // 7. Day check = 1 ~ 31 .

                // 8. County check = 1 ~ 52 .

                // 9. Reg. order nr. check = ?


                isCNP = false;
            }

            return false;
        }
	}
}

/*
 * Perform data validations on them: input is not null/empty, `id.nr` & `age` is number, `id.nr` is made up of a set of _13_ specific numbers in a certain order:
 *
 * - male's start with 1, 3, 5 or 7 ; females start with 2, 4, 6 or 8 ;
 *
 * - next 6 digits (2 for each) is year, month and day of birth,
 *
 * - then 2 digits conforming for the county of residence,
 *
 * - next 3 digits are the registration order number,
 *
 * - finally the last digit is a security marker;
 *
 * check wether `age` is below or over `18` .
 */