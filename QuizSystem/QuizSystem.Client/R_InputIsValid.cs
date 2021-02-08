using QuizSystem.Validator;

namespace QuizSystem.Validator
{
	public class R_InputIsValid : Rules
	{
		/// <summary>
		/// Validates User Input that it exists, is not without value, and that it contains more than blank space characters.
		/// </summary>
		/// <param name="input">Any kind of input (preferably of type string).</param>
		/// <returns>Boolean: is valid ?</returns>
		public override bool Validate(object input)
		{
			if (input is null)  return false;

			if (input is string strIn)
			{
				R_StrIsNotNullOrEmpty rule1 = new R_StrIsNotNullOrEmpty();
                R_StrIsNotNullOrWhiteSpace rule2 = new R_StrIsNotNullOrWhiteSpace();

				return rule1.Validate(strIn) && rule2.Validate(strIn); 
			}

            return false;
		}
	}
}
