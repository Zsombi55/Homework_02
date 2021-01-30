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
                    FirstName = "Verde",
                    LastName = "Ceai",
                    CNP = "5080917195706",
                    Age = 17
                },

                new Person
                {
                    FirstName = "Espresso",
                    LastName = "Cafea",
                    CNP = "1410313519090",
                    Age = 80
                },

                new Person
                {
                    FirstName = "Mocha",
                    LastName = "Cafea",
                    CNP = "2960816049410",
                    Age = 25
                },

                new Person
                {
                    FirstName = "Cappuccino",
                    LastName = "Cafea",
                    CNP = "1960816047300",
                    Age = 25
                }
            };

            // Validation batch 1 - displaying all people with valid names, id.nr and being above 18 years old.
            ProcessPeople processor = new ProcessPeople(rules:
                new ValidatorEngine.Rule[]
                {
                    new R_NameIsValid(),
                    new R_CNPIsValid(), // TODO: either my test cases are wrong or there is an error in this class.
                    new R_IsAdult()
                });
            processor.Process1(people);
            Console.WriteLine("--------------------");
            
            // Validation batch 2 - displaying all people with valid names, id.nr, being above 18 years old, and being a male.
            processor = new ProcessPeople(rules:
                new ValidatorEngine.Rule[]
                {
                    new R_NameIsValid(),
                    new R_CNPIsValid(),
                    new R_IsAdult()
                });

            processor.Process2(people);
            Console.WriteLine("--------------------");
            

			Console.WriteLine("\nEnd.\n");
		}
	}
}
