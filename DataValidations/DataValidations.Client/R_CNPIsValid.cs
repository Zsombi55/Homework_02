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

using System;
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
                
            int century, year, month, day, county, regOrderNr, securityNr;
            bool isCNP;
            
            int[] scm = new int[] {1, 3, 5, 7};
            int[] scf = new int[] {2, 4, 6, 8};
            
		    
            if (input is Person p)
            {    
                try
                {
                    // 1. Length check = 13 .
                    if(p.CNP.Length != 13)  return false;

                    // 2. Type check = all numeric, whole .
                    R_SIsNumber rule1 = new R_SIsNumber();
                    //return rule.Validate(p.CNP);
                    if(!rule1.Validate(p.CNP))  return false;

                    // 3. Security check = Constant "279146358279";
                    //       Multiply the ifrst 12 digits by the corresponding one from the Constant; add them all together, divide the result by 11;
                    //       --IF-- its modulus is  < 10  that will be it --ELSE--  1 .
                    string ct = "279146358279";
                    int sum = 0;
                    for (int i = 0; i < 12; i++) //++i)
                    {
                        int nr1 = p.CNP[i];
                        int nr2 = ct[i];
                        int r = nr1 * nr2;
                        sum += r;
                    }
                    if (sum % 11 == 10)
                    {
                        if(p.CNP[12] != 1)  return false;
                    }
                    else
                    {
                        if(p.CNP[12] != (sum % 11))  return false;
                    }

                    // 4. Sex & century check = IF male: 1, 3, 5, or 7 . IF female: 2, 4, 6, or 8 .
                    R_INIsWithinGroup rule2 = new R_INIsWithinGroup(
                        numbers: scm
                    );
                    if(rule2.Validate(p.CNP.Substring(0, 1)))
                    {
                        p.Sex = "Male";
                        isCNP = true;
                    }
                    else
                    {
                        rule2 = new R_INIsWithinGroup(
                            numbers: scf
                        );
                        if(!rule2.Validate(p.CNP.Substring(0, 1)))
                        {
                            p.Sex = "Female";
                            isCNP = true;
                        }
                        else
                            return false;
                    }
                
                    // 5. Year check = min. 18 less than current DateTime.Year .
                    year = int.Parse(p.CNP.Substring(1, 2));
                    century = 0;

                    if (year == 1 || year == 2)
                        century += 1900;
                    else if (year == 3 || year == 4)
                        century += 1800;
                    else // 5 or 6 or immigrants? (7 or 8)
                        century += 2000;
                
                    if((century + year) + 18 !>= DateTime.Now.Year)  return false;

                    // 6. Month check = 1 ~ 12 .
                    rule1 = new R_SNIsWithinInterval(
                        fromValue: 1,
                        toValue: 12
                    );
                    if(!rule1.Validate(p.CNP.Substring(3, 2)))  return false;

                    // 7. Day check = 1 ~ 31 .
                    rule1 = new R_SNIsWithinInterval(
                        fromValue: 1,
                        toValue: 31
                    );
                    if(!rule1.Validate(p.CNP.Substring(5, 2)))  return false;

                    // 8. County check = 1 ~ 52 .
                    rule1 = new R_SNIsWithinInterval(
                        fromValue: 1,
                        toValue: 52
                    );
                    if(!rule1.Validate(p.CNP.Substring(7, 2)))  return false;

                    // 9. Reg. order nr. check = 001 ~ 999 for each same sex-birthDate pair; more than one of the same pair cannot have the same R.O.N.
                    rule1 = new R_SNIsWithinInterval(
                        fromValue: 1,
                        toValue: 999
                    );
                    if(!rule1.Validate(p.CNP.Substring(9, 3)))  return false;

                    return isCNP;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"ERROR.. \n{e}");
                    return false;
                }
            }

            return false;
        }
	}
}
