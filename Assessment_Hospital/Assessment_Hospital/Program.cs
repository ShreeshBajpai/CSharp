using Assessment_Hospital;

string repeat = "Y";
int choice;

List<DoctorClass> doctorList = new List<DoctorClass> { };
List<PatientClass> patientList = new List<PatientClass> { };
List<BedBooking> bedsList = new List<BedBooking> { };

while (repeat == "Y" || repeat == "y")
{
    Console.WriteLine("Enter 1 for regeistering doctor.");
    Console.WriteLine("Enter 2 for registering patient.");
    Console.WriteLine("Enter 3 for booking bed.");
    Console.Write("Enter your choice : ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            DoctorClass doctorobj = new DoctorClass();
            Console.Write("Enter Doctor's Id: ");
            doctorobj.id = int.Parse(Console.ReadLine());
            Console.Write("Enter Doctor's Name: ");
            doctorobj.name = Console.ReadLine();
            Console.Write("Enter Doctor's Phone: ");
            doctorobj.phone = Console.ReadLine();
            Console.Write("Enter Doctor's Age: ");
            doctorobj.age = int.Parse(Console.ReadLine());
            Console.Write("Enter Doctor's Deprtment: ");
            doctorobj.department = Console.ReadLine();
            Console.Write("Enter Doctor's Salary: ");
            doctorobj.salaryInfo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Doctor's Email: ");
            doctorobj.doc_email = Console.ReadLine();

            doctorList.Add(doctorobj);

            foreach (DoctorClass doctor in doctorList)
            {
                Console.WriteLine("Details are: " + doctor.id + "/" + doctor.name + "/" + doctor.phone + "/" + doctor.age + "/" + doctor.department + "/" + doctor.salaryInfo + "/" + doctor.doc_email);
            }
            break;

        case 2:
            PatientClass patobj = new PatientClass();
            Console.WriteLine("Enter Patient's Id: ");
            patobj.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Patient's Name: ");
            patobj.name = Console.ReadLine();
            Console.WriteLine("Enter Patient's Phone No: ");
            patobj.phone = Console.ReadLine();
            Console.WriteLine("Enter Patient's Age: ");
            patobj.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Patient's Address: ");
            patobj.getAddress = Console.ReadLine();
            Console.WriteLine("Enter Patient's Department: ");
            patobj.patientDepartment = Console.ReadLine();

            patientList.Add(patobj);
            foreach (PatientClass patient in patientList)
            {
                Console.WriteLine("Your Entered information is: " + patient.id + "/" + patient.name + "/" + patient.phone + "/" + patient.age + "/"  + "/" + patient.getAddress + "/" + patient.patientDepartment);
            }
            break;

        //case 3 for beds
        case 3:
            BedBooking bedsObj = new BedBooking();

            Console.Write("Enter the department name: ");
            bedsObj.dept_name = Console.ReadLine();
            Console.WriteLine("Enter bed number: ");
            bedsObj.bed_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter patient id: ");
            bedsObj.patient_id = int.Parse(Console.ReadLine());
            bedsList.Add(bedsObj);
            foreach (BedBooking bed in bedsList)
            {
                Console.WriteLine("Details are: " + bed.dept_name + "/" + bed.bed_number + "/" + bed.patient_id);
            }
            break;
        default:
            Console.WriteLine("Please enter a valid input");
            break;
    }

    Console.WriteLine("Do you want to repeat? Yes(Y) or No (N)");
    repeat = Console.ReadLine();

}