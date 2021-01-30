using System;
using DataValidations.ValidatorEngine;

namespace DataValidations.Client
{
	public class ProcessPeople
	{
		/// <summary>
        /// Constructor. Allows outside "ValidationEngine" instance access.
        /// </summary>
        /// <param name="rules">Array of "Rule" type objects.</param>
		public ProcessPeople(Rule[] rules)
		{
			V_Engine = new ValidatorEngine.ValidationEngine(rules);
		}

		public ValidatorEngine.ValidationEngine V_Engine { get; }

		/// <summary>
		/// Takes an array containing personal data holding objects.
		/// Performs content availability checks on the Array, then begins validation of its elements' contents.
		/// Finally, it prints the results one element per line, marking which has any invalid entries.
		/// </summary>
		/// <param name="people">Array of Person objects, whose elements contain personal data: names, id.nr and age.</param>
		public void Process1(Person[] people)
		{
			if(people is null)
			{
				Console.WriteLine("People collection is NULL !  Can't process.");
				return;
			}

			if(people.Length == 0)
			{
				Console.WriteLine("People collection is EMPTY !  Can't process.");
				return;
			}

			foreach (Person person in people)
			{
				bool isValid = V_Engine.Validate(person);

				if(isValid)
				{
					Console.WriteLine($"\nVALID: {person.LastName}, {person.FirstName}\nCNP: {person.CNP}\nAge: {person.Age}\nSex: {person.Sex}");
				}
				else
				{
					Console.WriteLine($"\nINVALID: {person.LastName}, {person.FirstName}\nCNP: {person.CNP}\nAge: {person.Age}\nSex: {person.Sex}");
				}
			}
		}

		public void Process2(Person[] people)
		{
			if(people is null)
			{
				Console.WriteLine("People collection is NULL !  Can't process.");
				return;
			}

			if(people.Length == 0)
			{
				Console.WriteLine("People collection is EMPTY !  Can't process.");
				return;
			}

			foreach (Person person in people)
			{
				bool isValid = V_Engine.Validate(person);

				if (isValid)
				{
					if(person.Sex.ToString() == "Male")
						Console.WriteLine($"\nVALID: {person.LastName}, {person.FirstName}\nCNP: {person.CNP}\nAge: {person.Age}\nSex: {person.Sex}");
				}
				else
				{
					Console.WriteLine($"\nINVALID: {person.LastName}, {person.FirstName}\nCNP: {person.CNP}\nAge: {person.Age}\nSex: {person.Sex}");
				}
			}
		}
	}
}
