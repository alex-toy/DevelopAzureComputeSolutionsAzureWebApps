﻿namespace WebAppTrial.Controllers
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
