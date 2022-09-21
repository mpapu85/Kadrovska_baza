using Kadrovska_baza.Models;

namespace Kadrovska_baza.Interface
{
    public interface ISectorRepository
    {
        IList<Sector> GetAll();
        Sector GetById(int id);
        Sector Create(Sector sector);
        Sector Edit(Sector sector);
        Sector Delete(Sector sector);
    }
}
