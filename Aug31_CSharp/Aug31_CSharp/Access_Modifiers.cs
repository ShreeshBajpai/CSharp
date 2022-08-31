using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug31_CSharp
{
    class Access_Modifiers
    {
        public int pubA { get; set; }
        public int pubB { get; set; }
        private int privA { get; set; }
        protected int protA { get; set; }

        public int getPrivA
        {
            get
            {
                return privA;
            }
            set
            {
                privA = value;
            }
        }

        public int getProtA
        {
            get
            {
                return protA;
            }
            set
            {
                protA = value;
            }
        }
    }
}
