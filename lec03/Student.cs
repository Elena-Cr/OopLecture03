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
    public string GetStudentInfo()
    {
        return $"Id:{StudentId}, Name:{Name}, Date of Birth:{Dob}";
    }
    public void AskForStudentInfo()
    {
        Console.WriteLine("Provide details to add student\nProvide Student Id:");
        StudentId = int.Parse(Console.ReadLine());
        Console.WriteLine("Provide Student Name:");
        Name = Console.ReadLine();
        Console.WriteLine("Provide Student Date of Birth in DD-MM-YYYY Format:");
        Dob = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
        Console.WriteLine("Here is the information of the student that was created:");
        PrintStudentInfo();

    }
}
