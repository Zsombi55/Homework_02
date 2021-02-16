using System;

namespace QuizSystem.Client
{
	public class Quiz
	{
        /// <summary>
        /// Constructor allowing the creation of a Quiz, a set of Questions to be used.
        /// </summary>
        /// <param name="questions">Question array: Possibly different types of "Question" objects.</param>
        /// <exception cref="System.ArgumentNullException">When the "Questions" collection object does not exist.</exception>
		public Quiz(Question[] questions)
        {
            Questions = questions ?? throw new ArgumentNullException(nameof(questions), "This Quiz has no Questions!");
        }


        /// <summary>
        /// Gets a Question type array.
        /// </summary>
		public Question[] Questions { get; }

        /// <summary>
        /// Gets the total accumulated points value.
        /// </summary>
        public int TotalPoints { get; private set; }


        /// <summary>
        /// Begins the question-answer cycle, and the score counter.
        /// Begins with warning the User that the quiz has startd, then cyclically:
        ///     1. printing the next question with its answer options,
        ///     2. waiting for User answer input,
        ///     3. validating User input,
        ///     4. then calculating current total points accumulated.
        /// After the last cycle, prints the final score.
        /// </summary>
        public void TakeQuiz()
        {
            Console.WriteLine("Starting quiz:");

            foreach (Question q in Questions)
            {
                q.Print();
                Console.Write("Your answer=");
                string answer = Console.ReadLine();
                q.ValidateAnswer(answer);
                TotalPoints += q.Points;
            }

            Console.WriteLine($"Done!\nYour Final Score =  {TotalPoints}  points!");
        }
	}
}
