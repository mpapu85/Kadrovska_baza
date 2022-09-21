using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kadrovska_baza.Controllers
{
    public class EmploymentController : Controller
    {
        private readonly IEmploymentRepository _employmentRepository;
        public EmploymentController(IEmploymentRepository employmentRepository)
        {
            _employmentRepository = employmentRepository;
        }
        public IActionResult Index()
        {
            IList<Employment> employment = _employmentRepository.GetAll();
            return View(employment);
        }

        //Get
        public IActionResult Create()
        {
            Employment employment = new Employment();
            return View(employment);
        }

        //Post
        [HttpPost]
        public IActionResult Create(Employment employment)
        {
            try
            {
                employment = _employmentRepository.Create(employment);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }


        //Get
        public IActionResult Edit(int id)
        {
            Employment employment = _employmentRepository.GetById(id);
            return View(employment);
        }

        //Post
        [HttpPost]
        public IActionResult Edit(Employment employment)
        {
            try
            {
                employment = _employmentRepository.Edit(employment);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Delete(int id)
        {
            Employment employment = _employmentRepository.GetById(id);
            return View(employment);
        }

        //Post
        [HttpPost]
        public IActionResult Delete(Employment employment)
        {
            try
            {
                employment = _employmentRepository.Delete(employment);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
