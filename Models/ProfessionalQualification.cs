using System.ComponentModel.DataAnnotations;

namespace Kadrovska_baza.Models
{
    public class ProfessionalQualification
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "Stručna sprema")]
        public string NameOfProfessionalQualification { get; set; }


#nullable disable
        public IList<Employee> Employees { get; set; }


    }
}
