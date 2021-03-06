# FTIT C-Sharp Homework Assignments, second batch

> 20210120 ~ 0224

* __A1 (ErrorLogging),__ reworked with more OOP (for first attempt look into "[Homework_02_OldVersion](https://github.com/Zsombi55/Homework_02_OldVersion)").

_As I understand the instructions:_ Make a simple error logger library, and a console application to test it that allows the user to create a vector then prints it out.

The ErrorLogger has to allow for the error messages to be written: in a text file, the console application's "console screen" and in Visual Studio's debug window using the `System.Diagnostics.Debugger` class. The mode to be used has to be set at the start of the application. The logger has to be part of a single class, where both the mode selection and the writing of error messages has to be abstract.

Two pieces of information will be required as arguments for the logger: an error/ importance level (eg.: 0 - Warning, 1 - High, 2 - Critical), and a `string` containing the error message itself.

* __A2 (TextTransformations),__ reworked with more OOP (for first attempt look into "[Homework_02_OldVersion](https://github.com/Zsombi55/Homework_02_OldVersion)").

_As I understand the instructions:_ Get a text from the User (eg.: `string`), and perform certain manipulations on it - using as much OOP as possible.

Minimal requested transformations: replace a User specified section with another User given `string`, remove a User specified section, insert a User given `string` to a specified position (`index`) in the text, turn all cases upper & lower, finally make 2 linked transformations each using at least 2 variations.

For the latter I linked a substring removal + case change, then a substring insertion + substring change.

* __A3 (ValidationEngine),__ done, with some help.

_As I understand the instructions:_

Have some preset test data: `People { Person1 { f.name, l.name, id.nr, age }, Person2 {..}, Person3 {..} }`.

Perform data validations on them: input is not null/empty, `id.nr` & `age` is number, `id.nr` is made up of a set of _13_ specific numbers in a certain order:

- male's start with 1, 3, 5 or 7 ; females start with 2, 4, 6 or 8 ;

- next 6 digits (2 for each) is year, month and day of birth,

- then 2 digits conforming for the county of residence,

- next 3 digits are the registration order number,

- finally the last digit is a security marker;

check wether `age` is below or over `18` 

"The Engine" has to use 0 or more rules to validate the data given to it resulting in a `boolean` .

Has to implement at least 2 validations with varying rule-sets, eg.: all people with valid names & id.nr above 18 years old, or all people with valid names & id.nr below 18 years old who are male.

* __A4 (Quizzer /QuizSystem),__ done.

_As I understand the instructions:_ Have a set of prepared questions with multiple possible answers stored. Have 2 sets of different combination of questions (taken from the database) ready to be listed for the User to complete. The question set is to be listed question after question, the User will introduce their chosen answer(s), finally the system prints out the results.

The following has to be supported:

- questions with only 1 correct choice from the presented possible answers' list,

- questions with multiple correct choices at the same time from the presented possible answers' list.

The questions' database definitions have to be able to contain at least the following :

- a key identifier (question id);

- a text description (question or instruction);

- a set of possible answers;

- the correct answer or set of answers (answer id).

> 20210215 ~ ????

* __A5 (??),__ soon.
