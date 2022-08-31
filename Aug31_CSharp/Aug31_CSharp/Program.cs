using Aug31_CSharp;

SumClass Obj = new SumClass();

Console.WriteLine("Sum of two integers using add function:\n" + Obj.Add(3, 9));
Console.WriteLine("Sum of three integers using add function:\n" + Obj.Add(6, 12, 4));

// Method Overriding
InheritanceClass childObj = new InheritanceClass();

Console.WriteLine("Adding two integers using add function of the child class:");
Console.WriteLine(childObj.Add(3, 9));


// Access Specifiers

Access_Modifiers accObj = new Access_Modifiers();

Console.WriteLine("Enter 2 numbers for the public variables:");
accObj.pubA = int.Parse(Console.ReadLine());
accObj.pubB = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a number for the protected variable:");
accObj.getProtA = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a number for the private variable:");
accObj.getPrivA = int.Parse(Console.ReadLine());

Console.WriteLine("Numbers you entered for the public variables are: " + accObj.pubA + " & " + accObj.pubB);
Console.WriteLine("Numbers you entered for the protected variable is: " + accObj.getProtA);
Console.WriteLine("Numbers you entered for the private variable is: " + accObj.getPrivA);
