using Appliaction.Contract;
using Context;
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
    public class ProudectRepository : Repository<Product, int>, IProudectRepository
    {
        private readonly _Context context;

        public ProudectRepository(_Context _context) : base(_context)
        {

            this.context = _context;
        }

        //public Product add(Product entity)
        //{
        //    return context.Products.Add(entity).Entity;
        //}

        //public Product update(Product student)
        //{
        //    return context.Products.Update(student).Entity;
        //}

        //IQueryable<Product> IG_Repo<Product, int>.getAll()
        //{
        //    try
        //    {

        //        return context.Products.AsQueryable();
        //    }
        //    catch (DbUpdateException ex)
        //    {
        //        Console.WriteLine($"Error saving changes: {ex.Message}");
        //        Enumerable.Empty<Product>().AsQueryable();
        //        return Enumerable.Empty<Product>().AsQueryable();
        //    }
        //}


        //Product IG_Repo<Product, int>.getByID(int id)
        //{
        //    return context.Products.Find(id);
        //}

        
        //public int Save()
        //{
        //    try
        //    {
        //        return context.SaveChanges();
        //    }
        //    catch (DbUpdateException ex)
        //    {

        //        Console.WriteLine($"Error saving changes: {ex.Message}");


        //        return -1;
        //    }
        //}

        public IQueryable<Product> SearchByName(string Name)
        {
           
            return context.Products.Where(p => p.Name.Contains(Name)).AsQueryable();
        }
    }
}
