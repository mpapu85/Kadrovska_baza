using Kadrovska_baza.Data;
using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.EntityFrameworkCore;

namespace Kadrovska_baza.Repository
{
    public class ProfessionRepository : IProfessionRepository
    {
        private readonly ApplicationDbContext _context;
        public ProfessionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Profession Create(Profession profession)
        {
            _context.Professions.Add(profession);
            _context.SaveChanges();
            return profession;
        }

        public Profession Delete(Profession profession)
        {
            _context.Professions.Attach(profession);
            _context.Entry(profession).State = EntityState.Deleted;
            _context.SaveChanges();
            return profession;
        }

        public IList<Profession> GetAll()
        {
            IList<Profession> profession = _context.Professions.ToList();
            return profession;
        }

        public Profession GetById(int id)
        {
            Profession profession = _context.Professions.FirstOrDefault(x => x.Id == id);
            return profession;
        }

        public Profession Edit(Profession profession)
        {
            _context.Professions.Attach(profession);
            _context.Entry(profession).State = EntityState.Modified;
            _context.SaveChanges();
            return profession;
        }
    }
}
