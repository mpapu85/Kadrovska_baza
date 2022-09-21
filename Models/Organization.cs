using System.ComponentModel.DataAnnotations;

namespace Kadrovska_baza.Models
{
    public class Organization
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name ="Naziv organizacije")]
        public string NameOfOrganization { get; set; }

#nullable disable
        public IList<Employee> Employees { get; set; }

    }
}
