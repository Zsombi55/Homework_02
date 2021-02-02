
namespace QuizSystem.Validator
{
	public class R_StrIsNotNullOrWhiteSpace : Rules
	{
		public override bool Validate(object input)
		{
			//throw new NotImplementedException();
			
			if (input is null)  return false;
            
            if (input is string strIn)  return !string.IsNullOrWhiteSpace(strIn);
            
            // Not string !
            return false;
		}
	}
}
