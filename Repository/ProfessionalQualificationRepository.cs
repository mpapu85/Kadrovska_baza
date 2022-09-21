using Kadrovska_baza.Data;
using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.EntityFrameworkCore;

namespace Kadrovska_baza.Repository
{
    public class ProfessionalQualificationRepository : IProfessionalQualificationRepository
    {
        private readonly ApplicationDbContext _context;
        public ProfessionalQualificationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ProfessionalQualification Create(ProfessionalQualification qualifications)
        {
            _context.ProfessionalQualifications.Add(qualifications);
            _context.SaveChanges();
            return qualifications;
        }

        public ProfessionalQualification Delete(ProfessionalQualification qualifications)
        {
            _context.ProfessionalQualifications.Attach(qualifications);
            _context.Entry(qualifications).State = EntityState.Deleted;
            _context.SaveChanges();
            return qualifications;
        }

        public IList<ProfessionalQualification> GetAll()
        {
            IList<ProfessionalQualification> qualifications = _context.ProfessionalQualifications.ToList();
            return qualifications;
        }

        public ProfessionalQualification GetById(int id)
        {
            ProfessionalQualification qualifications = _context.ProfessionalQualifications.FirstOrDefault(x => x.Id == id);
            return qualifications;
        }

        public ProfessionalQualification Edit(ProfessionalQualification qualifications)
        {
            _context.ProfessionalQualifications.Attach(qualifications);
            _context.Entry(qualifications).State = EntityState.Modified;
            _context.SaveChanges();
            return qualifications;
        }
    }
}
