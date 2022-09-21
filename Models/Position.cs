using System.ComponentModel.DataAnnotations;

namespace Kadrovska_baza.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name ="Naziv poslova")]
        public string NameOfPosition { get; set; }


#nullable disable
        public IList<Employee> Employees { get; set; }


    }
}
