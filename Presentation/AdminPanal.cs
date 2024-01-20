using Model.Models;

namespace Presentation
{
    public partial class AdminPanal : Form
    {
        Category Category;
        Product product;
        public AdminPanal()
        {
            InitializeComponent();
        }

        bool CatMenuExpand = false;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanal_Load(object sender, EventArgs e)
        {

        }

        private void CategoryTransition_Tick(object sender, EventArgs e)
        {
            if (CatMenuExpand == false)
            {
                CategoryMenu.Height += 10;
                if (CategoryMenu.Height >= 195)
                {
                    CategoryTransition.Stop();
                    CatMenuExpand = true;
                }
            }
            else
            {
                CategoryMenu.Height -= 10;
                if (CategoryMenu.Height <= 80)
                {
                    CategoryTransition.Stop();
                    CatMenuExpand = false;
                }
            }

        }

        private void CatMenuBtn_Click(object sender, EventArgs e)
        {
            CategoryTransition.Start();
        }
        bool SideBarExpand = true;
        private void SideBarTransition_Tick(object sender, EventArgs e)
        {
            if (SideBarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width <= 66)
                {
                    SideBarExpand = false;
                    SideBarTransition.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width >= 280)
                {
                    SideBarExpand = true;
                    SideBarTransition.Stop();

                }
            }

        }

        private void BtnSideBar_Click(object sender, EventArgs e)
        {
            SideBarTransition.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Category == null)
            {
                Category = new Category();
                Category.FormClosed += Category_FormClosed;
                Category.MdiParent = this;
                Category.Dock = DockStyle.Fill;
                Category.Show();
            }
            else
            {
                Category.Activate();
            }
        }

        private void Category_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Category = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (product == null)
            {
                product = new Product();
                product.FormClosed += product_FormClosed;
                product.MdiParent = this;
                product.Dock = DockStyle.Fill;
                product.Show();
            }
            else
            {
                product.Activate();
            }
        }

        private void product_FormClosed(object? sender, FormClosedEventArgs e)
        {
            product = null;
        }
    }
}

