using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Backend.Models
{
    [Table("person")]
    public class Person
    {
        [Key]
        [Required]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Column("firstname")]
        [Required]
       [MaxLength(20)]
        public string  FirstName { get; set; }

        [Column("lasttname")]
        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Column("phone")]
        [Required]
       
        public string Phone { get; set; }

        public List<Car> Cars { get; set; }

    }
}
