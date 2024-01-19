using Appliaction.Contract;
using Context;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositores
{
    public class CatgoryRepositry : Repository<Category, int>, ICategoryRepository
    {
        public CatgoryRepositry(_Context _context) : base(_context)
        {
        }

        public IQueryable<Category> SearchByName(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
