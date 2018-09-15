using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWebServiceCustomer.Models
{
    public class Employee
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Fonction { get; set; }
        public string Sexe { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime dateNaissance { get; set; }
        public Guid Rowguid { get; set; }
    }
}
