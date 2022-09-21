using System.ComponentModel.DataAnnotations;

namespace Kadrovska_baza.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        [Required, Display(Name ="Država"), StringLength(50)]
        public string NameOfState { get; set; }

#nullable disable
        public IList<Employee> Employees { get; set; }
    }
}
