class StudentsManager
{
    private List<string> students = new List<string>();

    public void AddStudent(string name)
    {
        students.Add(name);
    }

    public bool RemoveStudent(string name)
    {
        return students.Remove(name);
    }

    public bool SearchStudent(string partialName)
    {
        return students.Exists(s => s.Contains(partialName));
    }

    public void DisplayStudentCount()
    {
        Console.WriteLine($"Number of students: {students.Count}");
    }
}
