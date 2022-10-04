using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturingCost
{
    public class manufacturingCost : InterfaceCost
    {
        public int totalPartsCost;
        public int totalManpowerCost;
        public int totalManufactureCost;

        public int ManpowerCostCal(int manpowerCostPerPart)
        {
            return (totalManpowerCost + manpowerCostPerPart);
        }

        //interface implementation
        public void repairingCost(int cost)
        {
            Console.WriteLine("Total cost of car repairing would be: " + cost);
        }
    }
}
