using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kadrovska_baza.Controllers
{
    public class ProfessionController : Controller
    {
        private readonly IProfessionRepository _professionRepository;
        public ProfessionController(IProfessionRepository professionRepository)
        {
            _professionRepository = professionRepository;
        }
        public IActionResult Index()
        {
            IList<Profession> profession = _professionRepository.GetAll();
            return View(profession);
        }

        //Get
        public IActionResult Create()
        {
            Profession profession = new Profession();
            return View(profession);
        }

        //Post
        [HttpPost]
        public IActionResult Create(Profession profession)
        {
            try
            {
                profession = _professionRepository.Create(profession);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Edit(int Id)
        {
            Profession profession = _professionRepository.GetById(Id);
            return View(profession);
        }

        //Post
        [HttpPost]
        public IActionResult Edit(Profession profession)
        {
            try
            {
                profession = _professionRepository.Edit(profession);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Delete(int Id)
        {
            Profession profession = _professionRepository.GetById(Id);
            return View(profession);
        }

        //Post
        [HttpPost]
        public IActionResult Delete(Profession profession)
        {
            try
            {
                profession = _professionRepository.Delete(profession);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
