using Appliaction.Contract;
using Appliaction.Services;
using Autofac;
using Context;
using Infrastructure.Repositores;
using Microsoft.EntityFrameworkCore;
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
    public partial class CategoryPanel : Form
    {
        ICategoryService categoryService;

        public CategoryPanel()
        {

            InitializeComponent();
            var inject = AutoFact.Inject();
            categoryService = inject.Resolve<ICategoryService>();
        }

        public void loadtabel()
        {
            var categories = categoryService.GetCategory().ToList();

            CategoryDGV.DataSource = categories;


        }




        private void button3_Click(object sender, EventArgs e)
        {
            string categoryName = CatNameTxt1.Text;
            string categoryType = CatTybetxt1.Text;
            //  int catgoryId = int.Parse(textBox3.Text);

            var obj = categoryService.GetCategorybyID(1);

            obj.Name = categoryName;
            obj.Type = categoryType;

            categoryService.UpdateCategory(obj);
            loadtabel();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var categories = categoryService.GetCategory().ToList();

            CategoryDGV.DataSource = categories;
            loadtabel();


        }

        private void Category_Load(object sender, EventArgs e)
        {

            loadtabel();

            this.ControlBox = false;
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            var list = categoryService.GetByName(textBox4.Text).ToList();
            CategoryDGV.DataSource = list;

        }


        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if (CatNameTxt2.Text != null && CatNameTxt2.Text != "")
            {
                int Id = int.Parse(CategoryDGV.CurrentRow.Cells[0].Value.ToString());
                var obj = categoryService.GetCategorybyID(Id);

                obj.Name = CatNameTxt2.Text;
                obj.Type = CatTybetxt2.Text;

                categoryService.UpdateCategory(obj);
                loadtabel();

            }
            else
            {
                ErrorMessage.Text = "Please Select Row to Update";
            }


        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            if (CatNameTxt1.Text != null && CatNameTxt2.Text != "")
            {

                var Result = MessageBox.Show("Are you shure  to delete ", "Delete Confirem", MessageBoxButtons.YesNo);

                if (Result == DialogResult.Yes)
                {
                    int Id = int.Parse(CategoryDGV.CurrentRow.Cells[0].Value.ToString());
                    var obj = categoryService.GetCategorybyID(Id);
                    categoryService.DeleteCategory(1);
                    loadtabel();
                }


            }
            else
            {
                ErrorMessage.Text = "Please Select Row to delete";
            }


        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = CatNameTxt1.Text;
            string categoryType = CatTybetxt1.Text;

            categoryService.AddCategory(new Model.Models.Category { Name = categoryName, Type = categoryType });
            CatNameTxt1.Clear();
            CatTybetxt1.Clear();

            loadtabel();
        }

        private void CategoryDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CatNameTxt2.Text = CategoryDGV.CurrentRow.Cells[1].Value.ToString();
            CatTybetxt2.Text = CategoryDGV.CurrentRow.Cells[2].Value.ToString();
            ErrorMessage.Text = "";
        }

       
    }
}
