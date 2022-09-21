using Kadrovska_baza.Data;
using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.EntityFrameworkCore;

namespace Kadrovska_baza.Repository
{
    public class OfficeRepository : IOfficeRepository
    {
        private readonly ApplicationDbContext _context;
        public OfficeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Office Create(Office office)
        {
            _context.Offices.Add(office);
            _context.SaveChanges();
            return office;
        }

        public Office Delete(Office office)
        {
            _context.Offices.Attach(office);
            _context.Entry(office).State = EntityState.Deleted;
            _context.SaveChanges();
            return office;
        }

        public IList<Office> GetAll()
        {
            IList<Office> office = _context.Offices.ToList();
            return office;
        }

        public Office GetById(int id)
        {
            Office office = _context.Offices.FirstOrDefault(x => x.Id == id);
            return office;
        }

        public Office Edit(Office office)
        {
            _context.Offices.Attach(office);
            _context.Entry(office).State = EntityState.Modified;
            _context.SaveChanges();
            return office;
        }
    }
}
