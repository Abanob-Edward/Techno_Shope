using Appliaction.Services;
using Context;
using Infrastructure.Repositores;
using Model.Models;  // Make sure to include the namespace for your models
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private bool isRowSelected = false;

        private void ProdactDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            isRowSelected = true;
        }




        private void Proudect_delet(object sender, EventArgs e)
        { 
            if (isRowSelected)
            {
                Error.Text = " ";
                int Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var obj = ProductService.GettechById(Id);

                var result = MessageBox.Show("Are you sure to delete?", "Delete Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                   
                    ProductService.Deletetech(Id);
                    loadtabel();
                }
            }
            else
            {
                Error.Text="Please Select a Row to delete";


            }
        }

        private void proudect_Edite(object sender, EventArgs e)
        {
            if (isRowSelected)
            {
                Error.Text = " ";
                int Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var obj = ProductService.GettechById(Id);

                string productName = textBox2.Text;
                Decimal productPrice = Decimal.Parse(textBox5.Text);
                int productcode = int.Parse(textBox3.Text);
                string prouductTitle = textBox4.Text;
                string prouductDescraption = textBox7.Text;
                string prouductImage = textBox6.Text;

                var result = MessageBox.Show("Are you sure to update?", "update Confirm", MessageBoxButtons.YesNo);

              
                    obj.Name = productName;
                    obj.Code = productcode;
                    obj.Title = prouductTitle;
                    obj.Description = prouductDescraption;
                    obj.Image = prouductImage;
                    obj.Price = productPrice;

                    ProductService.Updatetech(obj);
                    loadtabel();
                

                    
            }
            else
            {
                Error.Text = "Please Select a Row to delete";
            }
        }
    }
}
