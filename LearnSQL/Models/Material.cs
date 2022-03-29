using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSQL.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Theroy { get; set; }
        public int StageId { get; set; }
        public Stage Stage { get; set; }
        public Material(object id,object theory,object stageid)
        {
            this.Id = (int)id;
            this.Theroy = (string)theory;
            this.StageId = (int)stageid;
        }

    }
}
