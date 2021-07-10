using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Backend.Models
{
    [Table("car")]
    public class Car
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        [MaxLength(20)]
        public string  Name { get; set; }


        [Column("color")]
        [Required]
        [MaxLength(20)]
        public string  Color { get; set; }
        public int? PersonId { get; set; }
        public Person Person { get; set; }



    }
}
