using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4FitnessConsole.Objects
{
    class Recipe(int id,
        string name,
        byte[] imageBytes,
        double proteins,
        double calories,
        double fats,
        double carbohydrates,
        string[] ingredients,
        string manual)
    {
        public int ID { get; set; } = id;

        public string Name { get; set; } = name;

        public byte[] ImageBytes { get; set; } = imageBytes;

        public double Proteins { get; set; } = proteins;

        public double Calories { get; set; } = calories;

        public double Fats { get; set; } = fats;

        public double Carbohydrates { get; set; } = carbohydrates;

        public string[] Ingredients { get; set; } = ingredients;

        public string Manual { get; set; } = manual;
    }
}
