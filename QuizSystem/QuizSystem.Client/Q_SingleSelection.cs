using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizSystem.Client
{
    /// <summary>
    /// Specific "Question" type derivate. Defines how to handle questions wher only 1 choice type answer is accepted.
    /// </summary>
	public class Q_SingleSelection : Question
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
        public Option[] Options { get; }

        /// <summary>
        /// Gets the index of the expected answer options from a question's n option collection.
        /// If it cannot find any then, Gets the one reserved for the "not listed" answer index value, -1 .
        /// </summary>
        public int CorrectAnswerIndex
        {
            get
            {
                for (int i = 0; i < Options.Length; i++)
                {
                    if (Options[i].IsCorrectOption)
                    {
                        return i;
                    }
                }

                return NotAnOptionIndex;
            }
        }


        /// <summary>
        /// Constructor for creating single choice type questions.
        /// Derived from the parent Question class.
        /// </summary>
        /// <param name="id">Integer: identifier.</param>
        /// <param name="description">String: text (question, description, instructions).</param>
        /// <param name="options">Option array: list of possible & expected answer options.</param>
        /// <exception cref="System.ArgumentNullException">When there are no possible or expected answer options.</exception>
        /// <exception cref="System.ArgumentException">When the number of expected /correct answer options are too many, more than one.</exception>
        public Q_SingleSelection(int id, string description, Option[] options)
            : base (id, description)
        {
            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            int countCorrectOptions = 0;
            for (int i = 0; i < options.Length; i++)
            {
                if (options[i].IsCorrectOption)
                {
                    countCorrectOptions++;
                }
            }

            if (countCorrectOptions > 1)
            {
                throw new ArgumentException(nameof(options), "Maximum 1 answer option can be the correct one.");
            }

            Options = options;
        }

        
        /// <summary>
        /// Prints a question text and its matching collection of possible answers (options).
        /// Specific "Question" derivate function for single choice type questions.
        ///     1. prints question text,
        ///     2. provides input instructions to the User,
        ///     3. prints matching answer option collection in numbered list format.
        /// </summary>
        public override void Print()
        {
            Console.WriteLine(Description);
            Console.WriteLine("Select the possible answer list option numbers, in case of no match found enter 0 .");
            
            for (int i = 0; i < Options.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {Options[i].Text}");
            }
        }

        /// <summary>
        /// Validates the answer and sets the current question's points.
        /// Specific "Question" derivate function for single choice type questions.
        /// </summary>
        /// <param name="answer">String: User answer input.</param>
        public override void ValidateAnswer(string answer)
        {
            if (string.IsNullOrWhiteSpace(answer))
            {
                return;
            }

            if ( ! int.TryParse(answer, out int answerNr))
            {
                return;
            }

            // nr = index + 1
            // no options => nr = 0 => index = -1
            if (answerNr - 1 == CorrectAnswerIndex)
            {
                Points = 1;
            }
        }
	}
}
