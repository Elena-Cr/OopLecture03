using System;
using StudentNameSpace;



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

