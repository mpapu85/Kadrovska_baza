using Kadrovska_baza.Data;
using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.EntityFrameworkCore;

namespace Kadrovska_baza.Repository
{
    public class PositionRepository : IPositionRepository
    {
        private readonly ApplicationDbContext _context;
        public PositionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Position Create(Position position)
        {
            _context.Positions.Add(position);
            _context.SaveChanges();
            return position;
        }

        public Position Delete(Position position)
        {
            _context.Positions.Attach(position);
            _context.Entry(position).State = EntityState.Deleted;
            _context.SaveChanges();
            return position;
        }

        public IList<Position> GetAll()
        {
            IList<Position> position = _context.Positions.ToList();
            return position;
        }

        public Position GetById(int id)
        {
            Position position = _context.Positions.FirstOrDefault(x => x.Id == id);
            return position;
        }

        public Position Edit(Position position)
        {
            _context.Positions.Attach(position);
            _context.Entry(position).State = EntityState.Modified;
            _context.SaveChanges();
            return position;
        }
    }
}
