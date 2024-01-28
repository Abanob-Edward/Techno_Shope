using Appliaction.Services;
using Context;
using Infrastructure.Repositores;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.User_Role
{
    public partial class tsetpigin : Form
    {
        IProductService ProductService;
        private int currentPage = 1;
        private const int PageSize = 10;
        public tsetpigin()
        {
            InitializeComponent();
            ProductService = new ProductService(new ProudectRepository(new _Context()));
            LoadData();
        }
        private void LoadData()
        {

            int skipCount = (currentPage - 1) * PageSize;
            int takeCount = PageSize;

            List<Product> products = ProductService.GetAllPagination(skipCount, takeCount);
            var product= ProductService.GetAlltech()
               .Include(p => p.User)       // Eager load the User navigation property
               .Include(p => p.category)   // Eager load the category navigation property
               .ToList();

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = products.Select(p => new
            {
                p.Id,
                p.Name,
                p.Description,
                p.Price,
                p.Title,
                p.Code,
                p.Image,
                // AdmineName = p.User != null ? p.User.FirstName : "No Admin",
                CategoryName = p.category != null ? p.category.Name : "No Category"
            }).ToList();

          
           
            }

        private void button1_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentPage--;
            LoadData();

        }
    }
}
