using RestWebServiceCustomer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWebServiceCustomer.RestClient
{
    public interface IRestCustomer
    {

        IEnumerable<Departement> GetDepartments();

        IEnumerable<Employee> GetDepartmentEmployee();
    }
}
