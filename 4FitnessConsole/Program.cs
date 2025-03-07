using BasicProgram;
using BasicProgram.Objects;

var person = new Person(88,189,17,Person.GenderEnum.Male, Person.ExpEnum.Intermediate, Person.ActEnum.moderate, (Person.GoalEnum.MuskelnAufbauen, 0.3));

(double, string) bmi = Calculator.CalculateBMI(person);
Console.WriteLine($"BMI: {bmi.Item1} - {bmi.Item2}");
double protein = Calculator.CalculateProtein(person);
Console.WriteLine($"Proteinbedarf: {protein} g");
double kreatin = Calculator.CalculateKreatin(person);
Console.WriteLine($"Kreatinbedarf: {kreatin} g");
double kalorien = Calculator.CalculateCaloriNeed(person);
Console.WriteLine($"Kalorienbedarf: {kalorien} kcal");
Console.ReadKey();