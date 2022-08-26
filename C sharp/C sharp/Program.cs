using System;
// using Student;
namespace C_sharp
{
    static void Main(string[] args)
    {
        Student stn = new Student();
        stn.sid = int.Parse(Console.ReadLine());

        Teacher tch = new Teacher();
        tch.Tid = int.Parse(Console.ReadLine());
        tch.Tname = Console.ReadLine();
        tch.show();
    }
}
