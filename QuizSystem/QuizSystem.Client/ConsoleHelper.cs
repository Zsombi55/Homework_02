//using System;
//using System.Collections.Generic;

//// Get and Print information from & to the Console.
//namespace QuizSystem.Client
//{
//	public static class ConsoleHelper
//	{
//		internal static void PrintInstructions()
//		{
//			Console.WriteLine("Choose the answers by their numbers, IF NONE is found correct use \"0\".\n" +
//				"For multiple answers type each in the same line each separated by a blank /whitespace character.\n\n" +
//				"NOTE: perfect score equals  \" 0 \", the higher it is the more wrong choices were made !\n\n" +
//				"WARNING: In multiple choice cases enter answer numbers in the same order they are listed !\n" +
//				"------------------------------");
//		}

//		/// <summary>
//		/// Takes a list of choice based questions, iterates and prints each question and the included list of possible answers, one after the other.
//		/// Does not wait for user answers.
//		/// </summary>
//		/// <param name="questions">List of question objects.</param>
//		internal static void PrintChoiceQuestion(List<Question> questions)
//        {
//			if(questions is null) throw new ArgumentNullException(nameof(questions), "Missing \"questions\" collection.");

//			for (int i = 0; i < questions.Count; i++)
//			{
//				if(questions[i] is null)
//					throw new ArgumentNullException(nameof(questions), "A \"question\" object of the \"questions\" collection does not exist.");
				
//				Console.WriteLine("------------------------------\n" +
//					$"Q { i + 1 }.) {questions[i].Description}\n");
//				//
//				Console.WriteLine("---------------");
//				//
//				for(int j = 0; j < questions[i].PossibleAnswers.Length; j++) // String array.
//				{
//					Console.WriteLine($"\tA { j + 1 }.) {questions[i].PossibleAnswers[j]}\n");
//				}
//			}
//			Console.WriteLine("------------------------------\n");
//		}

//		/// <summary>
//		/// Takes the accumulated points and prints a closing message based on it.
//		/// Compares result score to total question count.
//		/// </summary>
//		/// <param name="points">Total accumulated points. Zero means no mistakes.</param>
//		/// <param name="questionCount">Int: Total number of questions.</param>
//		internal static void PrintTotalScore(int points, int questionCount)
//		{
//			if(points == 0)
//				Console.WriteLine("------------------------------\n" +
//					$"Congratulations! You made NO mistakes :D\n" +
//					$"\tTotal score: {points}\n" +
//					"All questions were answered correctly.");
//			else
//				Console.WriteLine("------------------------------\n" +
//					"Condolences.. You made mistakes  D:\n" +
//					$"\tTotal score: {points}\n" +
//					$"Number of questions correctly answered:  { (questionCount - points) }  " +
//						$"out of  {questionCount} .");
//		}
//	}
//}

///* Unused for number-picking questions.
// * 
//		public static void PrintTypeQuestion(Question question)
//		{
//			if(question is null) throw new ArgumentNullException("The question object doesn't exist.", nameof(question));

//			Console.WriteLine($"-------------------------\n" +
//							  $"{question.IdNumber}. {question.Description}\n\n");
//		}
//*/