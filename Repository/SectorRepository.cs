using Kadrovska_baza.Data;
using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.EntityFrameworkCore;

namespace Kadrovska_baza.Repository
{
    public class SectorRepository : ISectorRepository
    {
        private readonly ApplicationDbContext _context;
        public SectorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Sector Create(Sector sector)
        {
            _context.Sectors.Add(sector);
            _context.SaveChanges();
            return sector;
        }

        public Sector Delete(Sector sector)
        {
            _context.Sectors.Attach(sector);
            _context.Entry(sector).State = EntityState.Deleted;
            _context.SaveChanges();
            return sector;
        }

        public IList<Sector> GetAll()
        {
            IList<Sector> sector = _context.Sectors.ToList();
            return sector;
        }

        public Sector GetById(int id)
        {
            Sector sector = _context.Sectors.FirstOrDefault(x => x.Id == id);
            return sector;
        }

        public Sector Edit(Sector sector)
        {
            _context.Sectors.Attach(sector);
            _context.Entry(sector).State = EntityState.Modified;
            _context.SaveChanges();
            return sector;
        }
    }
}
