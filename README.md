# FTIT C-Sharp Homework Assignments, second batch

> 20210120 ~ 0203

* __A1 (ErrorLogging),__ reworked with more OOP (for first attempt look into "[Homework_02_OldVersion](https://github.com/Zsombi55/Homework_02_OldVersion)").

_As I understand the instructions:_ Make a simple error logger library, and a console application to test it that allows the user to create a vector then prints it out.

The ErrorLogger has to allow for the error messages to be written: in a text file, the console application's "console screen" and in Visual Studio's debug window using the `System.Diagnostics.Debugger` class. The mode to be used has to be set at the start of the application. The logger has to be part of a single class, where both the mode selection and the writing of error messages has to be abstract.

Two pieces of information will be required as arguments for the logger: an error/ importance level (eg.: 0 - Warning, 1 - High, 2 - Critical), and a `string` containing the error message itself.

* __A2 (TextTransformations),__ ***it is being reworked*** with more OOP (for first attempt look into (for first attempt look into "[Homework_02_OldVersion](https://github.com/Zsombi55/Homework_02_OldVersion)").

_As I understand the instructions:_ Get a text from the User (eg.: `string`), and perform certain manipulations on it - using as much OOP as possible.

Minimal requested transformations: replace a User specified section with another User given `string`, remove a User specified section, insert a User given `string` to a specified position (`index`) in the text, turn all cases upper & lower, finally make 2 linked transformations each using at least 2 variations.

For the latter I linked a substring removal + case change, then a substring insertion + substring change.

* __A3 (ValidationEngine),__ soon.

* __A4 (Quizzer),__ soon.
