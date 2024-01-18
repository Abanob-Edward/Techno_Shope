using Model.Models;

namespace Appliaction.Services
{
    public interface IStudentService
    {
        void Addstudent(Student student);
        Student? GetStudentbyID(int id);
        IQueryable<Student> GetSudents();
        public Student UpdateStudent(Student student);
        public void DeleteStudent(int id);
    }
}