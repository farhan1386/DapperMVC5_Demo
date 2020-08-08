using DapperMVC5_Demo.Models;
using System.Collections.Generic;

namespace DapperMVC5_Demo.ViewModels
{
    public class EmployeeViewModel
    {
        List<Employees> employees = new List<Employees>();
        List<Departments> departments = new List<Departments>();
    }
}