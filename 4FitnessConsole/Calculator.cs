using BasicProgram.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    static class Calculator
    {
        private static double weight = 88;
        private static double height = 189;
        private static double age = 17;
        private static bool isMale = true; 
        private static int activityLevel = 1; // 0 = sedentary, 1 = light, 2 = moderate, 3 = very active
        private static int goal = 0; // 0 = lose weight, 1 = maintain weight, 2 = gain weight, 3 = build muscle
        private static int experienceLevel = 0; // 0 = beginner, 1 = intermediate, 2 = advanced
        private static double protein = 2.2;
        private static double bmi = 0;
        private static double bmr = 0;


        
        public static (double, string) CalculateBMI(Person person)
        {
            bmi = person.Weight / ((person.Height * person.Height) / 10000);
            string kategorie = bmi switch
            {
                < 18.5 => "Untergewicht",
                < 25 => "Normalgewicht",
                < 30 => "Übergewicht",
                _ => "Adipositas"
            };
            return (bmi, kategorie);

            //todo Alter und Geschlecht mit einbeziehen
        }

        public static double CalculateProtein(Person person)
        {
            return person.Goal.Item1 switch
            {
                Person.GoalEnum.MuskelnAufbauen => person.Weight * 2.2,
                Person.GoalEnum.Abnehmen => person.Weight * 1.8,
                _ => person.Weight * 1.5
            };
        }

        public static double CalculateKreatin(Person person)
        {
            return person.Experience switch
            {
                Person.ExpEnum.Advanced => person.Weight * 0.04,
                Person.ExpEnum.Intermediate => person.Weight * 0.037,
                Person.ExpEnum.Beginner => person.Weight * 0.035,
                _ => person.Weight * 0,
            };
        }
        public static double CalculateCaloriNeed(Person person)
        {
            // Grundumsatz berechnen
            double grundumsatz = person.Gender == Person.GenderEnum.Male
                ? 66.47 + (13.7 * person.Weight) + (5 * person.Height) - (6.8 * person.Age)
                : 655.1 + (9.6 * person.Weight) + (1.8 * person.Height) - (4.7 * person.Age);

            // Aktivitätslevel berücksichtigen
            double aktivitaetsFaktor = GetActivityMultiplier(person.Activity);
            double erhaltungsKalorien = grundumsatz * aktivitaetsFaktor;

            // Ziel berücksichtigen (7700 kcal ≈ 1 kg Körpergewicht)
            var (goal, zielWert) = person.Goal;
            double zielAnpassung = 0;

            if (goal == Person.GoalEnum.Abnehmen)
            {
                double abnahmeProWoche = zielWert ?? 0.5; // Standardwert 0.5 kg/Woche
                zielAnpassung = -abnahmeProWoche * 1100; // 7700 kcal/Woche / 7 Tage
            }
   
            return erhaltungsKalorien + zielAnpassung;
        }

        private static double GetActivityMultiplier(Person.ActEnum activity)
        {
            return activity switch
            {
                Person.ActEnum.sedentary => 1.2,
                Person.ActEnum.light => 1.375,
                Person.ActEnum.moderate => 1.55,
                Person.ActEnum.active => 1.725,
                _ => 1
            };
        }

    }
}
