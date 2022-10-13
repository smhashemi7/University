using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student : Person, IEntity
    {
        public DateTime? EntryDate { get; set; }

        [MaxLength(12)]
        public string? StudentCode { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
