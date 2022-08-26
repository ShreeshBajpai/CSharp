using System;
namespace C_sharp
{
    class Teacher
    {
        public int Tid { get; set; }
        public string Tname { get; set; }
    }
    public void show()
    {
        Console.WriteLine(Tid + "/" + Tname);
    }
}
