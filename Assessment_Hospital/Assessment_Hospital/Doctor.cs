using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Hospital
{
    public class DoctorClass : CommonClass
    {
        public string department;
        private int salary;
        protected string email;

        public string doc_email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public int salaryInfo
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
    }
}
