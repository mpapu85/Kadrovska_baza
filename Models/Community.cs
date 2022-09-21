using System.ComponentModel.DataAnnotations;

namespace Kadrovska_baza.Models
{
    public class Community
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "Naziv opštine")]
        public string NameOfComminuty { get; set; }

#nullable disable
        public IList<Employee> EmployeeCommunityOfBirth { get; set; }
        public IList<Employee> EmployeeCommunityOfResidence { get; set; }
    }
}
