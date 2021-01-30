using System;
using DataValidations.ValidatorEngine;

namespace DataValidations.Client
{
	public class ProcessPeople
	{
		public ProcessPeople(ValidationRule[] rules)
		{
			ValidationEngine = new ValidatorEngine.ValidationEngine(rules);
		}

		public ValidatorEngine.ValidationEngine ValidationEngine { get; }

		public void Process(Person[] people)
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

			foreach(Person person in people)
			{
				bool isValid = ValidationEngine.Validate(person);

				if(isValid)
				{
					Console.WriteLine($"VALID: {person.FirstName} {person.LastName} | CNP: {person.CNP} | Age: {person.Age}");
				}
				else
				{
					Console.WriteLine($"INVALID: {person.FirstName} {person.LastName} | CNP: {person.CNP} | Age: {person.Age}");
				}
			}
		}
	}
}
