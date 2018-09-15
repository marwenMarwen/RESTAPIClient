using RestCall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace RestCall.HttpCustomer
{
    public class HttpManager
    {

        public  IEnumerable<Departement> GetDepartement()
        {

            IEnumerable<Departement> departments = new List<Departement>();

            var client = new HttpClient();

            var task =
                client.GetAsync("http://localhost:50346/api/Departement")
                .ContinueWith((taskwithmsg) =>
                {
                    var response = taskwithmsg.Result;
                    var jsonTask = response.Content.ReadAsStringAsync();
                    jsonTask.Wait();
                    departments = new JavaScriptSerializer().Deserialize<IEnumerable<Departement>>(jsonTask.Result);
                });
            task.Wait();

            return departments;
        }


        public Departement GetDepartementById(int Id)
        {

            Departement department = null;

            var client = new HttpClient();

            var task =
                client.GetAsync("http://localhost:50346/api/Departement/"+Id)
                .ContinueWith((taskwithmsg) =>
                {
                    var response = taskwithmsg.Result;
                    var jsonTask = response.Content.ReadAsStringAsync();
                    jsonTask.Wait();
                    department = new JavaScriptSerializer().Deserialize<Departement>(jsonTask.Result);
                });
            task.Wait();

            return department;
        }

        public async Task<bool> PostData()
        {
            var departement = new Departement
            {
                GroupName = "GroupeName",
                Name = "Name",
                ModifiedDate = DateTime.Now,
            };

            var content = new StringContent(new JavaScriptSerializer().Serialize(departement), Encoding.UTF8, "application/json");

            var client = new HttpClient();

            HttpResponseMessage response = await client.PostAsync("http://localhost:50346/api/Departement", content);

            return response.IsSuccessStatusCode;
            
        }

        public async Task<bool> DeleteElement(int Id)
        {
            var client = new HttpClient();

            HttpResponseMessage response = await client.DeleteAsync("http://localhost:50346/api/Departement/"+Id);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateDepartment(short Id)
        {
            var departement = new Departement
            {
                DepartmentId = Id,
                GroupName = "GroupeName",
                Name = "Name",
                ModifiedDate = DateTime.Now,
            };

            var content = new StringContent(new JavaScriptSerializer().Serialize(departement), Encoding.UTF8, "application/json");
            var client = new HttpClient();

            HttpResponseMessage response = await client.PutAsync("http://localhost:50346/api/Departement/"+Id, content);
            return response.IsSuccessStatusCode;
        }

    }
}
