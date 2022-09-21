using Kadrovska_baza.Data;
using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Kadrovska_baza.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ApplicationDbContext _context;
        public EmployeeController(IEmployeeRepository employeeRepository, ApplicationDbContext context)
        {
            _employeeRepository = employeeRepository;
            _context = context;
        }
        public IActionResult Index()
        {
            
            IList<Employee> employee = _employeeRepository.GetAll().ToList();
            return View(employee);

        }

        public IActionResult Details(int Id)
        {
            Employee employee = _employeeRepository.GetById(Id);
            return View(employee);


        }

        //Get
        public IActionResult Create()
        {
            Employee employee = new Employee();

            ViewData["StateId"] = new SelectList(_context.States, "Id", "NameOfState");
            ViewData["PlaceOfBirthId"] = new SelectList(_context.Cities, "Id", "NameOfCity");
            ViewData["PlaceOfResidenceId"] = new SelectList(_context.Cities, "Id", "NameOfCity");
            ViewData["CommunityOfBirthId"] = new SelectList(_context.Communities, "Id", "NameOfComminuty");
            ViewData["CommunityOfResidenceId"] = new SelectList(_context.Communities, "Id", "NameOfComminuty");
            ViewData["OrganizationID"] = new SelectList(_context.Organizations, "Id", "NameOfOrganization");
            ViewData["PositionId"] = new SelectList(_context.Positions, "Id", "NameOfPosition");
            ViewData["SectorId"] = new SelectList(_context.Sectors, "Id", "NameOfSector");
            ViewData["OfficeId"] = new SelectList(_context.Offices, "Id", "NameOfOffice");
            ViewData["LevelOfEducationId"] = new SelectList(_context.LevelOfEducations, "Id", "NameOfLevelOfEducation");
            ViewData["ProfessionalQualificationId"] = new SelectList(_context.ProfessionalQualifications, "Id", "NameOfProfessionalQualification");
            ViewData["ProfessionId"] = new SelectList(_context.Professions, "Id", "NameOfProfession");
            ViewData["EmploymentId"] = new SelectList(_context.Employments, "Id", "NameOfEmployment");
            ViewData["ReasonForTerminationId"] = new SelectList(_context.ReasonForTerminations, "Id", "NameOfReasonForTermination");
            ViewData["SexId"] = new SelectList(_context.Sexs, "Id", "NameOfSex");

            return View(employee);
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            
            if (ModelState.IsValid)                    
            {
                employee = _employeeRepository.Create(employee);
            }
            
            else
            {
                ViewData["StateId"] = new SelectList(_context.States, "Id", "NameOfState");
                ViewData["PlaceOfBirthId"] = new SelectList(_context.Cities, "Id", "NameOfCity");
                ViewData["PlaceOfResidenceId"] = new SelectList(_context.Cities, "Id", "NameOfCity");
                ViewData["CommunityOfBirthId"] = new SelectList(_context.Communities, "Id", "NameOfComminuty");
                ViewData["CommunityOfResidenceId"] = new SelectList(_context.Communities, "Id", "NameOfComminuty");
                ViewData["OrganizationID"] = new SelectList(_context.Organizations, "Id", "NameOfOrganization");
                ViewData["PositionId"] = new SelectList(_context.Positions, "Id", "NameOfPosition");
                ViewData["SectorId"] = new SelectList(_context.Sectors, "Id", "NameOfSector");
                ViewData["OfficeId"] = new SelectList(_context.Offices, "Id", "NameOfOffice");
                ViewData["LevelOfEducationId"] = new SelectList(_context.LevelOfEducations, "Id", "NameOfLevelOfEducation");
                ViewData["ProfessionalQualificationId"] = new SelectList(_context.ProfessionalQualifications, "Id", "NameOfProfessionalQualification");
                ViewData["ProfessionId"] = new SelectList(_context.Professions, "Id", "NameOfProfession");
                ViewData["EmploymentId"] = new SelectList(_context.Employments, "Id", "NameOfEmployment");
                ViewData["ReasonForTerminationId"] = new SelectList(_context.ReasonForTerminations, "Id", "NameOfReasonForTermination");
                ViewData["SexId"] = new SelectList(_context.Sexs, "Id", "NameOfSex");
                return View();
            }
            
            return RedirectToAction(nameof(Index));

            
        }

        //Get
        public IActionResult Edit(int Id)
        {
            Employee employee = _employeeRepository.GetById(Id);

            ViewData["StateId"] = new SelectList(_context.States, "Id", "NameOfState");
            ViewData["PlaceOfBirthId"] = new SelectList(_context.Cities, "Id", "NameOfCity");
            ViewData["PlaceOfResidenceId"] = new SelectList(_context.Cities, "Id", "NameOfCity");
            ViewData["CommunityOfBirthId"] = new SelectList(_context.Communities, "Id", "NameOfComminuty");
            ViewData["CommunityOfResidenceId"] = new SelectList(_context.Communities, "Id", "NameOfComminuty");
            ViewData["OrganizationID"] = new SelectList(_context.Organizations, "Id", "NameOfOrganization");
            ViewData["PositionId"] = new SelectList(_context.Positions, "Id", "NameOfPosition");
            ViewData["SectorId"] = new SelectList(_context.Sectors, "Id", "NameOfSector");
            ViewData["OfficeId"] = new SelectList(_context.Offices, "Id", "NameOfOffice");
            ViewData["LevelOfEducationId"] = new SelectList(_context.LevelOfEducations, "Id", "NameOfLevelOfEducation");
            ViewData["ProfessionalQualificationId"] = new SelectList(_context.ProfessionalQualifications, "Id", "NameOfProfessionalQualification");
            ViewData["ProfessionId"] = new SelectList(_context.Professions, "Id", "NameOfProfession");
            ViewData["EmploymentId"] = new SelectList(_context.Employments, "Id", "NameOfEmployment");
            ViewData["ReasonForTerminationId"] = new SelectList(_context.ReasonForTerminations, "Id", "NameOfReasonForTermination");
            ViewData["SexId"] = new SelectList(_context.Sexs, "Id", "NameOfSex");

            return View(employee);
        }

        //Post
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            try
            {
                employee = _employeeRepository.Edit(employee);
            }
            catch
            {
                ViewData["StateId"] = new SelectList(_context.States, "Id", "NameOfState");
                ViewData["PlaceOfBirthId"] = new SelectList(_context.Cities, "Id", "NameOfCity");
                ViewData["PlaceOfResidenceId"] = new SelectList(_context.Cities, "Id", "NameOfCity");
                ViewData["CommunityOfBirthId"] = new SelectList(_context.Communities, "Id", "NameOfComminuty");
                ViewData["CommunityOfResidenceId"] = new SelectList(_context.Communities, "Id", "NameOfComminuty");
                ViewData["OrganizationID"] = new SelectList(_context.Organizations, "Id", "NameOfOrganization");
                ViewData["PositionId"] = new SelectList(_context.Positions, "Id", "NameOfPosition");
                ViewData["SectorId"] = new SelectList(_context.Sectors, "Id", "NameOfSector");
                ViewData["OfficeId"] = new SelectList(_context.Offices, "Id", "NameOfOffice");
                ViewData["LevelOfEducationId"] = new SelectList(_context.LevelOfEducations, "Id", "NameOfLevelOfEducation");
                ViewData["ProfessionalQualificationId"] = new SelectList(_context.ProfessionalQualifications, "Id", "NameOfProfessionalQualification");
                ViewData["ProfessionId"] = new SelectList(_context.Professions, "Id", "NameOfProfession");
                ViewData["EmploymentId"] = new SelectList(_context.Employments, "Id", "NameOfEmployment");
                ViewData["ReasonForTerminationId"] = new SelectList(_context.ReasonForTerminations, "Id", "NameOfReasonForTermination");
                ViewData["SexId"] = new SelectList(_context.Sexs, "Id", "NameOfSex");

            }
            return RedirectToAction(nameof(Index));
        }

        //Get
        public IActionResult Delete(int Id)
        {
            Employee employee = _employeeRepository.GetById(Id);
            return View(employee);
        }

        //Post
        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            try
            {
                employee = _employeeRepository.Delete(employee);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }


        [AllowAnonymous]
        [AcceptVerbs("Get", "Post")]
        public IActionResult UniqueSocialSecurityNumber(string socialSecurityNumber)
        {
           
            string _socialSecurityNumber =  _employeeRepository.FindBySocialSecurityNumber(socialSecurityNumber);

            if (_socialSecurityNumber == null)
            {
                return Json(true);
            }
            else
            {
                return Json("JMBG se već koristi");
            }
        }

        

        [HttpGet]
        public async Task<IActionResult> Index(string SearchString, string sortOrder)
        {
            ViewBag.NameSortParm = sortOrder == "Name" ? "name_desc" : "Name";
            ViewBag.LastNameSortParm = sortOrder == "LastName" ? "LastName_desc" : "LastName";
            ViewBag.OrganizationSortParm = sortOrder == "Organization" ? "Organization_desc" : "Organization";
            ViewBag.PositionSortParm = sortOrder == "Position" ? "Position_desc" : "Position";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";


            ViewData["CurrentFilter"] = SearchString;
            var employee = from m in _context.Employees
                         select m;

            if (!String.IsNullOrEmpty(SearchString))
            {
                employee = employee.Where(s => s.Name.Contains(SearchString) || s.LastName.Contains(SearchString));
            }

            switch (sortOrder)
            {
                case "Name":
                    employee = employee.OrderBy(s => s.Name);
                    break;
                case "name_desc":
                    employee = employee.OrderByDescending(s => s.Name);
                    break;
                case "LastName":
                    employee = employee.OrderBy(s => s.LastName);
                    break;
                case "LastName_desc":
                    employee = employee.OrderByDescending(s => s.LastName);
                    break;
                case "Organization":
                    employee = employee.OrderBy(s => s.Organization.NameOfOrganization);
                    break;
                case "Organization_desc":
                    employee = employee.OrderByDescending(s => s.Organization.NameOfOrganization);
                    break;
                case "Position":
                    employee = employee.OrderBy(s => s.Position.NameOfPosition);
                    break;
                case "Position_desc":
                    employee = employee.OrderByDescending(s => s.Position.NameOfPosition);
                    break;
                case "Date":
                    employee = employee.OrderBy(s => s.StartOfWork);
                    break;
                case "date_desc":
                    employee = employee.OrderByDescending(s => s.StartOfWork);
                    break;
                default:
                    employee = employee.OrderBy(s => s.LastName);
                    break;
            }

            return View(await employee.ToListAsync());
        }
        
    }
}
