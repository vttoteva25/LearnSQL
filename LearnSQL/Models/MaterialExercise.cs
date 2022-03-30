namespace LearnSQL.Models
{
	public class MaterialExercise
    {
        public MaterialExercise(object matId, object exId)
        {
            this.MaterialId = (int)matId;
            this.ExerciseId = (int)exId;
        }

        public int MaterialId { get; set; }
        public Material Material { get; set; }

        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
    }
}
