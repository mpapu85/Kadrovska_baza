using Kadrovska_baza.Models;

namespace Kadrovska_baza.Interface
{
    public interface IReasonForTerminationRepository
    {
        IList<ReasonForTermination> GetAll();
        ReasonForTermination GetById(int id);
        ReasonForTermination Create(ReasonForTermination reasonForTermination);
        ReasonForTermination Edit(ReasonForTermination reasonForTermination);
        ReasonForTermination Delete(ReasonForTermination reasonForTermination);
    }
}
