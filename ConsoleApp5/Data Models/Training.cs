using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Training
{
    internal class Training
    {
        private string training_id { get; set; }
        private string training_name { get; set; }
        private string priority { get; set; }

        private DateTime registrationdeadline { get; set; }
        private DateTime registrationstartTime { get; set; }

        public Training(string trainingId, string trainingName, string pririoty, DateTime start,DateTime deadline)
        {
            this.training_id = trainingId;
            this.training_name = trainingName;
            this.priority = pririoty;
            this.registrationdeadline = start;
            this.registrationstartTime = deadline;
        }
    }
}
