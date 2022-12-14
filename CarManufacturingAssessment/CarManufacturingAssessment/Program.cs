using CarManufacturingCost;
using CommonClass;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using CarManufacturingAssessment;
using System.IO;

namespace CarManufacturingAssessment
{
    class Program
    {
        public static void Main(string[] args)
        {
            //db connection string-----------------
            SqlConnection con = new SqlConnection("server=BHAVNAWKS755;database=CarManufacturing;integrated security=true");
            string isrepeat = "Y";
            int choice;
            //objects------------------------------
            Employee emp = new Employee();
            manufacturingCost costObj = new manufacturingCost();
            CommonCls com = new CommonCls();

            //dataset------------------------------
            DataSet ds = new DataSet();

            //file path----------------------------
            string salaryRecord = @"C:\Users\shreesh.bajpai\source\repos\CarManufacturingAssessment\salaryRecord.txt";

            if (File.Exists(salaryRecord))
                File.Delete(salaryRecord);

            //exception handeling------------------
            try
            {
                while (isrepeat.ToUpper() == "Y")
                {
                    Console.WriteLine("Press 1 to distribute the salaries of employees");
                    Console.WriteLine("Press 2 to see the salary distribution of the current month");
                    Console.WriteLine("Press 3 to calculate the total cost of car repairing as well as maintaining the stocks");
                    Console.WriteLine("Press 4 to calculate the total cost of car manufacturing");
                    Console.WriteLine("Press 5 to see the remaining stocks");
                    Console.WriteLine("Press 6 to see balance sheet");

                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the ID of employee");
                            emp.id = int.Parse(Console.ReadLine());

                            //Extrating the required fields from department, employee and totalworkinghrs table  
                            SqlDataAdapter data = new SqlDataAdapter("select hrs.*, e.Employee_Name , e.Dept_id, d.sal_perhour " +
                                "from employeeWorkingHrs hrs inner join Employee e " + 
                                "on hrs.empid = e.empId " +
                                "inner join departmenrt d " +
                                "on d.departmentId = e.deptId", con);

                            if (ds.Tables.CanRemove(ds.Tables["Employee"]))
                                ds.Tables.Remove(ds.Tables["Employee"]);

                            data.Fill(ds, "employeeDetails");

                            int num = ds.Tables["employeeDetails"].Rows.Count;

                            //taking the minimum working hrs in a month to be 184-------------------
                            emp.minWorkingHrs = 184;

                            for (int j = 0; j < num; j++)
                            {
                                if (emp.id.ToString() == ds.Tables["Employee"].Rows[j][0].ToString())
                                {
                                    emp.totalSalary = 0;
                                    int totalworkinghrs = int.Parse(ds.Tables["Employee"].Rows[j][1].ToString());
                                    int salaryPerHour = int.Parse(ds.Tables["Employee"].Rows[j][4].ToString());

                                    //calculating the total salary of an employee----------------------------
                                    emp.totalSalary = totalworkinghrs > emp.minWorkingHrs ?
                                        (totalworkinghrs - emp.minWorkingHrs) * 2 * salaryPerHour + emp.minWorkingHrs * salaryPerHour :
                                        emp.minWorkingHrs * salaryPerHour;

                                    //writing to the salary record file--------------------------------------
                                    if (!File.Exists(salaryRecord))
                                        using (StreamWriter sw = File.CreateText(salaryRecord))
                                        {
                                            sw.WriteLine($"Employee Id: {ds.Tables["Employee"].Rows[j][0].ToString()}, " +
                                                $"Employee Name: {ds.Tables["Employee"].Rows[j][2].ToString()}, " +
                                                $"Employee's Salary of the Month: {emp.totalSalary} ");
                                        }
                                    else
                                        using (StreamWriter sw = File.AppendText(salaryRecord))
                                        {
                                            sw.WriteLine($"Employee Id: {ds.Tables["employeeDetails"].Rows[j][0].ToString()}, " +
                                                 $"Employee Name: {ds.Tables["employeeDetails"].Rows[j][2].ToString()}, " +
                                                 $"Employee's Salary of the Month: {emp.totalSalary} ");
                                        }
                                }
                            }

                            //action delegate to print message--------------------
                            Action<string> message = com.printMessage;
                            message("\nSalary distributed successfully!!\n");
                            break;
                            
                        //Reading the salary records file (admin can see the salary records from here)--------
                        case 2:
                            if (!File.Exists(salaryRecord))
                            {
                                Action<string> msg = com.printMessage;
                                msg("\nFile doesn't exist\n");
                            }
                            else
                            {
                                Console.WriteLine("\nHere are the existing salary records: \n");
                                using (StreamReader sr = File.OpenText(salaryRecord))
                                {
                                    string s = "";
                                    while ((s = sr.ReadLine()) != null)
                                    {
                                        Console.WriteLine(s);
                                    }
                                }
                            }
                            break;

                        //car repairing cost calculation
                        case 3:
                            Console.WriteLine("\nEnter the number of parts which are needed to be replaced");
                            int partsCount = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nEnter the names of parts which are needed to be replaced");

                            //array list to store the parts which are needed to be replaced
                            ArrayList partsList = new ArrayList();

                            string part;

                            while (partsCount > 0)
                            {
                                part = Console.ReadLine();
                                partsList.Add(part);
                                partsCount--;
                            }

                            SqlDataAdapter dataadap = new SqlDataAdapter("select * from parts", con);
                            dataadap.Fill(ds, "parts");

                            int count = ds.Tables["parts"].Rows.Count;
                            int price = 0;
                            int id;

                            foreach (string item in partsList)
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    if (ds.Tables["parts"].Rows[i][1].ToString() == item)
                                    {
                                        //calculation of repairing cost-------------------------
                                        price = int.Parse(ds.Tables["parts"].Rows[i][2].ToString());
                                        costObj.totalPartsCost += price;

                                        //grabbing id of the part which is to be replaced in order to maintain the stocks
                                        id = int.Parse(ds.Tables["parts"].Rows[i][0].ToString());
                                        SqlCommand cmd = new SqlCommand("update stocks set quanity -=1 where part_Id = " + id + "", con);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                    }
                                }
                            }

                            //action delegate to display total repairing cost--------------------
                            Action<int> val = costObj.repairingCost;
                            val(costObj.totalPartsCost);

                            Console.WriteLine("\nStocks updated successfully in the database!!\n");
                            break;

                        //calculating the car manufaturing cost-----------------------------------
                        case 4:
                            SqlDataAdapter da = new SqlDataAdapter("select * from parts", con);
                            da.Fill(ds, "parts");

                            int rowscount = ds.Tables["parts"].Rows.Count;

                            for (int i = 0; i < rowscount; i++)
                            {
                                if (ds.Tables["parts"].Rows[i][1].ToString() == "Window" ||
                                ds.Tables["parts"].Rows[i][1].ToString() == "Door" ||
                                ds.Tables["parts"].Rows[i][1].ToString() == "Glass")
                                {
                                    costObj.totalManufactureCost += 4 * (int)ds.Tables["parts"].Rows[i][2];
                                }
                                else if (ds.Tables["carParts"].Rows[i][1].ToString() == "Bumper")
                                {
                                    costObj.totalManufactureCost += 2 * (int)ds.Tables["parts"].Rows[i][2];
                                }
                                else
                                {
                                    costObj.totalManufactureCost += (int)ds.Tables["parts"].Rows[i][2];
                                }

                                //func delegate to calculate the total manpower cost - it will add manpower cost per part everytime to calculate totalManpowerCost
                                int manpowerCostPerPart = 1500;

                                Func<int, int> cost = costObj.ManpowerCostCal;
                                costObj.totalManpowerCost = cost(manpowerCostPerPart);
                            }
                            Console.WriteLine("\nTotal Cost to manufacture a car: " + (costObj.totalManufactureCost + costObj.totalManpowerCost));
                            break;
                            
                        default:
                            Action<string> invalidOpt = com.printMessage;
                            invalidOpt("\nInvalid option!\n");
                            break;
                    }

                    //action delegate to print message----------------------
                    Action<string> repeatMsg = com.printMessage;
                    repeatMsg("\nDo you want to repeat the process? Y or N\n");
                    isrepeat = Console.ReadLine();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }
    }
}