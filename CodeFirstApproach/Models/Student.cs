using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Models
{
    public class Student
    {
        [Key]
        public int? Id { get; set; }
        [Column("StudentName",TypeName="varchar(50)")]
        public string Name { get; set; }
        [Column("StrudentEmail",TypeName ="varchar(50)")]
        public string Email { get; set; }
        public int Age { get; set; }

    }
}
