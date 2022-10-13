using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Teacher : Person,IEntity
    {

        public int TeachingExperience { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}
