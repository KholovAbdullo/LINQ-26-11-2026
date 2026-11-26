public class StudentService : IStudentService
{
    private List<Student> students = new List<Student>();
    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void DeleteStudent(int id)
    {
        var res = students.FirstOrDefault(x=>x.Id==id);
        if(res != null)
        {
            students.Remove(res); 
        }
    }

    public List<Student> GetStudents()
    {
        return students;
    }

    public List<Student> GetStudentsByAge(int age)
    {
        return students.Where(x=>x.Age==age).ToList();
    }

    public List<Student> GetStudentsByGrade()
    {
        return students.OrderByDescending(x=>x.Grade).ToList();
    }

    public void UpdateStudent(Student student)
    {
        var res = students.FirstOrDefault(x=>x.Id==student.Id);
        if(res != null)
        {
            res.Name=student.Name;
            res.Age=student.Age;
            res.Grade=student.Grade;
        }
    }
}