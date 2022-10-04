using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Student
{
    int rollno;
    string name;
    public Student(int rollno, string name)
    {
        this.rollno = rollno;
        this.name = name;
    }
}
/* public class SerializeExample
{
    public static void Main(string[] args)
    {
        FileStream stream = new FileStream("C:\\Users\\shreesh.bajpai\\source\\repos\\SerializationCSharp\\Serialization.txt", FileMode.OpenOrCreate);
        BinaryFormatter formatter = new BinaryFormatter();

        Student s = new Student(101, "sonoo");
        formatter.Serialize(stream, s);
        stream.Close();
    }
}
*/

public class DeserializeExample
{
    public static void Main(string[] args)
    {
        FileStream stream = new FileStream("C:\\Users\\shreesh.bajpai\\source\\repos\\SerializationCSharp\\Serialization.txt", FileMode.OpenOrCreate);
        BinaryFormatter formatter = new BinaryFormatter();

        Student s = (Student)formatter.Deserialize(stream);
        Console.WriteLine("Rollno: " + s.rollno);
        Console.WriteLine("Name: " + s.name);

        stream.Close();
    }
}