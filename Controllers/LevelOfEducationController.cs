using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kadrovska_baza.Controllers
{
    public class LevelOfEducationController : Controller
    {
        private readonly ILevelOfEducationRepository _levelOfEducationRepository;
        public LevelOfEducationController(ILevelOfEducationRepository levelOfEducationRepository)
        {
            _levelOfEducationRepository = levelOfEducationRepository;
        }
        public IActionResult Index()
        {
            IList<LevelOfEducation> level = _levelOfEducationRepository.GetAll();
            return View(level);
        }

        //Get
        public IActionResult Create()
        {
            LevelOfEducation level = new LevelOfEducation();
            return View(level);
        }

        //Post
        [HttpPost]
        public IActionResult Create(LevelOfEducation level)
        {
            try
            {
                level = _levelOfEducationRepository.Create(level);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Edit(int Id)
        {
            LevelOfEducation level = _levelOfEducationRepository.GetById(Id);
            return View(level);
        }

        //Post
        [HttpPost]
        public IActionResult Edit(LevelOfEducation level)
        {
            try
            {
                level = _levelOfEducationRepository.Edit(level);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Delete(int Id)
        {
            LevelOfEducation level = _levelOfEducationRepository.GetById(Id);
            return View(level);
        }

        //Post
        [HttpPost]
        public IActionResult Delete(LevelOfEducation level)
        {
            try
            {
                level = _levelOfEducationRepository.Delete(level);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
