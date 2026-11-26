interface IStudentService
{
    void AddStudent(Student student);
    List<Student> GetStudents();
    void UpdateStudent(Student student);
    void DeleteStudent(int id);
    List<Student> GetStudentsByAge(int age);
    List<Student> GetStudentsByGrade();
}