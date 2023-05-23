using DriveCalendarBE.Entities;
using DriveCalendarBE.Repository.Interfaces;
using DriveCalendarBE.Services.Interfaces;

namespace DriveCalendarBE.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository repo;
        public StudentService(IStudentRepository repo)
        {
            this.repo = repo;
        }
        public int AddStudent(Student student)
        {
            student.IsActive = 1;
            return repo.AddStudent(student);
        }

        public int DeleteStudent(int id)
        {
            return repo.DeleteStudent(id);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return repo.GetAllStudents();
        }

        public Student GetStudentById(int id)
        {
            return repo.GetStudentById(id);
        }

        public int UpdateStudent(Student student)
        {
            return repo.UpdateStudent(student);
        }
    }
}
