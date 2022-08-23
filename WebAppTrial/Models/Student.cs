namespace WebAppTrial.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Course> Courses { get; set; }

        public Student(ICollection<Course> courses)
        {
            Courses = courses;
        }
    }
}
