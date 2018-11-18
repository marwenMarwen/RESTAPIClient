using RestCall.HttpCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;


namespace RestCall
{
    class Program
    {
        static void Main(string[] args)
        {
             GetAllDepartment();

            // GetDepartmentById(1);

            // AddDepartment();

            // DeleteDepartment(5);

           // UpdateDepartment(3);

            Console.ReadLine();
        }

        static void GetAllDepartment()
        {
            var httpManeger = new CustomHttpClient();
            var departments = httpManeger.GetDepartement();

            foreach (var department in departments)
            {
                Console.WriteLine(department.Name);
            }
        }

        static void GetDepartmentById(int departmentId)
        {
            var httpManeger = new CustomHttpClient();
            var department = httpManeger.GetDepartementById(departmentId);

            Console.WriteLine("Id: " + department.DepartmentId);
            Console.WriteLine("Name: " + department.Name);
            Console.WriteLine("GroupName: " + department.GroupName);
        }

        static void AddDepartment()
        {
            var httpManeger = new CustomHttpClient();

            bool result = httpManeger.PostData().Result;

            string Message = result ? "L'opération s'est exécuté avec succès" : "L'opération a échoué";
            Console.WriteLine(result);
        }

        static void DeleteDepartment(int departmentID)
        {
            var httpManeger = new CustomHttpClient();
            bool result = httpManeger.DeleteElement(departmentID).Result;

            string Message = result ? "L'opération s'est exécuté avec succès" : "L'opération a échoué";
            Console.WriteLine(Message);
        }

        static void UpdateDepartment(short DepartmentId)
        {
            var httpManeger = new CustomHttpClient();
            bool result = httpManeger.UpdateDepartment(DepartmentId).Result;

            string Message = result ? "L'opération s'est exécuté avec succès" : "L'opération a échoué";
            Console.WriteLine(Message);
        }

    }
}
