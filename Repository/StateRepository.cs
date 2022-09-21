using Kadrovska_baza.Data;
using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.EntityFrameworkCore;

namespace Kadrovska_baza.Repository
{
    public class StateRepository : IStateRepository
    {
        private readonly ApplicationDbContext _context;
        public StateRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public State Create(State State)
        {
            _context.States.Add(State);
            _context.SaveChanges();
            return State;
        }

        public State Delete(State State)
        {
            _context.States.Attach(State);
            _context.Entry(State).State = EntityState.Deleted;
            _context.SaveChanges();
            return State;
        }

        public IList<State> GetAll()
        {
            IList<State> States = _context.States.ToList();
            return States;
        }

        public State GetById(int id)
        {
            return _context.States.FirstOrDefault(e => e.Id == id);
        }

        public State Edit(State State)
        {
            _context.States.Attach(State);
            _context.Entry(State).State = EntityState.Modified;
            _context.SaveChanges();
            return State;
        }
    }
}
