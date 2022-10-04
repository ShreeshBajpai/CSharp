using election.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace election.Models
{
    public class Base: IBase
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}


