using System;
using System.Collections.Generic;

namespace QuizSystem.Client
{
	public class QuestionDB
	{
        /// <summary>
        /// Creates a new set of questions with all necessary initial members & parameters.
        /// </summary>
        /// <returns name="Quiz">Object: a set of specific but possibly different types of "Question" objects
        ///                     with accompanying "Option" ((possible) answer) objects.</returns>
		public Quiz CreateQuiz()
        {
            return new Quiz(
                new Question[]
                {
                    new Q_SingleSelection(
                        1, 
                        "Which of these are vegetables?",
                        new Option[]
                        {
                            new Option("Banana"),
                            new Option("Apple"),
                            new Option("Tomato")
                        }
                    ),

                    new Q_SingleSelection(
                        2,
                        "Which of these have no curves?",
                        new Option[]
                        {
                            new Option("Cylinder"),
                            new Option("Ball"),
                            new Option("Pyramid", true),
                        }
                    ),

                    new Q_MultipleSelection(
                        3,
                        "Select all fruits.",
                        new Option[]
                        {
                            new Option("Carrot"),
                            new Option("Cherry", true),
                            new Option("Tomato", true)
                        }
                    ) // ,

                    //new Q_AlphaNumericInput(
                    //    4,
                    //    "Spell the word \"pac-man\" with a blank whitespace between each character.",
                    //    new Option("p a c - m a n")
                    //)
                }
            );
        }
	}

    
}

/* Typed answer question examples:
 * 
                new Question
                {
                    QuestionType = "text",
                    Number = 4,
                    Description = "What is the ratio of a circle's circumference to its diameter called, and is approximately equal to \"3.14159265359\"?",
                    TypeInChoice = string.Empty, // The User has to type in the answer.
                    TypeInCorrect = "pi" // Discard casing, it matters not.
                },

                new Question
                {
                    QuestionType = "text",
                    Number = 5,
                    Description = "What is the result of the equation \"2 x 2\"? First write it with numbers then with words, separated by a blank space.",
                    TypeInChoice = string.Empty, // The User has to type in the answer.
                    TypeInCorrect = "4 four" // Discard casing, it matters not.
                }
*/
