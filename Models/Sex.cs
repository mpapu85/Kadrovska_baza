using System.ComponentModel.DataAnnotations;

namespace Kadrovska_baza.Models
{
    public class Sex
    {
        [Key]
        public int Id { get; set; }
        [Required, Display(Name = "Pol"), StringLength(15)]
        public string NameOfSex { get; set; }

#nullable disable
        public IList<Employee> Employees { get; set; }
    }
}
