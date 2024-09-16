namespace TeacherNameSpace;

public class Teacher()
{
    public int TeacherId { get; set; }
    public string? Name { get; set; }
    public int YearsOfExperience { get; set; }
    public string? Degree { get; set; }
    public string? Department { get; set; }

    public void PrintTeacherInfo()
    {
        Console.WriteLine($"Id:{TeacherId}, Name:{Name}, Degree:{Degree}, Department:{Department},Years of Experience:{YearsOfExperience}");
    }
    public string GetTeacherInfo()
    {
        return $"Id:{TeacherId}, Name:{Name}, Degree:{Degree}, Department:{Department},Years of Experience:{YearsOfExperience}";
    }

}