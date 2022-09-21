using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kadrovska_baza.Controllers
{
    public class ReasonForTerminationController : Controller
    {
        private readonly IReasonForTerminationRepository _reasonForTerminationRepository;
        public ReasonForTerminationController(IReasonForTerminationRepository reasonForTerminationRepository)
        {
            _reasonForTerminationRepository = reasonForTerminationRepository;
        }
        public IActionResult Index()
        {
            IList<ReasonForTermination> reasonForTermination = _reasonForTerminationRepository.GetAll();
            return View(reasonForTermination);
        }

        //Get
        public IActionResult Create()
        {
            ReasonForTermination reasonForTermination = new ReasonForTermination();
            return View(reasonForTermination);
        }

        //Post
        [HttpPost]
        public IActionResult Create(ReasonForTermination reasonForTermination)
        {
            try
            {
                reasonForTermination = _reasonForTerminationRepository.Create(reasonForTermination);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }


        //Get
        public IActionResult Edit(int id)
        {
            ReasonForTermination reasonForTermination = _reasonForTerminationRepository.GetById(id);
            return View(reasonForTermination);
        }

        //Post
        [HttpPost]
        public IActionResult Edit(ReasonForTermination reasonForTermination)
        {
            try
            {
                reasonForTermination = _reasonForTerminationRepository.Edit(reasonForTermination);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Delete(int id)
        {
            ReasonForTermination reasonForTermination = _reasonForTerminationRepository.GetById(id);
            return View(reasonForTermination);
        }

        //Post
        [HttpPost]
        public IActionResult Delete(ReasonForTermination reasonForTermination)
        {
            try
            {
                reasonForTermination = _reasonForTerminationRepository.Delete(reasonForTermination);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
