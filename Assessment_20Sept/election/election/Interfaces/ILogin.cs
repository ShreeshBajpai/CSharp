using System;
using System.Collections.Generic;
using System.Text;

namespace election.Interfaces
{
    public interface ILogin
    {
        public int id { get; set; }
        public string pass { get; set; }
        public string aadhar { get; set; }
        public string voter_id { get; set; }
        public int mpin { get; set; }

    }
}
