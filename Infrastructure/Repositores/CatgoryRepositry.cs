﻿using Appliaction.Contract;
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
    public class CatgoryRepositry : Repository<Category, int>, ICategoryRepository
    {
        private readonly _Context context;
        public CatgoryRepositry(_Context _context) : base(_context)
        {
            this.context = _context;

           
        }

        public IQueryable<Category> SearchByName(string Name)
        {
            return context.Categories.Where(x => x.Name.Contains(Name));
        }
    }
}
