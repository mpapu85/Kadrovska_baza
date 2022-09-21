using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kadrovska_baza.Controllers
{
    public class OrganizationController : Controller
    {
        private readonly IOrganizationRepository _organizationRepository;
        public OrganizationController(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }
        public IActionResult Index()
        { 
            IList<Organization> organization = _organizationRepository.GetAll();
            return View(organization);
        }

        //Get
        public IActionResult Create()
        {
            Organization organization = new Organization();
            return View(organization);
        }

        //Post
        [HttpPost]
        public IActionResult Create(Organization organization)
        {
            try
            {
                organization = _organizationRepository.Create(organization);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Edit(int Id)
        {
            Organization organization = _organizationRepository.GetById(Id);
            return View(organization);
        }

        //Post
        [HttpPost]
        public IActionResult Edit(Organization organization)
        {
            try
            {
                organization = _organizationRepository.Edit(organization);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Delete(int Id)
        {
            Organization organization = _organizationRepository.GetById(Id);
            return View(organization);
        }

        //Post
        [HttpPost]
        public IActionResult Delete(Organization organization)
        {
            try
            {
                organization = _organizationRepository.Delete(organization);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
