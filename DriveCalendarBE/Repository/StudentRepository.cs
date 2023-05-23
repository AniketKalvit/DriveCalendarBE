using DriveCalendarBE.Entities;
using DriveCalendarBE.Repository.Interfaces;

namespace DriveCalendarBE.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int AddStudent(Student student)
        {
            int result = 0;
            _context.Students.Add(student);
            result = _context.SaveChanges();
            return result;
        }

        public int DeleteStudent(int id)
        {
            int result = 0;
            var stud = _context.Students.Where(x => x.StudentId == id).FirstOrDefault();
            if(stud != null)
            {
                stud.IsActive = 0;
                result = _context.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.Where(x => x.IsActive == 1).ToList();
        }

        public Student GetStudentById(int id)
        {
            var stud = _context.Students.Where(x => x.StudentId == id).FirstOrDefault();
            return stud;
        }

        public int UpdateStudent(Student student)
        {
            int result = 0;
            var stud = _context.Students.Where(x => x.StudentId == student.StudentId).FirstOrDefault();
            if (stud != null)
            {
                stud.StudentName = student.StudentName;
                stud.BatchName = student.BatchName;
                stud.Ratings = student.Ratings;
                stud.IsActive = 1;
                result = _context.SaveChanges();
            }
            return result;
        }
    }
}
