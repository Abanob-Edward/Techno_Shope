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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation
{
    public partial class EditProductPanel : Form
    {
        IProductService ProductService;
        public EditProductPanel()
        {
            InitializeComponent();
            ProductService = new ProductService(new ProudectRepository(new _Context()));
            
        }
        private void Product_load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            loadtabel();
        }
        public void loadtabel()
        {
            
            var products = ProductService.GetAlltech().ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
           
        }

        private void Proudect_delet(object sender, EventArgs e)
        {
           int productyId = int.Parse(textBox1.Text);
            ProductService.Deletetech(productyId);
            loadtabel();
        }

        private void proudect_Edite(object sender, EventArgs e)
        {
            int productyId = int.Parse(textBox1.Text);
            string productName = textBox2.Text;
            Decimal productPrice = Decimal.Parse(textBox5.Text);
            int productcode = int.Parse(textBox3.Text);
            string prouductTitle = textBox4.Text;
            string prouductDescraption = textBox7.Text;
            string prouductImage = textBox6.Text;



            var obj = ProductService.GettechById(productyId);

            obj.Name = productName;
            obj.Code = productcode;
            obj.Title = prouductTitle;
            obj.Description = prouductDescraption;
            obj.Image = prouductImage;
            obj.Price = productPrice;
            

            ProductService.Updatetech(obj);
            loadtabel();

        }

    }
}
