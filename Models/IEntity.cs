using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IEntity
    {
        public int Id { get; set; }

        //public DateTime InsertDateTime { get; set; }

    }
}
