using Kadrovska_baza.Data;
using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.EntityFrameworkCore;

namespace Kadrovska_baza.Repository
{
    public class EmploymentRepository : IEmploymentRepository
    {
        private readonly ApplicationDbContext _context;
        public EmploymentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Employment Create(Employment employment)
        {
            _context.Employments.Add(employment);
            _context.SaveChanges();
            return employment;
        }

        public Employment Delete(Employment employment)
        {
            _context.Employments.Attach(employment);
            _context.Entry(employment).State = EntityState.Deleted;
            _context.SaveChanges();
            return employment;
        }

        public IList<Employment> GetAll()
        {
            IList<Employment> employment = _context.Employments.ToList();
            return employment;
        }

        public Employment GetById(int id)
        {
            return _context.Employments.FirstOrDefault(e => e.Id == id);
        }

        public Employment Edit(Employment employment)
        {
            _context.Employments.Attach(employment);
            _context.Entry(employment).State = EntityState.Modified;
            _context.SaveChanges();
            return employment;
        }
    }
}
