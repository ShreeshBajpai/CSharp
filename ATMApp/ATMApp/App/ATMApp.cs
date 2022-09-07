using ATMApp.Domain.Entities;
using ATMApp.Domain.Interfaces;
using ATMApp.UI;
using System.Collections.Generic;

public class ATMapp : IUserLogin

{
    private List<UserAccount> userAccountList;
    private UserAccount selectedAccount;

    public void CheckUserCardNumAndPass()
    {
        bool isCorrectLogin = false;

        UserAccount tempUserAccoount = new UserAccount();
    }

    public void InitialiseData()
    {
        userAccountList = new List<UserAccount>
            {
                new UserAccount{id=1, FullName="Shreesh Dutta Bajpai", AccountNumber=12345678, CardNumber=431431, CardPin=123456, AccountBalance=50000.00m, isLocked=false},
                new UserAccount{id=2, FullName="Abhishek Rawat", AccountNumber=09876543, CardNumber=123123, CardPin=567890, AccountBalance=40000.00m, isLocked=false},
                new UserAccount{id=1, FullName="Sumit Thapliyal", AccountNumber=0987124, CardNumber=567567, CardPin=345678, AccountBalance=30000.00m, isLocked=true}
            };
    }

}