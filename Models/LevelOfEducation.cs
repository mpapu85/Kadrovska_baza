using System.ComponentModel.DataAnnotations;

namespace Kadrovska_baza.Models
{
    public class LevelOfEducation
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "Stepen stručne spreme")]
        public string NameOfLevelOfEducation { get; set; }


#nullable disable
        public IList<Employee> Employees { get; set; }

    }
}
