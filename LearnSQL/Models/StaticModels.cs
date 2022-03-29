using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSQL.Models
{
    public static class StaticModels
    {
        public static List<User> Users { get; set; }
        public static List<Stage> Stages { get; set; }
        public static List<Material> Materials { get; set; }
        public static List<Exercise> Exercises { get; set; }
        public static List<MaterialExercise> MaterialsExercises { get; set; }

    }
}
