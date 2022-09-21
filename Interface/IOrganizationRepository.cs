using Kadrovska_baza.Models;

namespace Kadrovska_baza.Interface
{
    public interface IOrganizationRepository
    {
        IList<Organization> GetAll();
        Organization GetById(int id);
        Organization Create(Organization organization);
        Organization Edit(Organization organization); 
        Organization Delete(Organization organization);
    }
}
