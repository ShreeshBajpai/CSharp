using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Sept05
{
    public class Sales
    {
        public int SaleId { get; set; }
        public int FranchiseId { get; set; }
        public int Amount { get; set; }
        public DateOnly SalesDate { get; set; }
        public string SalesMode { get; set; }            
    }
}
