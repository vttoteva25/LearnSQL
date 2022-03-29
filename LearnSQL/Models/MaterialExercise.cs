using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSQL.Models
{
    public class MaterialExercise
    {
        public int MaterialId { get; set; }
        public int ExerciseId { get; set; }
        public Material Material { get; set; }
        public Exercise Exercise { get; set; }
        public MaterialExercise(object matId,object exId)
        {
            this.MaterialId = (int)matId;
            this.ExerciseId =(int) exId;
        }
    }
}
