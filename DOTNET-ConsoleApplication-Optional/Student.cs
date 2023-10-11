namespace DOTNET_ConsoleApplication_Optional;

public class Student
{
    public string firstName { get; set; }
    public string lastName { get; set; }

    public List<Subject> Subjects { get; set; }

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