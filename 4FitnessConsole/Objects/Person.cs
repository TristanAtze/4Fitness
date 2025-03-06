using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4FitnessConsole.Objects
{
    class Person
    {
        public double Weight { get; set; }

        public double Height { get; set; }

        public int Age { get; set; }

        public GenderEnum Gender { get; set; }

        public ExpEnum Experience { get; set; }

        public ActEnum Activity { get; set; }

        public (GoalEnum, double?) Goal { get; set; }

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
            Zunehmen,
            MuskelnAufbauen
        }
    }
}
