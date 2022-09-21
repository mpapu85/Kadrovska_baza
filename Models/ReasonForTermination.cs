using System.ComponentModel.DataAnnotations;

namespace Kadrovska_baza.Models
{
    public class ReasonForTermination
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Razlog prestanka")]
        public string NameOfReasonForTermination { get; set; }

#nullable disable
        public IList<Employee> Employees { get; set; }
    }
}
