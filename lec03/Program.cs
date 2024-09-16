using System;
using StudentNameSpace;
using TeacherNameSpace;



//instantiation of a class
Student student1 = new()
{
    StudentId = 1,
    Name = "Bruce Wayne",
    Dob = DateTime.Now
};

//!way1
// Student student2 = new();
// student2.StudentId = 2;
// student2.Name = "Edward Nygma";
// student2.Dob = DateTime.Now;

//!way 2
Student student2 = new()
{
    StudentId = 2,
    Name = "Edward Nygma",
    Dob = DateTime.Now
};

student2.PrintStudentInfo();
// Console.WriteLine("Provide details to add student\nProvide Student Id:");
// student1.StudentId = int.Parse(Console.ReadLine());
// Console.WriteLine("Provide Student Name:");
// student1.Name = Console.ReadLine();
// Console.WriteLine("Provide Student Date of Birth in DD-MM-YYYY Format:");
// student1.Dob = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
// student1.PrintStudentInfo();

Teacher teacher1 = new()
{
    TeacherId = 01,
    Name = "John Doe",
    Degree = "MSc in IT",
    Department = "IT",
    YearsOfExperience = 12

};
