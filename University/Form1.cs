using Data;
using Models;

namespace University
{
    public partial class Form1 : Form
    {
        UniContext uniContext = new UniContext();   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                //Course course1 = new Course();
                //course1.CourseName = "C#";
                //Course course2 = new Course();
                //course2.CourseName = "Sql";
                //Course course3 = new Course();
                //course3.CourseName = "PhotoShop";

                //GenericRepository<Course> Courseslist = new GenericRepository<Course>(uniContext);

                //Courseslist.Add(course1);
                //Courseslist.Add(course2);
                //Courseslist.Add(course3);

                //Student student = new();
                //student.FirstName = "Akbar";
                //student.LastName = "Akbari";

                //List<Course> courses = new List<Course>();
                //Course course = new Course();

                //GenericRepository<Course> Courseslist = new GenericRepository<Course>(uniContext);
                //course = Courseslist.GetById(1);
                //courses.Add(course);
                //course = Courseslist.GetById(2);
                //courses.Add(course);

                //student.Courses = courses;

                //GenericRepository<Student> students = new GenericRepository<Student>(uniContext);
                //students.Add(student);


                //GenericRepository<Student> students = new GenericRepository<Student>(uniContext);
                //dataGridView1.DataSource = students.GetAll();

                //GenericRepository<Student> students = new GenericRepository<Student>(uniContext);
                //Student student;
                //student = students.GetById(3);
                //student.FirstName = "asghar";

                //List<Course> courses = new List<Course>();
                //Course course = new Course();
                //GenericRepository<Course> Courseslist = new GenericRepository<Course>(uniContext);
                //course = Courseslist.GetById(1);
                //courses.Add(course);
                ////course = Courseslist.GetById(2);
                ////courses.Add(course);

                //student.Courses = courses;

                //students.Update(student);

                StudentRepository studentRepository = new StudentRepository(uniContext);
                dataGridView1.DataSource = studentRepository.GetStudents();

                //GenericRepository<Student> students = new GenericRepository<Student>(uniContext);
                //dataGridView1.DataSource = students.GetByFilters( s => s.FirstName.Contains("m"));
                //dataGridView1.DataSource = students.GetByFiltersOrder(s => s.FirstName.Contains("a"), s=> s.OrderBy(q => q.LastName)).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            //student.Courses = new List<Course>();



            //Person t = new Teacher();

            //t.
        }
    }
}