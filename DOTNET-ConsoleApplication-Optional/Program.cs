using DOTNET_ConsoleApplication_Optional;

List<Student> students = new List<Student>();
students.Add(new Student("John", "Doe"));
students.Add(new Student("Jane", "Doe"));
students.Add(new Student("John", "Smith"));

List<Subject> subjects = new List<Subject>();
subjects.Add(new Subject("Math", "3 year"));
subjects.Add(new Subject("English", "half a year"));
subjects.Add(new Subject("Science", "2 years"));

foreach (var student in students)
{
    for (int i = 0; i < 2; i++)
    {
        int randomIndex;
        do
        {
            Random random = new Random();
            randomIndex = random.Next(0, subjects.Count);
        } while (student.Subjects.Contains(subjects[randomIndex]));

        student.addSubject(subjects[randomIndex]);
    }
}

foreach (var student in students)
{
    Console.WriteLine($"{student.firstName} {student.lastName}");
    foreach (var subject in student.Subjects)
    {
        Console.WriteLine($"Subject: {subject.name}, Duration: {subject.duration}");
    }
    Console.WriteLine();
}




