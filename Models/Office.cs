using System.ComponentModel.DataAnnotations;

namespace Kadrovska_baza.Models
{
    public class Office
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "Naziv službe")]
        public string NameOfOffice { get; set; }


#nullable disable
        public IList<Employee> Employees { get; set; }

    }
}
