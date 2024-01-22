using Appliaction.Contract;
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
    public partial class Category : Form
    {
        ICategoryService categoryService;

        public Category()
        {
            InitializeComponent();
            categoryService = new CategoryService(new CatgoryRepositry(new _Context()));
        }

        public void loadtabel()
        {
            var categories = categoryService.GetCategory().ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = categories;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string categoryName = textBox1.Text;
            string categoryType = textbox2.Text;
            // int catgoryId = int.Parse(textBox3.Text);
            categoryService.AddCategory(new Model.Models.Category { Name = categoryName, Type = categoryType });
            textBox1.Clear();
            textbox2.Clear();
            textBox3.Clear();
            loadtabel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int catgoryId = int.Parse(textBox3.Text);
            categoryService.DeleteCategory(catgoryId);
            loadtabel();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string categoryName = textBox1.Text;
            string categoryType = textbox2.Text;
            int catgoryId = int.Parse(textBox3.Text);

            var obj = categoryService.GetCategorybyID(catgoryId);

            obj.Name = categoryName;
            obj.Type = categoryType;

            categoryService.UpdateCategory(obj);
            loadtabel();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var categories = categoryService.GetCategory().ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = categories;
            loadtabel();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(textBox3.Text);
            dataGridView1.DataSource = categoryService.GetCategorybyID(categoryId);
            loadtabel();


        }

        private void Category_Load(object sender, EventArgs e)
        {

            loadtabel();

            this.ControlBox = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
