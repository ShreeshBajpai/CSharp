using Assessment_Sept05;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Xml.Linq;

Franchise fc = new Franchise();
FranchiseLogin flogin = new FranchiseLogin();
Sales sale = new Sales();
Employee emp=new Employee();
Admin ad = new Admin();

string  password, name;

SqlConnection con = new SqlConnection("server=BHAVNAWKS755;database=PizzaInfo;integrated security=true");

string isRepeat = "Y";

while (isRepeat == "Y" || isRepeat == "y")
{
    Console.WriteLine("Press 1 for Admin Login");
    Console.WriteLine("Press 2 for Franchise Login");
    int input = int.Parse(Console.ReadLine());

switch (input)
{
    case 1:
            Console.Write("Enter Admin ID : ");
            ad.id = Console.ReadLine();
            SqlDataAdapter da = new SqlDataAdapter("Select * from alogin", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int y = ds.Tables[0].Rows.Count;
            Console.WriteLine(y);
            for (int i = 0; i <= y; i++)
            {
                if (ad.id.ToString() == ds.Tables[0].Rows[i][0].ToString())
                {
                    Console.Write("Enter Password : ");
                    ad.pass = Console.ReadLine();
                    if (ad.pass.ToString() == ds.Tables[0].Rows[i][1].ToString())
                    {
                        Console.WriteLine("Press 1 for registering franchise");
                        Console.WriteLine("Press 2 to see franchise details");
                        Console.WriteLine("Press 3 to see sales record");
                        Console.Write("Enter Your Choice: ");

                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {

                            Console.WriteLine("Enter details of franchise :");
                            Console.Write("Enter ID of Franchise : ");
                            fc.id = int.Parse(Console.ReadLine());
                            Console.Write("Enter Name of Franchise : ");
                            fc.name = Console.ReadLine();
                            Console.Write("Enter location of Franchise : ");
                            fc.location = Console.ReadLine();

                            //command creation
                            SqlCommand cmd = new SqlCommand("insert into f_details values( " + fc.id + "  ,' " + fc.name + " ' , ' " + fc.location + " ')", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            Console.WriteLine("Record Inserted Successfully");
                        }
                        else if (choice == 2)
                        {
                            Console.Write("Enter Franchise Name to check Record : ");
                            fc.name = Console.ReadLine();
                            SqlDataAdapter da1 = new SqlDataAdapter("select * from f_details where f_name='" + fc.name + "'", con);
                            DataSet ds1 = new DataSet();
                            da1.Fill(ds1);
                            int x = ds1.Tables[0].Rows.Count;
                            for (int k = 0; k < x; k++)
                            {
                                Console.WriteLine(ds1.Tables[0].Rows[k][1].ToString() + " " + ds1.Tables[0].Rows[k][2].ToString());
                            }
                        }
                        else if (choice == 3)
                        {
                            SqlDataAdapter da2 = new SqlDataAdapter("select f_id,sum(s_amount) from sales where s_date = '2022-08-29' group by f_id", con);
                            DataSet ds2 = new DataSet();
                            da2.Fill(ds2);
                            int v = ds2.Tables[0].Rows.Count;
                            int total_sales = 0;
                            if (v > 0)
                            {
                                for (int j = 0; j < v; j++)
                                {
                                    Console.WriteLine("Franchise ID and Sale Price is: ");
                                    Console.WriteLine(ds2.Tables[0].Rows[j][0].ToString() + " " + ds2.Tables[0].Rows[j][1].ToString());
                                    total_sales += int.Parse(ds2.Tables[0].Rows[j][1].ToString());
                                }
                                Console.WriteLine("Franchise ID and Sale Price is: ");
                                Console.WriteLine("Total sales: {0}", total_sales);
                            }
                            else
                            {
                                Console.WriteLine("No Sales for today ...");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong Choice.");
                        }
                    }
                }
            }
            break;

        case 2:
            Console.Write("Enter franchise ID : ");
            flogin.id = Console.ReadLine();
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from flogin", con);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            int xy = ds3.Tables[0].Rows.Count;
            Console.WriteLine(xy);
            for (int i = 0; i <= xy; i++)
            {
                //Console.WriteLine(ds2.Tables[0].Rows[i][1].ToString()+" "+ ds2.Tables[0].Rows[i][2].ToString());
                //Console.WriteLine(name);                      
                if (flogin.id == ds3.Tables[0].Rows[i][0].ToString())
                {
                    Console.Write("Enter Password : ");
                    flogin.pass = Console.ReadLine();
                    if (flogin.pass.ToString() == ds3.Tables[0].Rows[i][0].ToString())
                    {
                        Console.WriteLine("Press 1 for Employee Registration");
                        Console.WriteLine("Press 2 for Salary Distribution");
                        Console.WriteLine("Press 3 for Pizza Sale Mode");
                        Console.Write("Enter Your Choice: ");
                        int choice2 = int.Parse(Console.ReadLine());
                        if (choice2 == 1)
                        {
                            Console.Write("Enter Employee ID : ");
                            emp.Id = int.Parse(Console.ReadLine());
                            Console.Write("Enter Employee's Franchise ID : ");
                            emp.FranchiseId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Employee's Name : ");
                            emp.Name = Console.ReadLine();
                            Console.Write("Enter Employee Salary : ");
                            emp.Salary = int.Parse(Console.ReadLine());
                            SqlCommand cmd2 = new SqlCommand("insert into employee values( " + emp.Id + ", " + emp.FranchiseId +"  ,' " + emp.Name + " ' , " + emp.Salary +" )", con);
                            con.Open();
                            cmd2.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (choice2 == 2)
                        {
                            SqlDataAdapter da4 = new SqlDataAdapter("select * from sales orderby salary", con);
                            DataSet ds4 = new DataSet();
                            da4.Fill(ds4);
                            int w = ds4.Tables[0].Rows.Count;
                            if (w <= 0) Console.WriteLine("No Sales.");
                            else
                            {
                                for (int j = 0; j < w; j++)
                                {
                                    Console.WriteLine(ds4.Tables[0].Rows[j][1].ToString() + " " + ds4.Tables[0].Rows[j][2].ToString() + " " + ds4.Tables[0].Rows[j][3].ToString() + " " + ds4.Tables[0].Rows[j][4].ToString());
                                }
                            }

                        }
                        else if (choice2==3)
                        {
                            SqlDataAdapter da5 = new SqlDataAdapter("select s_id, s_mode, f_id, s_amount, s_date from sales orderby s_mode", con);
                            DataSet ds5 = new DataSet();
                            da5.Fill(ds5);
                            int w = ds5.Tables[0].Rows.Count;
                            if (w <= 0) Console.WriteLine("No Sales.");
                            else
                            {
                                for (int j = 0; j < w; j++)
                                {
                                    Console.WriteLine(ds5.Tables[0].Rows[j][1].ToString() + " " + ds5.Tables[0].Rows[j][2].ToString() + " " + ds5.Tables[0].Rows[j][3].ToString() + " " + ds5.Tables[0].Rows[j][4].ToString());
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter the right choice. ");
                        }
                    }
                }
            }
            break;
        default:
            Console.WriteLine("Wrong Input!!");
            break;

    }
    Console.WriteLine("Do you want to repeat? Y or N");
    isRepeat = Console.ReadLine();
}
