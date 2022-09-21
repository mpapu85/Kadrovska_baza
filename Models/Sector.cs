using System.ComponentModel.DataAnnotations;

namespace Kadrovska_baza.Models
{
    public class Sector
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name ="Naziv Sektora")]
        public string NameOfSector { get; set; }


#nullable disable
        public IList<Employee> Employees { get; set; }


    }
}
