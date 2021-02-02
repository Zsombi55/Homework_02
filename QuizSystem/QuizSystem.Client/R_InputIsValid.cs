using QuizSystem.Validator;

namespace QuizSystem.Validator
{
	public class R_InputIsValid : Rules
	{
		public override bool Validate(object input)
		{
			//throw new NotImplementedException();

			if (input is null)  return false;

			if (input is string strIn)
			{
				StringIsNotNullOrEmptyRule rule = new StringIsNotNullOrEmptyRule();
                return rule.Validate(p.FirstName) && rule.Validate(p.LastName);

				return true;
			}

            return false;
		}
	}
}
