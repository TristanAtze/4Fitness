using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4FitnessConsole.Objects
{
    class TrainingExercise(int id,
        string name,
        int repetitions,
        int sets,
        string difficulty,
        string explanation)
    {
        public int ID { get; set; } = id;

        public string Name { get; set; } = name;

        public int Repetitions { get; set; } = repetitions;

        public int Sets { get; set; } = sets;

        public string Difficulty { get; set; } = difficulty;

        public string Explanation { get; set; } = explanation;
    }
}
