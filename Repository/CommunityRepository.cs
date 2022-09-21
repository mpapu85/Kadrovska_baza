using Kadrovska_baza.Data;
using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.EntityFrameworkCore;

namespace Kadrovska_baza.Repository
{
    public class CommunityRepository : ICommunityRepository
    {
        private readonly ApplicationDbContext _context;
        public CommunityRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Community Create(Community community)
        {
            _context.Communities.Add(community);
            _context.SaveChanges();
            return community;
        }

        public Community Delete(Community community)
        {
            _context.Communities.Attach(community);
            _context.Entry(community).State = EntityState.Deleted;
            _context.SaveChanges();
            return community;
        }

        public IList<Community> GetAll()
        {
            IList<Community> community = _context.Communities.ToList();
            return community;
        }

        public Community GetById(int id)
        {
            Community community = _context.Communities.FirstOrDefault(x => x.Id == id);
            return community;
        }

        public Community Edit(Community community)
        {
            _context.Communities.Attach(community);
            _context.Entry(community).State = EntityState.Modified;
            _context.SaveChanges();
            return community;
        }
    }
}
