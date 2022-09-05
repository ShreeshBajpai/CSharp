using System;
using OperatorOverloading;
namespace September_2
{
    private Student std1 = new Student();
        std1.StudentName = "Bill";

        ChangeReferenceType(std1);

        Console.WriteLine(std1.StudentName);

}