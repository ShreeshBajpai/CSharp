using System;
namespace BhavnaCorp;

class Program
{
    static void Main(String[] args)
    {


        String name="", ID="";
        string answer = "Y";
        for (; answer.ToUpper() == "Y";)
        {
            int pal, arm, rollno=10;
            String s_name = "Abc";
            Console.WriteLine("Press 1 for Entering a Student Detail");
            Console.WriteLine("Press 2 for Showing the Student Detail");
            Console.WriteLine("Press 3 for checking a palindrome");
            Console.WriteLine("Press 4 for checking a armstrong number");
            Console.WriteLine("Enter your choice : ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
           
                case 1:
                    Console.WriteLine("Enter the Roll no: - ");
                    ID = Console.ReadLine();
                    Console.WriteLine("Enter the Name: - ");
                    name = Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Roll no is : " + ID);
                    Console.WriteLine("Name is : " + name);
                    break;


                case 3:
                    Console.Write("Enter a Number To Check Palindrome : ");
                    pal = int.Parse(Console.ReadLine());
                    int remainder, sum = 0;
                    int temp = pal;
                    while (pal > 0)
                    {

                        remainder = pal % 10;
                        //multiply the sum with 10 and then add the remainder
                        sum = (sum * 10) + remainder;
                        //Get the quotient by dividing the number with 10 
                        pal = pal / 10;
                    }
                    if (temp == sum)
                    {
                        Console.WriteLine($"Number {temp} is Palindrome.");
                    }
                    else
                    {
                        Console.WriteLine($"Number {temp} is not Palindrome");
                    }
                    break;
                case 4:

                    int num, r, summ = 0, tempo;
                    Console.Write("Enter the Number= ");
                    num = int.Parse(Console.ReadLine());
                    tempo = num;
                    while (num > 0)
                    {
                        r = num % 10;
                        summ = summ + (r * r * r);
                        num = num / 10;
                    }
                    if (tempo == summ)
                        Console.Write("Armstrong Number.");
                    else
                        Console.Write("Not Armstrong Number.");
                    break;
                    
            }
            Console.WriteLine("Do you want to continue (Y/N)?");
            answer = Console.ReadLine();
        }
    }
}using System;
namespace BhavnaCorp;

class Program
{
    static void Main(String[] args)
    {


        String name="", ID="";
        string answer = "Y";
        for (; answer.ToUpper() == "Y";)
        {
            int pal, arm, rollno=10;
            String s_name = "Abc";
            Console.WriteLine("Press 1 for Entering a Student Detail");
            Console.WriteLine("Press 2 for Showing the Student Detail");
            Console.WriteLine("Press 3 for checking a palindrome");
            Console.WriteLine("Press 4 for checking a armstrong number");
            Console.WriteLine("Enter your choice : ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
           
                case 1:
                    Console.WriteLine("Enter the Roll no: - ");
                    ID = Console.ReadLine();
                    Console.WriteLine("Enter the Name: - ");
                    name = Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Roll no is : " + ID);
                    Console.WriteLine("Name is : " + name);
                    break;


                case 3:
                    Console.Write("Enter a Number To Check Palindrome : ");
                    pal = int.Parse(Console.ReadLine());
                    int remainder, sum = 0;
                    int temp = pal;
                    while (pal > 0)
                    {

                        remainder = pal % 10;
                        //multiply the sum with 10 and then add the remainder
                        sum = (sum * 10) + remainder;
                        //Get the quotient by dividing the number with 10 
                        pal = pal / 10;
                    }
                    if (temp == sum)
                    {
                        Console.WriteLine($"Number {temp} is Palindrome.");
                    }
                    else
                    {
                        Console.WriteLine($"Number {temp} is not Palindrome");
                    }
                    break;
                case 4:

                    int num, r, summ = 0, tempo;
                    Console.Write("Enter the Number= ");
                    num = int.Parse(Console.ReadLine());
                    tempo = num;
                    while (num > 0)
                    {
                        r = num % 10;
                        summ = summ + (r * r * r);
                        num = num / 10;
                    }
                    if (tempo == summ)
                        Console.Write("Armstrong Number.");
                    else
                        Console.Write("Not Armstrong Number.");
                    break;
                    
            }
            Console.WriteLine("Do you want to continue (Y/N)?");
            answer = Console.ReadLine();
        }
    }
}