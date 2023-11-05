using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Training
{
    internal class Request
    {
        private string request_id {  get; set; }
        private string training_id { get; set; }
        private string employee_id { get; set;}
        private string manager_id { get; set; }
        private string approval { get; set;}

        public Request(string id, string t_id, string e_id, string m_d, string approval)
        {
            this.request_id = id;
            this.training_id = t_id;
            this.employee_id = e_id;
            this.manager_id = m_d;
            this.approval = approval;

        }
    }
}
