using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizSystem.Client
{
	public class Q_MultipleSelection : Question
    {
		/// <summary>
        /// Defines what is the expected input string value for questions where none of the listed answer options are the correct ones.
        /// </summary>
		public const string NotAnOptionAnswer = "0";

        /// <summary>
        /// Defines an answer option index for the "none" or "not listed" answer choice.
        /// </summary>
        //public const int NotAnOptionIndex = -1;

		/// <summary>
        /// Gets a collection of possible & expected answer options.
        /// </summary>
		public Option[] Options { get; set; }

		/// <summary>
        /// Gets the index List of the expected answer options from a question's n option collection.
        /// If it cannot find any then, Gets the one reserved for the "not listed" answer index value, -1 .
        /// </summary>
        public int[] CorrectAnswerIndices
        {
            get
            {
                List<int> indices = new List<int>();

                for (int i = 0; i < Options.Length; i++)
                {
                    if (Options[i].IsCorrectOption)
                    {
                        indices.Add(i);
                    }
                }

                return indices.ToArray();
            }
        }

        /// <summary>
        /// Constructor for creating multiple choice type questions.
        /// Derived from the parent Question class.
        /// </summary>
        /// <param name="id">Integer: identifier.</param>
        /// <param name="description">String: text (question, description, instructions).</param>
        /// <param name="options">Option array: list of possible & expected answer options.</param>
        /// <exception cref="System.ArgumentNullException">When there are no possible or expected answer options.</exception>
        public Q_MultipleSelection(int id, string description, Option[] options)
            : base (id, description)
        {
        	Options = options ?? throw new ArgumentNullException(nameof(options));
	    }

        /// <summary>
        /// Prints a question text and its matching collection of possible answers (options).
        /// Specific "Question" derivate function for multiple choice type questions.
        ///     1. prints question text,
        ///     2. provides input instructions to the User,
        ///     3. prints matching answer option collection in numbered list format.
        /// </summary>
		public override void Print()
		{
			Console.WriteLine(Description);
            Console.WriteLine("Select the possible answer list option numbers separated by a blank whitespace, in case of no match found enter 0 .");
            for (int i = 0; i < Options.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {Options[i].Text}");
            }
		}

        /// <summary>
        /// Validates the answer and sets the current question's points.
        /// Specific "Question" derivate function for multiple choice type questions.
        /// 
        /// First checks if the User input is usable, then wether it is an exact match of the expected one(s).
        /// If they are not exact equals, the element by element validation begins.
        /// </summary>
        /// <param name="answer">String: User answer input.</param>
		public override void ValidateAnswer(string answer)
		{
            if (string.IsNullOrWhiteSpace(answer))
            {
                return;
            }


            int[] correctAnswerIndices = CorrectAnswerIndices;

            if (string.Equals(answer, NotAnOptionAnswer, StringComparison.OrdinalIgnoreCase) &&
                correctAnswerIndices.Length == 0)
            {
                Points = 1;
                return;
            }


            string[] parts = answer.Split(' ', StringSplitOptions.TrimEntries); // (",", StringSplitOptions.RemoveEmptyEntries);
            bool allCorrect = true;

            foreach (string part in parts)
            {
                if ( ! int.TryParse(part, out int partNo))
                {
                    allCorrect = false;
                    break;
                }

                bool found = false;
                for (int i = 0; i < correctAnswerIndices.Length; i++)
                {
                    if (correctAnswerIndices[i] == partNo - 1)
                    {
                        found = true;
                        break;
                    }
                }

                if ( ! found)
                {
                    allCorrect = false;
                    break;
                }
            }
            
            if (allCorrect)
            {
                Points = 1;
            }
		}
	}
}
