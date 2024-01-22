using Appliaction.Services;
using Context;
using Infrastructure.Repositores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class ProductPanel : Form
    {
        IProductService ProductService;
        public ProductPanel()
        {
            InitializeComponent();
            ProductService = new ProductService(new ProudectRepository(new _Context()));
        }

        public void loadtabel()
        {
            //IQueryable<Model.Models.Product> products = ProductService.GetAlltech().ToList();

            var products = ProductService.GetAlltech().ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
        }


        private void Product_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            loadtabel();
        }


        private void Add_Product(object sender, EventArgs e)
        {
            string productName = textBox1.Text;
            int productcode = int.Parse(textBox2.Text);
            string prouductTitle = textBox3.Text;
            Decimal productPrice = Decimal.Parse(textBox4.Text);
            string prouductDescraption = textBox5.Text;
            string prouductImage = textBox6.Text;

            ProductService.Addtech(new Model.Models.Product
            {
                Name = productName
                ,
                Price = productPrice,
                Code = productcode,
                Title = prouductTitle,
                Description = prouductDescraption,
                Image = prouductImage

            });


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            loadtabel();
        }

       
    }
}

