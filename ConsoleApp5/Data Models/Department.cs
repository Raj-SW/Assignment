using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Department
{
    internal class Department
    {
        private string department_id { get; set; }
        private string department_manager_id { get; set; }
        private string department_manager_name { get; set; }
        private string department_name { get; set; }
        private int department_employees { get;set; }

        public Department(string id, string managerid, string managername, string departmentName, int numOfEmpl) { 
            this.department_id = id;
            this.department_manager_id = managerid;
            this.department_manager_name = managername;
            this.department_name = departmentName;
            this.department_employees = numOfEmpl;
        }
    }
}
