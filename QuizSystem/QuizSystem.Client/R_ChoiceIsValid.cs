using QuizSystem.Validator;

namespace QuizSystem.Client
{
	public class R_ChoiceIsValid : Rules
	{
		public override bool Validate(object input)
		{
			//throw new NotImplementedException();

			if (input is null)  return false;

			if (input is string strIn)
			{
				return rule.Validate(p.FirstName) && rule.Validate(p.LastName);
			}

            return false;
		}
	}
}
