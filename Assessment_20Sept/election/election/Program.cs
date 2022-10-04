using election.Interfaces;
using election.Models;
using election.Threading;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace election
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("server=BHAVNAWKS755;database=election;integrated security=true");


            /*Console.WriteLine("enter your Constituency Code");
            try
            {


                for (int i = 0; i < x; i++)
                {



                    if ((lg.pass.ToString() == ds.Tables[0].Rows[i][1].ToString()) && (lg.voter_id.ToString() == ds.Tables[0].Rows[i][3].ToString()) && (lg.mpin.ToString() == ds.Tables[0].Rows[i][4].ToString()))
                    {
                        //Console.WriteLine();
                        Console.WriteLine("Login Successfull...");
                        Console.WriteLine();
                        string ans = "Y";
                        for (; ans.ToUpper() == "Y";)
                        {
                            Console.WriteLine("---Enter 1 for Inserting the data for Registering the User");
                            Console.WriteLine("---Enter 2 for Inserting the data into Voting table");
                            Console.WriteLine("---Enter 3 for ");
                            Console.WriteLine("---Enter 4 for Inserting the data into products");
                            Console.WriteLine("---Enter 5 for Inserting the data into working_hours and to know the total payment");
                            Console.WriteLine("---Enter 6 for Inserting the data into salary ");
                            Console.WriteLine("---Enter 7 for Knowing the Selling Price");
                            Console.WriteLine("---Enter 8 for Inserting the data into Part and creating a file for it");

                            nn = int.Parse(s: Console.ReadLine());


                            voting v = new voting();

                            employee emp = new employees();
                            parts pa = new parts();
                            product p = new product();
                            salaryy s = new salaryy();
                            working_hour wh = new working_hour();

                            switch (nn)
                            {
                                case 1:

                                    Console.WriteLine("Enter Voter ID");
                                    v.voter_id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter Constituency ID");
                                    v.constituency_id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter Vote ID");
                                    v.vote_id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter Voting Party");
                                    v.voting_party = Console.ReadLine();
                                case 3:

                                    SqlDataAdapter dataadap = new SqlDataAdapter("select * from part", con);
                                    DataSet dd = new DataSet();
                                    dataadap.Fill(dd, "part");

                                    Console.Write("This is the parts that are available : ");


                                    int y = dd.Tables[0].Rows.Count;
                                    Console.WriteLine("");
                                    for (int e = 0; e < y; e++)
                                    {

                                        Console.WriteLine("Part Name= " + dd.Tables[0].Rows[e][1].ToString() + ",  Part Cost= " + dd.Tables[0].Rows[e][2].ToString());

                                    }


                                    break;


                                default:
                                    Console.WriteLine("You entered Invalid Input");
                                    break;


                            }

                            Console.WriteLine("Do You Want To Continue?(Y/N)- ");
                            ans = Console.ReadLine();
                        }

                    }


                    else
                    {
                        Console.WriteLine("Invalid Login");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
            */




            Console.WriteLine("Press 1 for login \nPress 2 register");
            int login_choice = int.Parse(Console.ReadLine());
            switch (login_choice)
            {
                case 1:

                    Console.WriteLine("------Hello Dear Voter------");
                    Console.WriteLine();
                    ILogin lg = new Login();
                    Console.Write("Enter Voter ID: ");
                    lg.voter_id = Console.ReadLine();
                    Console.Write("Enter password: ");
                    lg.pass = Console.ReadLine();

                    Console.Write("Enter Mpin: ");
                    lg.mpin = int.Parse(Console.ReadLine());


                    SqlDataAdapter da_login = new SqlDataAdapter("select * from admin_user ", con);

                    DataSet ds_login = new DataSet();
                    da_login.Fill(ds_login, "login");
                    int x = ds_login.Tables[0].Rows.Count;
                    int flag = 0;


                    for (int j = 0; j < x; j++)
                    {
                        if ((lg.pass.ToString() == ds_login.Tables[0].Rows[j][1].ToString()) && (lg.voter_id.ToString() == ds_login.Tables[0].Rows[j][3].ToString()) && (lg.mpin.ToString() == ds_login.Tables[0].Rows[j][4].ToString()))
                        {
                            MyThread.PrintDotAnimation();
                            Console.WriteLine("User login successful !");
                            flag = 1;
                        }
                    }
                    if (flag == 0)
                    {
                        Console.WriteLine("!! Login Not valid !!");
                    }

                    if (flag == 1)
                    {
                        Console.WriteLine("Press 1 to give vote");
                        Console.WriteLine("Press 2 to view all votes of party in a perticular constituency");
                        Console.WriteLine("Press 3 to view winner in a particular constituency");

                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                SqlDataAdapter da_vote_check = new SqlDataAdapter("Select * from voting", con);
                                DataSet ds_vote_check = new DataSet();
                                da_vote_check.Fill(ds_vote_check);
                                int xy = ds_vote_check.Tables[0].Rows.Count;

                                string abc = lg.voter_id;
                                int vote_check = 0;

                                for (int i = 0; i <= xy; i++)
                                {

                                    if (lg.voter_id.ToString() == ds_vote_check.Tables[0].Rows[i][0].ToString())
                                    {
                                        vote_check = 1;

                                        break;
                                    }
                                    if (lg.voter_id.ToString() != ds_vote_check.Tables[0].Rows[i][0].ToString())
                                    {
                                        vote_check = 0;
                                        break;
                                    }

                                }
                                if (vote_check == 1)
                                {
                                    Console.WriteLine("You have already voted");
                                    SqlDataAdapter da_vote_find = new SqlDataAdapter("Select * from voting where voter_id='" + lg.voter_id + "'", con);
                                    DataSet ds_vote_find = new DataSet();
                                    da_vote_find.Fill(ds_vote_find);
                                    Console.WriteLine("Voting constituency_id: " + ds_vote_find.Tables[0].Rows[0][1].ToString());
                                    Console.WriteLine("Votied party: " + ds_vote_find.Tables[0].Rows[0][3].ToString());

                                }

                                else
                                {
                                    Console.WriteLine("Congrats you can give the  vote...");
                                    MyThread.PrintDotAnimation();

                                    SqlDataAdapter da_constituency = new SqlDataAdapter("select * from constituency", con);
                                    DataSet ds_constituency = new DataSet();
                                    da_constituency.Fill(ds_constituency, "constituency");

                                    Console.WriteLine("Here is the constituency!");
                                    int x_contituency = ds_constituency.Tables[0].Rows.Count;

                                    for (int j = 0; j < x_contituency; j++)
                                    {
                                        Console.WriteLine("Constituency Code : " + ds_constituency.Tables[0].Rows[j][0].ToString());
                                        Console.WriteLine("Constituency Name : " + ds_constituency.Tables[0].Rows[j][1].ToString());

                                    }
                                    Console.Write("Please view the constituency and type your contituency id: ");

                                    int searched_ds_constituency = int.Parse(Console.ReadLine());

                                    SqlDataAdapter da_constituency_search = new SqlDataAdapter("select * from candidate where constituency_id=" + searched_ds_constituency + "", con);
                                    DataSet ds_constituency_search = new DataSet();
                                    da_constituency_search.Fill(ds_constituency_search, "candidate");
                                    int x_contituency_search = ds_constituency_search.Tables[0].Rows.Count;
                                    for (int j = 0; j < x_contituency_search; j++)
                                    {
                                        Console.WriteLine("Candidate Id : " + ds_constituency_search.Tables[0].Rows[j][0].ToString());
                                        Console.WriteLine("Candidate Name : " + ds_constituency_search.Tables[0].Rows[j][1].ToString());
                                        Console.WriteLine("constituency Name : " + ds_constituency_search.Tables[0].Rows[j][2].ToString());
                                        Console.WriteLine("Party Name : " + ds_constituency_search.Tables[0].Rows[j][3].ToString());
                                        Console.WriteLine("");

                                    }

                                    Console.WriteLine("Please type your Party name to whome you want to vote");
                                    string party = Console.ReadLine();


                                    SqlCommand cmd = new SqlCommand("insert into voting values('" + lg.voter_id + "'," + searched_ds_constituency + ",'" + party + "')", con);

                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();

                                    Console.WriteLine("Vote Inserted Successfully");

                                }


                                break;

                            case 2:
                                Console.Write("Write Party name: ");
                                string party_name = Console.ReadLine();

                                Console.Write("Write constituency ID: ");
                                int contituent_id = int.Parse(Console.ReadLine());
                                SqlDataAdapter da_vote_count = new SqlDataAdapter("SELECT COUNT(vote_id) FROM voting WHERE voting_party='" + party_name + "' and constituency_id=" + contituent_id + "", con);

                                DataSet ds_vote_count = new DataSet();
                                da_vote_count.Fill(ds_vote_count, "SELECT COUNT(vote_id) FROM voting WHERE voting_party='" + party_name + "' and constituency_id=" + contituent_id + "");

                                Console.WriteLine("Total vote of " + party_name + " are " + ds_vote_count.Tables[0].Rows[0][0].ToString());

                                break;

                            case 3:
                                Console.Write("Enter constituency ID to check winner: ");
                                int constituency_winner = int.Parse(Console.ReadLine());
                                Console.WriteLine("Finding The winner...");
                                MyThread.PrintDotAnimation();
                                SqlDataAdapter da_constituency_search_winner = new SqlDataAdapter("select * from candidate where constituency_id=" + constituency_winner + "", con);
                                DataSet ds_constituency_search_winner = new DataSet();
                                da_constituency_search_winner.Fill(ds_constituency_search_winner, "candidate");
                                int x_constituency_winner = ds_constituency_search_winner.Tables[0].Rows.Count;

                                Console.WriteLine("All candidates are :- ");
                                for (int j = 0; j < x_constituency_winner; j++)
                                {
                                    Console.WriteLine("Candidate Id : " + ds_constituency_search_winner.Tables[0].Rows[j][0].ToString());
                                    Console.WriteLine("Candidate Name : " + ds_constituency_search_winner.Tables[0].Rows[j][1].ToString());
                                    Console.WriteLine("constituency Name : " + ds_constituency_search_winner.Tables[0].Rows[j][2].ToString());
                                    Console.WriteLine("Party Name : " + ds_constituency_search_winner.Tables[0].Rows[j][3].ToString());
                                    Console.WriteLine("");
                                }
                                Console.WriteLine("Finding The winner...");
                                MyThread.PrintDotAnimation();
                                int count = 0;
                                string path = @"C:\Users\shreesh.bajpai\source\repos\Assessment_20Sept\record.txt";
                                int[] Vote_win = new int[20];
                                string[] win_name = new string[20];
                                for (int j = 0; j < x_constituency_winner; j++)
                                {
                                    SqlDataAdapter da_vote_count_winner = new SqlDataAdapter("SELECT COUNT(vote_id) FROM voting WHERE voting_party='" + ds_constituency_search_winner.Tables[0].Rows[j][3].ToString() + "' and constituency_id=" + constituency_winner + "", con);
                                    DataSet ds_vote_count_winner = new DataSet();
                                    da_vote_count_winner.Fill(ds_vote_count_winner);
                                    Vote_win[j] = int.Parse(ds_vote_count_winner.Tables[0].Rows[0][0].ToString());
                                    count++;
                                    Console.WriteLine("Party " + ds_constituency_search_winner.Tables[0].Rows[j][3].ToString() + " Got " + Vote_win[j] + " Votes");
                                    using (StreamWriter sw = File.AppendText(path))
                                    {
                                        sw.WriteLine("Party " + ds_constituency_search_winner.Tables[0].Rows[j][3].ToString() + " Got " + Vote_win[j] + " Votes");
                                    }
                                    win_name[j] = "Party " + ds_constituency_search_winner.Tables[0].Rows[j][3].ToString() + "Got " + Vote_win[j] + "Votes";
                                    da_vote_count_winner.Dispose();
                                    ds_vote_count_winner.Dispose();

                                }
                                int maxValue = Vote_win.Max();
                                int maxIndex = Vote_win.ToList().IndexOf(maxValue);
                                string winner = "Winner is: " + win_name[maxIndex];

                                Console.WriteLine("winner is: " + win_name[maxIndex]);


                                using (StreamWriter sw = File.AppendText(path))

                                {

                                    sw.WriteLine(winner);

                                }

                                //Console.WriteLine("...Sheet Record Inserted Succesfully in file...");
                                List<string> names = new List<string>();
                                names.Add("Sheet Record ");
                                names.Add("Inserted Succesfully in file");
                                names.ForEach(delegate (string name)
                                {
                                    Console.WriteLine(name);
                                });
                                names.ForEach(Print);
                                void Print(string s)
                                {
                                    Console.WriteLine(s);
                                }

                                break;

                            default:
                                Console.WriteLine("invalid choice");
                                break;
                        }
                    }
                    break;
                case 2:

                    IUserRegistration ur = new UserRegistration();
                    Console.WriteLine("----------Welcome to User Registration----------\nEnter User ID:");
                    ur.id = int.Parse(Console.ReadLine());
                    Console.Write("Enter your Password: ");
                    ur.pass = Console.ReadLine();
                    Console.Write("Enter your Aadhar: ");
                    ur.aadhar = Console.ReadLine();
                    Console.Write("Enter your Voter ID: ");
                    ur.voter_id = Console.ReadLine();
                    Console.Write("Enter your mPIN: ");
                    ur.mpin = int.Parse(Console.ReadLine());
                    SqlCommand cmd3 = new SqlCommand("insert into admin_user values( " + ur.id + "  ,' " + ur.pass + " ' , ' " + ur.aadhar + " ', ' " + ur.voter_id + " ', " + ur.mpin + " )", con);
                    con.Open();
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine("Record Inserted Successfully...........");
                    break;
            }
        }
    }
}