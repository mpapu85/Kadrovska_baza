using Kadrovska_baza.Data;
using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.EntityFrameworkCore;

namespace Kadrovska_baza.Repository
{
    public class OrganizationRepository : IOrganizationRepository
    {
        private readonly ApplicationDbContext _context;
        public OrganizationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Organization Create(Organization organization)
        {
            _context.Organizations.Add(organization);
            _context.SaveChanges();
            return organization;
        }

        public Organization Delete(Organization organization)
        {
            _context.Organizations.Attach(organization);
            _context.Entry(organization).State = EntityState.Deleted;
            _context.SaveChanges();
            return organization;
        }

        public IList<Organization> GetAll()
        {
            IList<Organization> organization = _context.Organizations.ToList();
            return organization;
        }

        public Organization GetById(int id)
        {
            Organization organization = _context.Organizations.FirstOrDefault(x => x.Id == id);
            return organization;
        }

        public Organization Edit(Organization organization)
        {
            _context.Organizations.Attach(organization);
            _context.Entry(organization).State = EntityState.Modified;
            _context.SaveChanges();
            return organization;
        }
    }
}
