using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Kadrovska_baza.Controllers
{
    public class CommunityController : Controller
    {
        private readonly ICommunityRepository _communityRepository;
        public CommunityController(ICommunityRepository communityRepository)
        {
            _communityRepository = communityRepository;
        }

        public IActionResult Index()
        {
            IList<Community> community = _communityRepository.GetAll();
            return View(community);
        }

        //Get
        public IActionResult Create()
        {
            Community community = new Community();
            return View(community);
        }

        //Post
        [HttpPost]
        public IActionResult Create(Community community)
        {
            try
            {
                community = _communityRepository.Create(community);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Edit(int Id)
        {
            Community community = _communityRepository.GetById(Id);
            return View(community);
        }

        //Post
        [HttpPost]
        public IActionResult Edit(Community community)
        {
            try
            {
                community = _communityRepository.Edit(community);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int Id)
        {
            Community community = _communityRepository.GetById(Id);
            return View(community);
        }

        //Post
        [HttpPost]
        public IActionResult Delete(Community community)
        {
            try
            {
                community = _communityRepository.Delete(community);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
