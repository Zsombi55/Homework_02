using QuizSystem.Validator;

namespace QuizSystem.Validator
{
	public class R_StrIsValid : Rules
	{
		public override bool Validate(object input)
		{
			//throw new NotImplementedException();
			
			if (input is null)  return false;

			if (input is string strIn)
			{
				

				return true;
			}

            return false;
		}
	}
}
