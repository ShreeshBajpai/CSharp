using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturingCost
{
        public interface InterfaceCost
        {
            public void repairingCost(int cost);
            public int ManpowerCostCal(int manpowerCostPerPart);
        }
}
