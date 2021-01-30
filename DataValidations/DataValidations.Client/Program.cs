/*
 * User: Zsombor
 * Date: 2021-01-30
 * Time: 10:57
 * 3rd.
 */

using System;

namespace DataValidations.Client
{
	class Program
	{
		static void Main(string[] args)
		{
            // TODO: Move the "database" array to a separate class of its own, then use it here like variables of another classes are used.
            // TODO: OR move to a file (txt, ini, xml) /DB then get it from there.
			Person[] people = new[]
            {
                new Person
                {
                    FirstName = "Espresso",
                    LastName = "Cafea",
                    CNP = "1410313510027",
                    Age = 80
                },

                new Person
                {
                    FirstName = "Verde",
                    LastName = "Ceai",
                    CNP = "1300812420055",
                    Age = 95
                },

                new Person
                {
                    FirstName = "Cappuccino",
                    LastName = "Cafea",
                    CNP = "1334668580055",
                    Age = 25
                }
            };

            ProcessPeople processor = new ProcessPeople(rules:
                new ValidatorEngine.Rule[]
                {
                    new R_NameIsValid(),
                    new R_CNPIsValid(),
                    new R_IsAdult()
                });

            processor.Process(people);

			Console.WriteLine("\nEnd.\n");
		}
	}
}
