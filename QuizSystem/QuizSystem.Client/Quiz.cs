using System;
using System.Collections.Generic;

// Question selection.
namespace QuizSystem.Client
{
	public class Quiz
	{
		public Quiz(Question[] questions)
        {
            Questions = questions ?? throw new ArgumentNullException(nameof(questions), "This Quiz has no Questions!");
        }
	}
}
