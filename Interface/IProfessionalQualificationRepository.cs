using Kadrovska_baza.Models;

namespace Kadrovska_baza.Interface
{
    public interface IProfessionalQualificationRepository
    {
        IList<ProfessionalQualification> GetAll();
        ProfessionalQualification GetById(int id);
        ProfessionalQualification Create(ProfessionalQualification professionalQualification);
        ProfessionalQualification Edit(ProfessionalQualification professionalQualification);
        ProfessionalQualification Delete(ProfessionalQualification professionalQualification);
    }
}
