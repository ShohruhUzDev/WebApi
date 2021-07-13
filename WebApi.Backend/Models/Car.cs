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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        public string Name { get; set; }


        [Column("color")]
        [Required]
        [MaxLength(20)]
        public string Color { get; set; }

        [ForeignKey("Person")]
       //[Column("person_id")]
        [Required]
       public int PersonId { get; set; }

       public Person Person { get; set; } 
    
    }
}
