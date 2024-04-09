public class Student : User
{
    public Student()
    {
        AverageGrade = 3;
    }
    public int AverageGrade { get; set; }

    public string GetCondition()
    {
        if (AverageGrade>6)
            return "Approved";
        return "Fail";
        
    }
}