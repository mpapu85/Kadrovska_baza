using Kadrovska_baza.Data;
using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.EntityFrameworkCore;

namespace Kadrovska_baza.Repository
{
    public class LevelOfEducationRepository : ILevelOfEducationRepository
    {
        private readonly ApplicationDbContext _context;
        public LevelOfEducationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public LevelOfEducation Create(LevelOfEducation level)
        {
            _context.LevelOfEducations.Add(level);
            _context.SaveChanges();
            return level;
        }

        public LevelOfEducation Delete(LevelOfEducation level)
        {
            _context.LevelOfEducations.Attach(level);
            _context.Entry(level).State = EntityState.Deleted;
            _context.SaveChanges();
            return level;
        }

        public IList<LevelOfEducation> GetAll()
        {
            IList<LevelOfEducation> level = _context.LevelOfEducations.ToList();
            return level;
        }

        public LevelOfEducation GetById(int id)
        {
            LevelOfEducation level = _context.LevelOfEducations.FirstOrDefault(s => s.Id == id);
            return level;
        }

        public LevelOfEducation Edit(LevelOfEducation level)
        {
            _context.LevelOfEducations.Attach(level);
            _context.Entry(level).State = EntityState.Modified;
            _context.SaveChanges();
            return level;
        }
    }
}
