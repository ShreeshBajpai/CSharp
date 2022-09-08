using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.Domain.Interfaces
{
    public interface IuserAccntActions
    {
        void CheckBalance();
        void PlaceDeposits();
        void MakeWithDrawal();
    }
}
