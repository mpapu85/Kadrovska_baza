using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kadrovska_baza.Controllers
{
    public class ProfessionalQualificationController : Controller
    {
        private readonly IProfessionalQualificationRepository _professionalQualificationRepository;
        public ProfessionalQualificationController(IProfessionalQualificationRepository professionalQualificationRepository)
        {
            _professionalQualificationRepository = professionalQualificationRepository;
        }
        public IActionResult Index()
        {
            IList<ProfessionalQualification> qualifications = _professionalQualificationRepository.GetAll();
            return View(qualifications);
        }

        //Get
        public IActionResult Create()
        {
            ProfessionalQualification qualifications = new ProfessionalQualification();
            return View(qualifications);
        }

        //Post
        [HttpPost]
        public IActionResult Create(ProfessionalQualification qualifications)
        {
            try
            {
                qualifications = _professionalQualificationRepository.Create(qualifications);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Edit(int id)
        {
            ProfessionalQualification qualifications = _professionalQualificationRepository.GetById(id);
            return View(qualifications);
        }

        //Post
        [HttpPost]
        public IActionResult Edit(ProfessionalQualification qualifications)
        {
            try
            {
                qualifications = _professionalQualificationRepository.Edit(qualifications);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Delete(int id)
        {
            ProfessionalQualification qualifications = _professionalQualificationRepository.GetById(id);
            return View(qualifications);
        }

        //Post
        [HttpPost]
        public IActionResult Delete(ProfessionalQualification qualifications)
        {
            try
            {
                qualifications = _professionalQualificationRepository.Delete(qualifications);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
