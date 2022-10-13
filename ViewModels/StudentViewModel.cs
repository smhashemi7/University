using Models;

namespace ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        //public string CourseName { get; set; }
        public List<Course> Courses { get; set; }

    }
}