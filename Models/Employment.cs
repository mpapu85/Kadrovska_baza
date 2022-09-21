using System.ComponentModel.DataAnnotations;

namespace Kadrovska_baza.Models
{
    public class Employment
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "Radni odnos")]
        public string NameOfEmployment { get; set; }


#nullable disable
        public IList<Employee> Employees { get; set; }


    }
}
