using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Models
{
    public abstract class Person : IEntity
    {
        [Column(Order = 1)]
        public int Id { get; set; }

        [Column(Order = 2)]
        [MaxLength(50)]
        [MinLength(2)]
        [Required]
        public string FirstName { get; set; }

        [Column(Order = 3)]
        [MaxLength(50)]
        [MinLength(2)]
        [Required]
        public string LastName { get; set; }


        //public void GetData()
        //{
        //    Console.WriteLine("he");
        //}

    }
}