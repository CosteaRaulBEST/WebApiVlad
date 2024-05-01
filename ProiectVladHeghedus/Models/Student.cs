using System.ComponentModel.DataAnnotations;

namespace ProiectVladHeghedus.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Sex { get; set; }

        [Required]
        public int Year { get; set; }
    }
}
