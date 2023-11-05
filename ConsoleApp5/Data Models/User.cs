using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Actors
{
    internal abstract class User
    {
        private int user_id { get; set; }
        private string user_name { get; set; }
        private string user_email { get; set; }
        private string user_department_id { get; set; }
        private string user_nic { get; set; }
        private string user_mobileNum { get; set; }
        private string user_role { get; set; }
        private List<String> user_skills { get; set; }

        public User(int id, string name, string email, string dept, string nic, string mobile, List<String> skills,string role)
        {
            this.user_id = id;
            this.user_name = name;
            this.user_email = email;
            this.user_department_id = dept;
            this.user_nic = nic;
            this.user_role = role;
            this.user_mobileNum = mobile;
            this.user_skills = skills;
        }
    }   

}
