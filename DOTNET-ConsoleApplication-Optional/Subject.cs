namespace DOTNET_ConsoleApplication_Optional;

public class Subject
{
    public string name { get; set; }
    public string duration { get; set; }
    
    public Subject(string name, string duration)
    {
        this.name = name;
        this.duration = duration;
    }
}