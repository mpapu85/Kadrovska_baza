using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kadrovska_baza.Controllers
{
    public class PositionController : Controller
    {
        private readonly IPositionRepository _positionRepository;
        public PositionController(IPositionRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }
        public IActionResult Index()
        {
            IList<Position> position = _positionRepository.GetAll();
            return View(position);
        }

        //Get
        public IActionResult Create()
        {
            Position position = new Position();
            return View(position);
        }

        //Post
        [HttpPost]
        public IActionResult Create(Position position)
        {
            try
            {
                position = _positionRepository.Create(position);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Edit(int Id)
        {
            Position position = _positionRepository.GetById(Id);
            return View(position);
        }

        //Post
        [HttpPost]
        public IActionResult Edit(Position position)
        {
            try
            {
                position = _positionRepository.Edit(position);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Delete(int Id)
        {
            Position position = _positionRepository.GetById(Id);
            return View(position);
        }

        //Post
        [HttpPost]
        public IActionResult Delete(Position position)
        {
            try
            {
                position = _positionRepository.Delete(position);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
