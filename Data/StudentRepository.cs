using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Data
{
    public class StudentRepository : GenericRepository<Student>
    {
        UniContext _uniContext;
        public StudentRepository(UniContext dbContext) : base(dbContext)
        {
            _uniContext = dbContext;
            //test web
        }

      
        public List<StudentCourseViewModel> GetStudents()
        {
            return _uniContext.StudentCourse.Include(sc => sc.Student).ThenInclude(s => s.Courses).Select(svm => new StudentCourseViewModel()
            {
                Id = svm.StudentId,
                FullName = svm.Student.FirstName + " " + svm.Student.LastName,
                CourseName = svm.Course.CourseName,
            }).ToList();
        }
    }
}
