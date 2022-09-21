using Kadrovska_baza.Models;

namespace Kadrovska_baza.Interface
{
    public interface IEmploymentRepository
    {
        IList<Employment> GetAll();
        Employment GetById(int id);
        Employment Create(Employment employment);
        Employment Edit(Employment employment);
        Employment Delete(Employment employment);
    }
}
