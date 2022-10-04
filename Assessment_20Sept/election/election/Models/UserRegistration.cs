using election.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace election.Models
{
    public class UserRegistration : Base, IUserRegistration
    {

        public int id { get; set; }
        public string pass { get; set; }
        public string aadhar { get; set; }
        public string voter_id { get; set; }
        public int mpin { get; set; }

    }
}
