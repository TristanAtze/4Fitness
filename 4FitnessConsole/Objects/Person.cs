using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram.Objects
{
    public class Person
    {
        public int ID { get; set; }

        public int AccountID { get; set; }

        public string Name { get; set; }

        public double Weight { get; set; }

        public double Height { get; set; }

        public int Age { get; set; }

        public GenderEnum Gender { get; set; }

        public ExpEnum Experience { get; set; }

        public ActEnum Activity { get; set; }

        public (GoalEnum, double?) Goal { get; set; }

        public string Password { get; set; }

        public string EMail { get; set; }

        public enum GenderEnum
        {
            Male = 1,
            Female = 2
        }

        public enum ExpEnum
        {
            Beginner = 1,
            Intermediate = 2,
            Advanced = 3
        }

        public enum ActEnum
        {
            sedentary = 1,
            light = 2,
            moderate = 3,
            active = 4
        }

        public enum GoalEnum
        {
            Abnehmen,
            GewichtHalten,
            Zunehmen,
            MuskelnAufbauen
        }

        public Person(int id, int accountId, string name, double weight, double height, int age, GenderEnum gender,
             string password, string email,
             ExpEnum experience = ExpEnum.Beginner,
             ActEnum activity = ActEnum.sedentary,
             (GoalEnum, double?)? goal = null)
        {
            // Pflichtfelder Validierung
            if (weight <= 0)
                throw new ArgumentException("Gewicht muss größer als 0 sein", nameof(weight));

            if (height <= 0)
                throw new ArgumentException("Größe muss größer als 0 sein", nameof(height));

            if (age <= 0)
                throw new ArgumentException("Alter muss größer als 0 sein", nameof(age));

            // Werte zuweisen
            ID = id;
            AccountID = accountId;
            Name = name;
            Weight = weight;
            Height = height;
            Age = age;
            Gender = gender;
            Experience = experience;
            Activity = activity;
            Goal = goal ?? (GoalEnum.GewichtHalten, null);
            Password = password;
            EMail = email;
        }
    }
}
