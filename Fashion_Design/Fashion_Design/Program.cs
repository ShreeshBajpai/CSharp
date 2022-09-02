using Fashion_Design;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;
using static Fashion_Design.Category;
using static Fashion_Design.Products;

string isRepeat = "Y";

Products prod = new Products();
Category cat = new Category();

//connection string (db connection) 
SqlConnection con = new SqlConnection("server=localhost;database=fashionDesign;integrated security=true");

while (isRepeat == "Y" || isRepeat == "y")
{
    Console.WriteLine("Enter your choice -  ");
    Console.WriteLine("Press 1 for Data Insertion in Category Table");
    Console.WriteLine("Press 2 for Data Insertion in Products table");
    Console.WriteLine("Press 3 for Data Deletion in Products table");
    Console.WriteLine("Press 4 for Data Updation in Products table");
    Console.WriteLine("Press 5 for Data Search in Products table");
    Console.WriteLine("Press 6 for Matching Data to Adidas using interface");

    Console.WriteLine("Enter your choice -  ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            delegateCategoryName obj = new delegateCategoryName(Message);
            Console.WriteLine("Enter Category Id: ");
            cat.c_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Category Name : ");
            string s = Console.ReadLine();
            obj(s);
            Console.WriteLine(s);


            //command creation
            SqlCommand cmd = new SqlCommand("insert into category values( " + cat.c_id + "  ,' " + obj(s) + " ')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Record Inserted Successfully");
            Console.WriteLine("Inserted Category Name is : "+s);
            break;

        case 2:
            delegateProductName obj2 = new delegateProductName(ProductName);
            Console.WriteLine("Enter Product Id: ");
            prod.p_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Category Id of Product: ");
            prod.c_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name: ");
            string str = Console.ReadLine();
            obj2(str);
            Console.WriteLine(str);
            Console.WriteLine("Enter Price of Product: ");
            prod.p_price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity of Product: ");
            prod.p_quantity = int.Parse(Console.ReadLine());

            //command creation
            SqlCommand cmd2 = new SqlCommand("insert into products values( " + prod.p_id + "  , " + prod.c_id + "  ,' " + obj2(str) + " ', "+ prod.p_price + ", "+ prod.p_quantity + ")", con);
            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Record Inserted Successfully");
            break;

        case 3:
            Console.WriteLine("Enter ID of Product to be deleted : ");
            prod.p_id = int.Parse(Console.ReadLine());

            SqlCommand cmd3 = new SqlCommand("delete from products where id=" + prod.p_id + " ", con);
            con.Open();
            cmd3.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Record deleted successfully!!");
            break;

        case 4:
            Console.WriteLine("Enter the id to be updated");
            prod.p_id = int.Parse(Console.ReadLine());
            delegateProductName obj3 = new delegateProductName(ProductName);
            Console.WriteLine("Enter Product Name to be updated: ");
            string str3 = Console.ReadLine();
            obj3(str3);
            

            SqlCommand cmd4 = new SqlCommand("update products set p_name= '" + obj3(str3) + "' where p_id=" + prod.p_id + "", con);

            con.Open();
            cmd4.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Record updated successfully!!");
            break;

        case 5:
            Console.WriteLine("Enter the id to be searched");
            prod.p_id = int.Parse(Console.ReadLine());
            SqlDataAdapter da = new SqlDataAdapter("select * from products where p_id = " + prod.p_id + "", con);
            //SqlDataAdapter da = new SqlDataAdapter("select * from products ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "products");
            int x = ds.Tables[0].Rows.Count;
            Console.WriteLine("Records found: " + x);
            break;

        case 6 :
            Console.WriteLine("Interface Implementation");
            prod.PInterface("");
            break;

        default:
            Console.WriteLine("Wrong Input!!");
            break;
    }
    Console.WriteLine("Do you want to repeat? Y or N");
    isRepeat = Console.ReadLine();
}
