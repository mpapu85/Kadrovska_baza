using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kadrovska_baza.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityRepository _cityRepository;
        public CityController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public IActionResult Index()
        {
            IList<City> cities = _cityRepository.GetAll();
            return View(cities);
        }

        //Get
        public IActionResult Create()
        {
            City city = new City();
            return View(city);
        }

        //Post
        [HttpPost]
        public IActionResult Create(City city)
        {
            try
            {
                city = _cityRepository.Create(city);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Edit(int Id)
        {
            City city = _cityRepository.GetById(Id);
            return View(city);
        }

        //Post
        [HttpPost]
        public IActionResult Edit(City city)
        {
            try
            {
                city = _cityRepository.Edit(city);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Delete(int Id)
        {
            City city = _cityRepository.GetById(Id);
            return View(city);
        }

        //Post
        [HttpPost]
        public IActionResult Delete(City city)
        {
            try
            {
                city = _cityRepository.Delete(city);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
