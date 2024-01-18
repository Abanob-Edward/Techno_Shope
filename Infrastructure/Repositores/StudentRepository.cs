using Appliaction.Contract;
using AutoMapper;
using Context;
using Microsoft.EntityFrameworkCore;
using Model.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositores
{
    public class StudentRepository : Repository<Student,int>, IStudentRepository
    {
        private readonly _Context context;
        //private readonly IMapper mapper;
        public StudentRepository(_Context _context ) : base(_context)
        {
           // mapper = mapper;
            this.context = _context;
        }

        /* private readonly _Context context;
         public StudentRepository(_Context _context)
         {
             context = _context;
         }
         public IQueryable<Student> getAll()
         {
             return context.Students.Select(c=>c);
         }
         public Student? getByID(int id)
         {
             if (id != 0) 
             {
                 return context.Students.FirstOrDefault(x => x.ID == id);
             }
             return null;
         }



         public Student add(Student student) {
             var result = context.Add(student).Entity;
             context.SaveChanges();
             return result;


         }

         public Student update(Student student) {

             var std = context.Students.Update(student).Entity;

             context.SaveChanges();
             return std;
         }
         public void delete(int id) {
             // test it again

             var result = context.Remove(id).Entity;
             context.SaveChanges();

         }
 */
        public IQueryable<Student> SearchByName(string Name)
        {
            return context.Students.Where(x => x.Name.Contains(Name));
        }

     
    }
}
