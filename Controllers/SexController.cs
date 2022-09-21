using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kadrovska_baza.Controllers
{
    public class SexController : Controller
    {
        private readonly ISexRepository _sexRepository;
        public SexController(ISexRepository sexRepository)
        {
            _sexRepository = sexRepository;
        }
        public IActionResult Index()
        {
            IList<Sex> sex = _sexRepository.GetAll();
            return View(sex);
        }

        //Get
        public IActionResult Create()
        {
            Sex sex = new Sex();
            return View(sex);
        }

        //Post
        [HttpPost]
        public IActionResult Create(Sex sex)
        {
            try
            {
                sex = _sexRepository.Create(sex);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Edit(int Id)
        {
            Sex sex = _sexRepository.GetById(Id);
            return View(sex);
        }

        //Post
        [HttpPost]
        public IActionResult Edit(Sex sex)
        {
            try
            {
                sex = _sexRepository.Edit(sex);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Delete(int Id)
        {
            Sex sex = _sexRepository.GetById(Id);
            return View(sex);
        }

        //Post
        [HttpPost]
        public IActionResult Delete(Sex sex)
        {
            try
            {
                sex = _sexRepository.Delete(sex);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

    }
}
