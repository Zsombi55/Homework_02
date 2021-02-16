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
        public const int NotAnOptionIndex = -1;

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
        /// <exception cref="System.ArgumentException">When the number of expected /correct answer options are too many, more than one.</exception>
        public Q_MultipleSelection(int id, string description, Option[] options)
            : base (id, description)
        {
        	Options = options ?? throw new ArgumentNullException(nameof(options));
	    }

		public override void Print()
		{
			throw new NotImplementedException();
		}

		public override void ValidateAnswer(string answer)
		{
			throw new NotImplementedException();
		}
	}
}
