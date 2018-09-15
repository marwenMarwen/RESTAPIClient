using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWebServiceCustomer.Models
{
    public class Departement
    {
        public short? DepartmentId { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }

}
