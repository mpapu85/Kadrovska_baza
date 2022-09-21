using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kadrovska_baza.Controllers
{
    public class StateController : Controller
    {
        private readonly IStateRepository _stateRepository;
        public StateController(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }
        public IActionResult Index()
        {
            IList<State> state = _stateRepository.GetAll();
            return View(state);
        }

        //Get
        public IActionResult Create()
        {
            State state = new State();
            return View(state);
        }

        //Post
        [HttpPost]
        public IActionResult Create(State state)
        {
            try
            {
                state=_stateRepository.Create(state);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }


        //Get
        public IActionResult Edit(int id)
        {
            State state = _stateRepository.GetById(id);
            return View(state);
        }

        //Post
        [HttpPost]
        public IActionResult Edit(State state)
        {
            try
            {
                state = _stateRepository.Edit(state);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Delete(int id)
        {
            State state = _stateRepository.GetById(id);
            return View(state);
        }

        //Post
        [HttpPost]
        public IActionResult Delete(State state)
        {
            try
            {
                state = _stateRepository.Delete(state);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
