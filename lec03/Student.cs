namespace StudentNameSpace;

public class Student
{
    //this is the body of the class
    public int StudentId { get; set; }
    public string? Name { get; set; }
    public DateTime Dob { get; set; }

    public void PrintStudentInfo()
    {
        Console.WriteLine($"Id:{StudentId}, Name:{Name}, Date of Birth:{Dob}");
    }
}
