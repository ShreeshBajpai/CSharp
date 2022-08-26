using CSharp;
using System;

    Student stn = new Student();
    Teacher tch = new Teacher();
    Console.WriteLine("Enter Id: ");
    stn.Sid = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Name: ");
    stn.Sname = Console.ReadLine();
    stn.show();

