using System.ComponentModel.DataAnnotations;

namespace Kadrovska_baza.Models
{
    public class Profession
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name ="Zanimanje")]
        public string NameOfProfession { get; set; }


#nullable disable
        public IList<Employee> Employees { get; set; }


    }
}
