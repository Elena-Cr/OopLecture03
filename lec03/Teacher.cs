namespace TeacherNameSpace;

public class Teacher()
{
    public int TeacherId { get; set; }
    public string? Name { get; set; }
    public DateTime Dob { get; set; }
    public string? Department { get; set; }

    public void PrintTeacherInfo()
    {
        Console.WriteLine($"Id:{TeacherId}, Name:{Name}, Date of Birth:{Dob}, Department:{Department}");
    }
    public string GetTeacherInfo()
    {
        return $"Id:{TeacherId}, Name:{Name}, Date of Birth:{Dob}, Department:{Department}";
    }

}