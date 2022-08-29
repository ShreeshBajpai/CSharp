using System;
namespace BhavnaCorp;

class Program
{
    static void Main(String[] args)
    {


        String name="", ID="", addr="", dept="", Pname="", Paddr="", PID="", PatientName="", bed_dept="", Patient_Addr="";
        string answer = "Y";
        for (; answer.ToUpper() == "Y";)
        {
            int pal, arm, rollno=10, booking_id; 
            double phone, Pphone, Patient_Phone;
            String s_name = "Abc";
            Console.WriteLine("Press 1 for registering doctors");
            Console.WriteLine("Press 2 for registering patients");
            Console.WriteLine("Press 3 for booking bed for patient");
            Console.WriteLine("Enter your choice : ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
           
                case 1:
                    Console.WriteLine("Enter the Doctor's ID: - ");
                    ID = Console.ReadLine();
                    Console.WriteLine("Enter the Doctor's Name: - ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the Doctor's Department: - ");
                    dept = Console.ReadLine();
                    Console.WriteLine("Enter the Doctor's Phone: - ");
                    phone = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Doctor's Address: - ");
                    addr = Console.ReadLine();
                    Console.WriteLine("Doctor's Id is : " + ID);
                    Console.WriteLine("Doctor's Name is : " + name);
                    Console.WriteLine("Doctor's Department is: - " + dept);
                    Console.WriteLine("Doctor's Address is: - " + addr);
                    Console.WriteLine("Doctor's Phone Number is: - " + phone);
                    break;

                case 2:
                    Console.WriteLine("Enter the Patient's ID: - ");
                    PID = Console.ReadLine();
                    Console.WriteLine("Enter the Patient's Name: - ");
                    Pname = Console.ReadLine();
                    Console.WriteLine("Enter the Patient's Phone: - ");
                    Pphone = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Patient's Address: - ");
                    Paddr = Console.ReadLine();
                    Console.WriteLine("Patient's Id is : " + PID);
                    Console.WriteLine("Patient's Name is : " + Pname);
                    Console.WriteLine("Patient's Address is: - " + Paddr);
                    Console.WriteLine("Patient's Phone Number is: - " + Pphone);
                    break;

                case 3:
                    Console.WriteLine("Bed Booking Details");
                    Console.WriteLine("Enter the Booking Id :- ");
                    booking_id=int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the patient's Name :- ");
                    PatientName=Console.ReadLine();
                    Console.WriteLine("Enter the Department in which bed needs to be booked: - ");
                    bed_dept = Console.ReadLine();
                    Console.WriteLine("Enter the patient's Address :- ");
                    Patient_Addr=Console.ReadLine();
                    Console.WriteLine("Enter the patient's Phone :- ");
                    Patient_Phone=double.Parse(Console.ReadLine());
                    Console.WriteLine("!!! Booking Successful !!!");
                    Console.WriteLine("Booking Id is : " + booking_id);
                    Console.WriteLine("Patient's Name is : " + PatientName);
                    Console.WriteLine("Patient's Address is: - " + Patient_Addr);
                    Console.WriteLine("Patient's Phone Number is: - " + Patient_Phone);
                    Console.WriteLine("Department Of Admissible Patient is:- " + bed_dept);
                    break;                    
            }
            Console.WriteLine("Do you want to continue (Y/N)?");
            answer = Console.ReadLine();
        }
    }
}