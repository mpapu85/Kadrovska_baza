using Kadrovska_baza.Models;

namespace Kadrovska_baza.Interface
{
    public interface ISexRepository
    {
        IList<Sex> GetAll();
        Sex GetById(int id);
        Sex Create(Sex sex);
        Sex Edit(Sex sex);
        Sex Delete(Sex sex);
    }
}
