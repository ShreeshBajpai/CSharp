//connection string (db connection) 
using FileHandling;
using System.Data.SqlClient;

SqlConnection con = new SqlConnection("server=localhost;database=Bank;integrated security=true");
string isrepeat = "Y";
EmployeeClass emp = new EmployeeClass();

string empFile = @"C:\Users\shreesh.bajpai\source\repos\FileHandling\FileHandling.txt";

try
{
    while (isrepeat.ToUpper() == "Y")
    {
        Console.Write("Enter Employee's ID: ");
        emp.eid = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee's Name: ");
        emp.name = Console.ReadLine();

        Console.Write("Enter Employee's Address: ");
        emp.address = Console.ReadLine();


        //insertion command creation
        SqlCommand cmd = new SqlCommand("insert into Employee values( " + emp.eid + "  , '" + emp.name + "' , ' " + emp.address + " ')", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Console.WriteLine("Record Inserted Successfully");

        if (!File.Exists(empFile))
        {
            using (StreamWriter sw = File.CreateText(empFile))
            {
                sw.WriteLine($"Employee's Id = {emp.eid}, Employee's name = {emp.name}, Employee's Address = {emp.address}");
            }
        }
        else
        {
            using (StreamWriter sw = File.AppendText(empFile))
            {
                sw.WriteLine($"EId = {emp.eid}, Ename = {emp.name}, Address = {emp.address}");
            }
        }

        Console.WriteLine("\n\nThe entries in text files are:\n");

        using (StreamReader sr = File.OpenText(empFile))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }

        Console.WriteLine("Do you want to repeat? Y or N");
        isrepeat = Console.ReadLine();
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}