using BasicProgram;
using BasicProgram.Objects;

var person = new Person(88,189,17,Person.GenderEnum.Male, Person.ExpEnum.Intermediate, Person.ActEnum.moderate, (Person.GoalEnum.MuskelnAufbauen, null));

double kalorien = Calculator.CalculateCaloriNeed(person); 