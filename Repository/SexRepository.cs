using Kadrovska_baza.Data;
using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.EntityFrameworkCore;

namespace Kadrovska_baza.Repository
{
    public class SexRepository : ISexRepository
    {
        private readonly ApplicationDbContext _context;
        public SexRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Sex Create(Sex sex)
        {
            _context.Sexs.Add(sex);
            _context.SaveChanges();
            return sex;
        }

        public Sex Delete(Sex sex)
        {
            _context.Sexs.Attach(sex);
            _context.Entry(sex).State = EntityState.Deleted;
            _context.SaveChanges();
            return sex;
        }

        public IList<Sex> GetAll()
        {
            IList<Sex> sex = _context.Sexs.ToList();
            return sex;
        }

        public Sex GetById(int id)
        {
            Sex sex = _context.Sexs.FirstOrDefault(x => x.Id == id);
            return sex;
        }

        public Sex Edit(Sex sex)
        {
            _context.Sexs.Attach(sex);
            _context.Entry(sex).State = EntityState.Modified;
            _context.SaveChanges();
            return sex;
        }
    }
}
