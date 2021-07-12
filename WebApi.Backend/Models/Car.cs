using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Backend.Models
{
    [Table("car")]
    public class Car
    {

        [Required]
        [Column("id")]

        public int Id { get; set; }

        [Column("name")]
        [Required]
        public string Name { get; set; }


        [Column("color")]
        [Required]
        [MaxLength(20)]
        public string Color { get; set; }

            [Column("person_id")]
            [Required]
            public int PersonId { get; set; }


    
    }
}
