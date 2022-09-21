using Kadrovska_baza.Models;

namespace Kadrovska_baza.Interface
{
    public interface ICityRepository
    {
        IList<City> GetAll();
        City GetById(int id);
        City Create(City city);
        City Edit(City city);
        City Delete(City city);
    }
}
