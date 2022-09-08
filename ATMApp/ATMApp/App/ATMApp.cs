using ATMApp.Domain.Entities;
using ATMApp.Domain.Enums;
using ATMApp.Domain.Interfaces;
using ATMApp.UI;
using System.Collections.Generic;

public class ATMapp : IUserLogin, IuserAccntActions


{
    private List<UserAccount> userAccountList;
    private UserAccount selectedAccount;

    public void Run()
    {
        AppScreen.Welcome();
        CheckUserCardNumAndPass();
        AppScreen.WelcomeCustomer(selectedAccount.FullName);
        AppScreen.DisplayAppMenu();
        ProcessMenuoption();

    }

    public void CheckUserCardNumAndPass()
    {
        bool isCorrectLogin = false;

        while (isCorrectLogin == false)
        {
            UserAccount inputAccount = AppScreen.UserLoginForm();
            AppScreen.LoginProgress();
            foreach (UserAccount account in userAccountList)
            {
                selectedAccount = account;
                if (inputAccount.CardNumber.Equals(selectedAccount.CardNumber))
                {
                    selectedAccount.TotalLogin++;

                    if (inputAccount.CardPin.Equals(selectedAccount.CardPin))
                    {
                        selectedAccount = account;

                        if (selectedAccount.isLocked || selectedAccount.TotalLogin > 3)
                        {
                            //print a lock message
                            AppScreen.PrintLockScreen();
                        }
                        else
                        {
                            selectedAccount.TotalLogin = 0;
                            isCorrectLogin = true;
                            break;
                        }
                    }
                    break;

                }
            }
            if (isCorrectLogin == false)
            {
                Utility.PrintMessage("\nInvalid Card Number or PIN", false);
                selectedAccount.isLocked = selectedAccount.TotalLogin == 3;
                if (selectedAccount.isLocked)
                {
                    AppScreen.PrintLockScreen();
                }
            }
            Console.Clear();
        }

    }

    public void InitialiseData()
    {
        userAccountList = new List<UserAccount>
            {
                new UserAccount{id=1, FullName="Shreesh Dutta Bajpai", AccountNumber=12345678, CardNumber=431431, CardPin=123456, AccountBalance=50000.00m, isLocked=false},
                new UserAccount{id=2, FullName="Abhishek Rawat", AccountNumber=09876543, CardNumber=123123, CardPin=567890, AccountBalance=40000.00m, isLocked=false},
                new UserAccount{id=3, FullName="Sumit Thapliyal", AccountNumber=0987124, CardNumber=567567, CardPin=345678, AccountBalance=30000.00m, isLocked=true}
            };
    }

    private void ProcessMenuoption()
    {
        switch (Validator.Convert<int>("an option:"))
        {
            case (int)AppMenu.CheckBalance:
                CheckBalance();
                break;
            case (int)AppMenu.PlaceDeposit:
                Console.WriteLine("Placing deposit...");
                break;
            case (int)AppMenu.MakeWithdrawal:
                Console.WriteLine("Making withdrawal...");
                break;
            case (int)AppMenu.InternalTransfer:
                Console.WriteLine("Making interal transfer...");
                break;
            case (int)AppMenu.ViewTransaction:
                Console.WriteLine("Viewing Transaction...");
                break;
            case (int)AppMenu.Logout:
                AppScreen.LoginProgress();
                Utility.PrintMessage("You have successfully Logged out. Please collect your ATM card.");
                Run();

                break;
            default:
                Utility.PrintMessage("Invalid Option.", false);
                break;
        }
    }

    public void CheckBalance()
    {
        Utility.PrintMessage($"Your Account Balance is: {Utility.FormatAmount(selectedAccount.AccountBalance)}");
    }

    public void PlaceDeposits()
    {
        Console.WriteLine("\nOnly multiples of 500 and 1000 INR allowed");
        //var transaction_amt = Validator.Convert<int>($"amount { AppScreen.cur}");
    }

    public void MakeWithDrawal()
    {
        throw new NotImplementedException();
    }

    
}