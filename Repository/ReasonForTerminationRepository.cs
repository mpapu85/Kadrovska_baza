using Kadrovska_baza.Data;
using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.EntityFrameworkCore;

namespace Kadrovska_baza.Repository
{
    public class ReasonForTerminationRepository : IReasonForTerminationRepository
    {
        private readonly ApplicationDbContext _context;
        public ReasonForTerminationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public ReasonForTermination Create(ReasonForTermination reasonForTermination)
        {
            _context.ReasonForTerminations.Add(reasonForTermination);
            _context.SaveChanges();
            return reasonForTermination;
        }

        public ReasonForTermination Delete(ReasonForTermination reasonForTermination)
        {
            _context.ReasonForTerminations.Attach(reasonForTermination);
            _context.Entry(reasonForTermination).State = EntityState.Deleted;
            _context.SaveChanges();
            return reasonForTermination;
        }

        public ReasonForTermination Edit(ReasonForTermination reasonForTermination)
        {
            _context.ReasonForTerminations.Attach(reasonForTermination);
            _context.Entry(reasonForTermination).State = EntityState.Modified;
            _context.SaveChanges();
            return reasonForTermination;
        }

        public IList<ReasonForTermination> GetAll()
        {
            IList<ReasonForTermination> reasonForTermination = _context.ReasonForTerminations.ToList();
            return reasonForTermination;
        }

        public ReasonForTermination GetById(int id)
        {
            ReasonForTermination reasonForTermination = _context.ReasonForTerminations.FirstOrDefault(x=>x.Id== id);
            return reasonForTermination;
        }
    }
}
