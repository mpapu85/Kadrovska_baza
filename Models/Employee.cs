using Kadrovska_baza.Data;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kadrovska_baza.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Profilna slika")]
        public string PictureURL { get; set; }

                
        //Lični podaci 

        [Required]
        [StringLength(50), Display(Name = "Ime")]
        public string Name { get; set; }


        [Required]
        [StringLength(50), Display(Name = "Prezime")]
        public string LastName { get; set; }


        [StringLength(50)]
        [Display(Name = "Ime oca")]
        public string FatherName { get; set; }


        [Display(Name = "JMBG")]
        [Remote(action: "UniqueSocialSecurityNumber", controller: "Employee")]
        [Required, StringLength(13, MinimumLength = 13, ErrorMessage = "JMBG mora da sadrži 13 cifara")]
        public string SocialSecurityNumber { get; set; }


        //Podaci o rođenju

        [Required]
        [Display(Name = "Datum rođenja")]
        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }


        [Required, Display(Name = "Država Rođenja"), ForeignKey("State")]
        public int StateId { get; set; }


        [Required, Display(Name = "Mesto rođenja"), ForeignKey("PlaceOfBirthId")]
        public int PlaceOfBirthId { get; set; }


        [Required, Display(Name = "Opština rođenja"), ForeignKey("CommunityOfBirthId")]
        public int CommunityOfBirthId { get; set; }


        //Podaci o mestu stanovanja

        [Required, Display(Name = "Mesto stanovnja"), ForeignKey("PlaceOfResidenceId")]
        public int PlaceOfResidenceId { get; set; }


        [Required, Display(Name = "Opština stanovanja"), ForeignKey("CommunityOfResidenceId")]
        public int CommunityOfResidenceId { get; set; }


        [Required, Display(Name = "Adresa stanovanja"), StringLength(100)]
        public string Address { get; set; }


        //Podaci o stručnoj spremi

        [Required, Display(Name = "Stepen obrazovanja"), ForeignKey("LevelOfEducation")]
        public int LevelOfEducationId { get; set; }


        [Required, Display(Name = "Stručna sprema"), ForeignKey("ProfessionalQualification")]
        public int ProfessionalQualificationId { get; set; }


        [Required, Display(Name = "Zanimanje"), ForeignKey("Profession")]
        public int ProfessionId { get; set; }


        //Podaci o zaposlenju

        [Required, Display(Name = "Datum početka rada")]
        [DataType(DataType.Date)]
        public string StartOfWork { get; set; }


        [Required, Display(Name = "Organizacija"), ForeignKey("Organization")]
        public int OrganizationID { get; set; }


        [Display(Name = "Sektor"), ForeignKey("Sector")]
        public int SectorId { get; set; }


        [Required, Display(Name = "Služba"), ForeignKey("Office")]
        public int OfficeId { get; set; }


        [Required, Display(Name = "Pozicija"), ForeignKey("Position")]
        public int PositionId { get; set; }


        [Required, Display(Name = "Datum premeštaja")]
        [DataType(DataType.Date)]
        public string DateOfTransfer { get; set; }


        [Required, Display(Name = "Radni odnos"), ForeignKey("Employment")]
        public int EmploymentId { get; set; }


        [Required, ForeignKey("ReasonForTermination"), Display(Name ="Razlog prestanka")]
        public int ReasonForTerminationId { get; set; }


        [Display(Name = "Pol"), ForeignKey("Sex")]
        public int SexId { get; set; }


        //Relaionship
#nullable disable

        [Display(Name ="Grad rođenja")]
        public virtual City PlaceOfBirth { get; set; }

        [Display(Name = "Grad stanovanja")]
        public virtual City PlaceOfResidence { get; set; }

        [Display(Name = "Opština rođenja")]
        public virtual Community CommunityOfBirth { get; set; }

        [Display(Name = "Opština stanovanja")]
        public virtual Community CommunityOfResidence { get; set; }

        [Display(Name = "Stepen obrazovanja")]
        public virtual LevelOfEducation LevelOfEducation { get; set; }

        [Display(Name = "Stručna sprema")]
        public virtual ProfessionalQualification ProfessionalQualification { get; set; }

        [Display(Name = "Zanimanje")]
        public virtual Profession Profession { get; set; }

        [Display(Name = "Organizacija")]
        public virtual Organization Organization { get; set; }

        [Display(Name = "Sektor")]
        public virtual Sector Sector { get; set; }

        [Display(Name = "Služba")]
        public virtual Office Office { get; set; }

        [Display(Name = "Pozicija")]
        public virtual Position Position { get; set; }

        [Display(Name = "Država")]
        public virtual State State { get; set; }

        [Display(Name ="Radni odnos")]
        public virtual Employment Employment { get; set; }

        [Display(Name = "Razlog prestanka")]
        public virtual ReasonForTermination ReasonForTermination { get; set; }

        [Display(Name = "Pol")]
        public virtual Sex Sex { get; set; }



    }

    
}
