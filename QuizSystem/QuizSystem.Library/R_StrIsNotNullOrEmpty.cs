
namespace QuizSystem.Validator
{
	public class R_StrIsNotNullOrEmpty : Rules
	{
		public override bool Validate(object input)
		{
			//throw new NotImplementedException();
			
			if (input is null)  return false;
            
            if (input is string strIn)  return !string.IsNullOrEmpty(strIn);
            
            // Not string !
            return false;
		}
	}
}
