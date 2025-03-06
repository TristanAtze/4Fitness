using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4FitnessConsole.Objects
{
    class PlanToExercise(int planId,
        int exerciseId)
    {
        public int PlanID { get; set; } = planId;

        public int ExerciseID { get; set; } = exerciseId;
    }
}
