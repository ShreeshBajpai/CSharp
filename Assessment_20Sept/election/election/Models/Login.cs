using election.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace election.Models
{
    public class Login: Base, ILogin
    {
        public int id { get; set; }
        public string pass { get; set; }
        public string aadhar { get; set; }
        public string voter_id { get; set; }
        public int mpin { get; set; }

    }
}
