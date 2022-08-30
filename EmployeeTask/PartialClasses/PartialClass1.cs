using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeTask.PartialClasses
{
    public partial class Sample
    {
        private string movie;
        private int release_year;

        public Sample(string x, int y)
        {
            this.movie = x;
            this.release_year = y;
        }
    }
}
