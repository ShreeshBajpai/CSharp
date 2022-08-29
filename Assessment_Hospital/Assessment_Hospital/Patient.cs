using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Hospital
{
    public class PatientClass : CommonClass
    {
        protected string address;
        protected string patient_dept;
        public string getAddress
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string patientDepartment
        {
            get
            {
                return patient_dept;
            }
            set
            {
                patient_dept = value;
            }
        }
    }
}
