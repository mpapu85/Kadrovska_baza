using Kadrovska_baza.Models;

namespace Kadrovska_baza.Interface
{
    public interface ILevelOfEducationRepository
    {
        IList<LevelOfEducation> GetAll();
        LevelOfEducation GetById(int id);
        LevelOfEducation Create(LevelOfEducation level);
        LevelOfEducation Edit(LevelOfEducation level);
        LevelOfEducation Delete(LevelOfEducation level);
    }
}
