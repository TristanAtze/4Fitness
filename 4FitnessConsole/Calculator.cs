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



        public static (double, string) CalculateBMI()
        {
            bmi = weight / (height * height);
            string kategorie = bmi switch
            {
                < 18.5 => "Untergewicht",
                < 25 => "Normalgewicht",
                < 30 => "Übergewicht",
                _ => "Adipositas"
            };
            return (bmi, kategorie);
        }

        public static double CalculateProtein()
        {
            return goal switch
            {
                3 => weight * 2.2,
                0 => weight * 1.8,
                _ => weight * 1.5
            };
        }

        public static double BerechneKreatinDosis()
        {
            return experienceLevel switch
            {
                2 => weight * 0.04,
                1 => weight * 0.03,
                0 => weight * 0.02,
                _ => weight * 0,
            };
        }
        public static double CalculateCaloriNeed(Person person)
        {
            double grundumsatz = person.Geschlecht == "m"
                ? 66.47m + (13.7m * person.Gewicht) + (5m * person.Groesse * 100) - (6.8m * person.Alter)
                : 655.1m + (9.6m * person.Gewicht) + (1.8m * person.Groesse * 100) - (4.7m * person.Alter);

            return grundumsatz * person.Aktivitaet;
        }

    }
}
