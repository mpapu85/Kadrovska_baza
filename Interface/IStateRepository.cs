using Kadrovska_baza.Models;

namespace Kadrovska_baza.Interface
{
    public interface IStateRepository
    {
        IList<State> GetAll();
        State GetById(int id);
        State Create(State State);
        State Edit(State State);
        State Delete(State State);

    }
}
 