using System;

// Question-answer related IO checks.
namespace QuizSystem.Client
{
	public class Utils
	{
		public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static bool IsValidInput(object input) // string input)
        {
            if (!(input is string))
            {
                return false;
            }
            string strInput = (string) input;
            
            strInput = strInput.Trim();
            
            if(strInput.Split("", ))
            {}
            switch (strInput)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                    return true;
                default:
                    return false;
            }
        }

        public static int TranslateAnswer(string choice)
        {
            switch (choice.Trim())
            {
                case "A":
                    return 1;
                case "B":
                    return 2;
                case "C":
                    return 3;
                case "D":
                    return 4;
                default:
                    return -1;
            }
        }
	}
}
