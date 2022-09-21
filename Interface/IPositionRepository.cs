using Kadrovska_baza.Models;

namespace Kadrovska_baza.Interface
{
    public interface IPositionRepository
    {
        IList<Position> GetAll();
        Position GetById(int id);
        Position Create(Position position);
        Position Edit(Position position);
        Position Delete(Position position);
    }
}
