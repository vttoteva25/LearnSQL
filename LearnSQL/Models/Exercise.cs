using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSQL.Models
{
   public class Exercise
    {
        public int Id { get; set; }
        public string Problem { get; set; }
        public string Solution { get; set; }
        public Exercise(object id,object problem,object solution)
        {
            this.Id = (int)id;
            this.Problem = (string)problem;
            this.Solution = (string)solution;
        }
    }
}
