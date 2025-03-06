using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4FitnessConsole.Objects
{
    class TrainingPlan(int id,
        int personId,
        TrainingExercise[] content)
    {
        public int ID { get; set; } = id;

        public int PersonID { get; set; } = personId;

        public TrainingExercise[] Content { get; set; } = content;
    }
}
