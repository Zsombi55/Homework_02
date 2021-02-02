using QuizSystem.Validator;

namespace QuizSystem.Validator
{
	public class R_InputIsValid : Rules
	{
		public override bool Validate(object input)
		{
			//throw new NotImplementedException();

			if (input is Question q)
            {
                StringRepresentsANumberRule rule = new StringRepresentsANumberRule();
                return rule.Validate(q.Choice);
            }

            return false;
		}
	}
}
