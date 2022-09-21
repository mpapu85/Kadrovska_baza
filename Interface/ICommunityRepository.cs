using Kadrovska_baza.Models;

namespace Kadrovska_baza.Interface
{
    public interface ICommunityRepository
    {
        IList<Community> GetAll();
        Community GetById(int id);
        Community Create(Community community);
        Community Edit(Community community);
        Community Delete(Community community);
    }
}
