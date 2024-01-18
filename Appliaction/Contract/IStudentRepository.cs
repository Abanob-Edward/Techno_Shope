using Model.Models;

namespace Appliaction.Contract
{
    public interface IStudentRepository : IG_Repo<Student, int>
    {
       /* Student add(Student student);
        void delete(int id);
        List<Student> getAll();
        Student getByID(int? id);
        Student update(Student student);*/

        public IQueryable<Student> SearchByName(string Name );
    }
}