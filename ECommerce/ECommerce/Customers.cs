﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
   
        public class Customers : ICustomers
        {
            public int custID;
            public string name, gender, email;

            public void getCust()
            {
                Console.WriteLine("Please enter the customer details:");
                this.custID = int.Parse(Console.ReadLine());
                this.name = Console.ReadLine();
                this.gender = Console.ReadLine();
                this.email = Console.ReadLine();
            }

            public void showCust()
            {
                Console.WriteLine("Here are the details you entered");
                Console.WriteLine(this.custID);
                Console.WriteLine(this.name);
                Console.WriteLine(this.gender);
                Console.WriteLine(this.email);
            }
        }
}
