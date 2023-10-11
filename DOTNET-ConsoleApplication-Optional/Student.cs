namespace DOTNET_ConsoleApplication_Optional;

public class Student
{
    private string firstName { get; set; }
    private string lastName { get; set; }
    
    private List<Subject> Subjects { get; set; }

    public Student(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        Subjects = new List<Subject>();
    }
    
    public void addSubject(Subject subject)
    {
        Subjects.Add(subject);
    }
}