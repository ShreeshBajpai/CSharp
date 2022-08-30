using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTask.PartialClasses
{
        public partial class Sample
        {
            public void displayMovieDetails()
            {
                Console.WriteLine("Movie title is: " + movie);
                Console.WriteLine("Release year is: " + release_year);
            }
        }
    }
