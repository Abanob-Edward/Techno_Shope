using Appliaction.Services;
using Autofac;
using Context;
using Infrastructure.Repositores;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections;
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



    public partial class CartItemPanel : Form
    {
        public int? UserCurrenID;
        IProductService ProductService;
        ICartService cartService;
        CartproudectRepository cartproudectRepository;
        private int currentPage = 1;
        private const int PageSize = 10;
        public CartItemPanel(int? userid = 0)
        {
            UserCurrenID = userid;
            InitializeComponent();
            var inject = AutoFact.Inject();
            ProductService = inject.Resolve<IProductService>();
            cartService = inject.Resolve<ICartService>();
            cartproudectRepository = new CartproudectRepository(new _Context());


        }
        // get product list fot spcific User id 

        // CartItemDGV.DataSource = cartproudectRepository.getAll().ToList();
        // get product list fot spcific User id 
        // get product list fot spcific User id 
        //Get product list for a specific User ID 
        //var cartiteampro = cartproudectRepository.getAll()

        private void LoadTable()
        {

            ArrayList list;
            int skipCount = (currentPage - 1) * PageSize;
            int takeCount = PageSize;

            List<Product> listOfproduct = ProductService.GetAllPagination(skipCount, takeCount);

 

        }

        private void CartItemPanel_Load(object sender, EventArgs e)
        {
            ArrayList list;
            int skipCount = (currentPage - 1) * PageSize;
            int takeCount = PageSize;

            List<Product> listOfproduct = ProductService.GetAllPagination(skipCount, takeCount);

            // Get product list for a specific User ID 
            var cartiteampro = cartproudectRepository.getAll().Include(p => p.Product).ToList();

            CartItemDGV.DataSource = null;
            CartItemDGV.DataSource = cartiteampro.Select(p => new
            {
                p.Product.Image,
                p.Product.Price,
                p.Product.Title,
                p.Product.Code,
                Quantity = p.Quantity + 1,  // Increment quantity by 1
                TotalPrice = p.Product.Price * (p.Quantity + 1)  // Adjust total price calculation accordingly
            }).ToList();

            LoadTable();
        }


        private bool HasDataOnPage(int page)
        {
            int skipCount = (page - 1) * PageSize;
            int takeCount = PageSize;

            List<Product> products = ProductService.GetAllPagination(skipCount, takeCount);

            return products.Any(); // Check if there is any data on the specified page
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int nextPage = currentPage + 1;

                if (HasDataOnPage(nextPage))
                {
                    currentPage = nextPage;
                    LoadTable(); // Reload the table for the next page
                }
                else
                {
                    MessageBox.Show("No more data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int previousPage = currentPage - 1;

                if (previousPage >= 1)
                {
                    if (HasDataOnPage(previousPage))
                    {
                        currentPage = previousPage;
                        LoadTable(); // Reload the table for the previous page
                    }
                    else
                    {
                        MessageBox.Show("No more data available on the previous page.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You are already on the first page.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
