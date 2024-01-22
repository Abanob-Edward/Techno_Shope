using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Appliaction.Contract;
using System.Xml.Linq;
namespace Appliaction.Services
{
    ///IG_Services to 
    //public class ProductService : IG_Services<Product, int>
    //{
    //    private readonly IG_Repo2<Product, int> _productRepository;

    //    public ProductService(IG_Repo2<Product, int> productRepository)
    //    {
    //        _productRepository = productRepository;
    //    }

    //    public IQueryable<Product> GetAlltech()
    //    {
    //        return _productRepository.getAll();
    //    }

    //    public Product GettechById(int id)
    //    {
    //        return _productRepository.getByID(id);
    //    }

    //    public void Deletetech(int id)
    //    {
    //        _productRepository.delete(id);
    //        _productRepository.Save();
    //    }



    //    public Product Addtech(int entityId)
    //    {
    //        var newProduct = new Product { Id = entityId };
    //        var addedProduct = _productRepository.add(newProduct);
    //        _productRepository.Save();
    //        return addedProduct;
    //    }

    //    public Product Updatetech(int entityId)
    //    {
    //        var existingProduct = _productRepository.getByID(entityId);
    //        if (existingProduct != null)
    //        {

    //            _productRepository.update(existingProduct);
    //            _productRepository.Save();
    //        }
    //        return existingProduct;
    //    }



    //    public IQueryable<Product> SearchtechByName(string Name)
    //    {

    //        return _productRepository.getAll().Where(p => p.Name.Contains(Name)).AsQueryable();
    //    }


    //}

    public class ProductService : IProductService
    {
        private readonly IG_Repo<Product, int> _productRepository;

        public ProductService(IG_Repo<Product, int> productRepository)
        {
            _productRepository = productRepository;
        }

        public void Addtech(Product entity)
        {
            _productRepository.add(entity);

          
        }

        public void Deletetech(int id)
        {
            _productRepository.delete(id);
        }

        public IQueryable<Product> GetAlltech()
        {
            return _productRepository.getAll();
        }

        public Product? GettechById(int id)
        {
            return _productRepository.getByID(id);
        }

        public Product Updatetech(Product entity)
        {
            return _productRepository.update(entity);
        }
    }
}


