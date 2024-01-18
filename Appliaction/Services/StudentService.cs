using Appliaction.Contract;
using AutoMapper;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Services
{

    /// <summary>
    /// this class can Implement All Business  logic here 
    /// </summary>
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;
       // privat
        public StudentService(IStudentRepository _studentRepository)
        {
          
            studentRepository = _studentRepository;
        }
        public IQueryable<Student> GetSudents()
        {
            return studentRepository.getAll();
        }

        public Student? GetStudentbyID(int id)
        {
            if (id != 0)
            {
                return studentRepository.getByID(id);
            }
            else
                return null;
        }

        public void Addstudent(Student student)
        {
            studentRepository.add(student);
        }

        public Student UpdateStudent(Student student)
        {
          return   studentRepository.update(student);
        }

        public void DeleteStudent(int id)
        {
            studentRepository.delete(id);
        }
    }
}
