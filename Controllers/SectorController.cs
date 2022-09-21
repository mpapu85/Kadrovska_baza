using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kadrovska_baza.Controllers
{
    public class SectorController : Controller
    {
        private readonly ISectorRepository _sectorRepository;
        public SectorController(ISectorRepository sectorRepository)
        {
            _sectorRepository = sectorRepository;
        }
        public IActionResult Index()
        {
            IList<Sector> sector = _sectorRepository.GetAll();
            return View(sector);
        }

        //Get
        public IActionResult Create()
        {
            Sector sector = new Sector();
            return View(sector);
        }

        //Post
        [HttpPost]
        public IActionResult Create(Sector sector)
        {
            try
            {
                sector = _sectorRepository.Create(sector);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Edit(int Id)
        {
            Sector sector = _sectorRepository.GetById(Id);
            return View(sector);
        }

        //Post
        [HttpPost]
        public IActionResult Edit(Sector sector)
        {
            try
            {
                sector = _sectorRepository.Edit(sector);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Delete(int Id)
        {
            Sector sector = _sectorRepository.GetById(Id);
            return View(sector);
        }

        //Post
        [HttpPost]
        public IActionResult Delete(Sector sector)
        {
            try
            {
                sector = _sectorRepository.Delete(sector);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
