using Kadrovska_baza.Models;
using System.Collections.Generic;

namespace Kadrovska_baza.Interface
{
    public interface IEmployeeRepository
    {
        IList<Employee> GetAll();
        Employee GetById(int id);
        Employee Create(Employee employee);
        Employee Edit(Employee employee);
        Employee Delete(Employee employee);
        string FindBySocialSecurityNumber (string socialSecurityNumber);

    }
}
