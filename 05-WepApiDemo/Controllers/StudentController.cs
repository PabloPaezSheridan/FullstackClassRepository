using Microsoft.AspNetCore.Mvc;

[Route("students")]
[ApiController]
public class StudentController : ControllerBase
{
    [HttpGet]
    public List<Student> GetAllStudents()
    {
        Student student1 = new()
        {
            Code = 1,
            Name = "Pablo",
            Surname = "Paez"
        };

        Student student2 = new()
        {
            Code=2,
            Name="Pepe",
            Surname="Rodriguez"
        };

        List<Student> students = new List<Student>(){student1,student2};
        return students;
    }  
}