using Kadrovska_baza.Data;
using Kadrovska_baza.Interface;
using Kadrovska_baza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Kadrovska_baza.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Employee Create(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee Delete(Employee employee)
        {
            _context.Employees.Attach(employee);
            _context.Entry(employee).State = EntityState.Deleted;
            _context.SaveChanges();
            return employee;
        }

        public IList<Employee> GetAll()
        {
            IList<Employee> employee = _context.Employees
                .Include(z => z.State)
                .Include(z => z.PlaceOfBirth)
                .Include(z => z.PlaceOfResidence)
                .Include(z => z.CommunityOfResidence)
                .Include(z => z.CommunityOfBirth)
                .Include(z => z.Organization)
                .Include(z => z.Position)
                .Include(z => z.Sector)
                .Include(z => z.Office)
                .Include(z => z.LevelOfEducation)
                .Include(z => z.ProfessionalQualification)
                .Include(z => z.Employment)
                .Include(z => z.Sex)
                .Include(z => z.ReasonForTermination)
                .Include(z => z.Profession).ToList();
            return employee;
        }

  

        public Employee GetById(int id)
        {
            Employee employee = _context.Employees
                .Include(z => z.State)
                .Include(z => z.PlaceOfBirth)
                .Include(z => z.PlaceOfResidence)
                .Include(z => z.CommunityOfResidence)
                .Include(z => z.CommunityOfBirth)
                .Include(z => z.Organization)
                .Include(z => z.Position)
                .Include(z => z.Sector)
                .Include(z => z.Office)
                .Include(z => z.LevelOfEducation)
                .Include(z => z.ProfessionalQualification)
                .Include(z => z.Employment)
                .Include(z => z.Sex)
                .Include(z => z.ReasonForTermination)
                .Include(z => z.Profession).FirstOrDefault(x => x.Id == id);
            return employee;
        }

        

        public Employee Edit(Employee employee)
        {

            _context.Employees.Attach(employee);
            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
            return employee;

        }

        public string FindBySocialSecurityNumber(string socialNumber)
        {
            
            var number = (from z in _context.Employees
                          where z.SocialSecurityNumber == socialNumber
                          select z.SocialSecurityNumber).ToString();
            return number;
        }
                
    }
}
