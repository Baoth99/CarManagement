using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.dtos
{
    public class EmployeeDTO
    {
        public string id { get; set; }
        public string fullName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool role { get; set; }
        public bool status { get; set; }
    }
}
