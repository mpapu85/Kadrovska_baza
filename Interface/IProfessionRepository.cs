using Kadrovska_baza.Models;

namespace Kadrovska_baza.Interface
{
    public interface IProfessionRepository
    {
        IList<Profession> GetAll();
        Profession GetById(int id);
        Profession Create(Profession profession);
        Profession Edit(Profession profession);
        Profession Delete(Profession profession);
    }
}
