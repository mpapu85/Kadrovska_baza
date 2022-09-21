using Kadrovska_baza.Models;

namespace Kadrovska_baza.Interface
{
    public interface IOfficeRepository
    {
        IList<Office> GetAll();
        Office GetById(int id);
        Office Create(Office office);
        Office Edit(Office office);
        Office Delete(Office office);
    }
}
