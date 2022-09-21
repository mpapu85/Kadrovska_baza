using System.ComponentModel.DataAnnotations;

namespace Kadrovska_baza.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "Ime grada")]
        public string NameOfCity { get; set; }


#nullable disable
        public IList<Employee> EmployeePlaceOfBirth { get; set; }
        public IList<Employee> EmployeePlaceOfResidence { get; set; }


    }
}
