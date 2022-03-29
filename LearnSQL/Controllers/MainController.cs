using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnSQL.Models;

namespace LearnSQL.Controllers
{
    class MainController
    {
        public MainController()
        {
            StaticModels.Users = new List<User>();
            StaticModels.Stages = new List<Stage>();
            StaticModels.Materials = new List<Material>();
            StaticModels.Exercises = new List<Exercise>();
            StaticModels.MaterialsExercises = new List<MaterialExercise>();
        }
    }
}
