using Kadrovska_baza.Data;
using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.EntityFrameworkCore;

namespace Kadrovska_baza.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly ApplicationDbContext _context;
        public CityRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public City Create(City city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
            return city;
        }

        public City Delete(City city)
        {
            _context.Cities.Attach(city);
            _context.Entry(city).State = EntityState.Deleted;
            _context.SaveChanges();
            return city;
        }

        public IList<City> GetAll()
        {
            IList<City> city = _context.Cities.ToList();
            return city;
        }

        public City GetById(int id)
        {
            return _context.Cities.FirstOrDefault(x => x.Id == id);
        }

        public City Edit(City city)
        {
            _context.Cities.Attach(city);
            _context.Entry(city).State = EntityState.Modified;
            _context.SaveChanges();
            return city;
        }
    }
}
