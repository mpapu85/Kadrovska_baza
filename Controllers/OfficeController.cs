using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kadrovska_baza.Controllers
{
    public class OfficeController : Controller
    {
        private readonly IOfficeRepository _officeRepository;
        public OfficeController(IOfficeRepository officeRepository)
        {
            _officeRepository = officeRepository;
        }
        public IActionResult Index()
        {
            IList<Office> office = _officeRepository.GetAll();
            return View(office);
        }

        //Get
        public IActionResult Create()
        {
            Office office = new Office();
            return View(office);
        }

        //Post
        [HttpPost]
        public IActionResult Create(Office office)
        {
            try
            {
                office = _officeRepository.Create(office);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Edit(int Id)
        {
            Office office = _officeRepository.GetById(Id);
            return View(office);
        }

        //Post
        [HttpPost]
        public IActionResult Edit(Office office)
        {
            try
            {
                office = _officeRepository.Edit(office);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Delete(int Id)
        {
            Office office = _officeRepository.GetById(Id);
            return View(office);
        }

        //Post
        [HttpPost]
        public IActionResult Delete(Office office)
        {
            try
            {
                office = _officeRepository.Delete(office);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
