using Model.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presentation
{
    public partial class AdminPanal : Form
    {
        CategoryPanel categoryPanel;
        ProductPanel productPanel;
        EditProductPanel editProductPanel;
        BestSellerPanel BestSellerPanel;
        OrderStatusPanel OrderStatusPanel;
        AllOrdersPanal allOrdersPanal;
        LoginAndRegister loginAndRegister;
        // LoginAndRegister loginAndRegister = 
        public AdminPanal(string? name = "Admin Name")
        {
            InitializeComponent();
            AdminName.Text = "Welcome  " + name;
        }

        bool CatMenuExpand = false;
        bool OrderMenuExpand = false;



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
                if (CategoryMenu.Height <= 75)
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



        private void Category_FormClosed(object? sender, FormClosedEventArgs e)
        {
            categoryPanel = null;
        }

        private void BestSellerClosed(object? sender, FormClosedEventArgs e)
        {
            BestSellerPanel = null;
        }
        private void OrderStatusClosed(object? sender, FormClosedEventArgs e)
        {
            OrderStatusPanel = null;
        }
        private void AllOrdersPanalClosed(object? sender, FormClosedEventArgs e)
        {
            allOrdersPanal = null;
        }
        private void editProductPanelClosed(object? sender, FormClosedEventArgs e)
        {
            editProductPanel = null;
        }







        private void product_FormClosed(object? sender, FormClosedEventArgs e)
        {
            productPanel = null;
        }

        private void CategoryBTN1_Click(object sender, EventArgs e)
        {
            if (categoryPanel == null)
            {
                categoryPanel = new CategoryPanel();
                categoryPanel.FormClosed += Category_FormClosed;
                categoryPanel.MdiParent = this;
                categoryPanel.Dock = DockStyle.Fill;
                categoryPanel.Show();
            }
            else
            {
                categoryPanel.Activate();
            }
        }

        private void ShowALLProduct_Click(object sender, EventArgs e)
        {
            if (productPanel == null)
            {
                productPanel = new ProductPanel();
                productPanel.FormClosed += Category_FormClosed;
                productPanel.MdiParent = this;
                productPanel.Dock = DockStyle.Fill;
                productPanel.Show();
            }
            else
            {
                productPanel.Activate();
            }
        }



        private void OrderTransition_Tick(object sender, EventArgs e)
        {


            if (OrderMenuExpand == false)
            {
                OrderMenu.Height += 10;
                if (OrderMenu.Height >= 195)
                {
                    OrderTransition.Stop();
                    OrderMenuExpand = true;
                }
            }
            else
            {
                OrderMenu.Height -= 10;
                if (OrderMenu.Height <= 75)
                {
                    OrderTransition.Stop();
                    OrderMenuExpand = false;
                }
            }

        }

        private void OrderBTN_Click(object sender, EventArgs e)
        {
            OrderTransition.Start();
        }

        private void BestSeller_Click(object sender, EventArgs e)
        {
            if (BestSellerPanel == null)
            {
                BestSellerPanel = new BestSellerPanel();
                BestSellerPanel.FormClosed += BestSellerClosed;
                BestSellerPanel.MdiParent = this;
                BestSellerPanel.Dock = DockStyle.Fill;
                BestSellerPanel.Show();
            }
            else
            {
                BestSellerPanel.Activate();
            }
        }

        private void OrderStatusBTN_Click(object sender, EventArgs e)
        {
            if (OrderStatusPanel == null)
            {
                OrderStatusPanel = new OrderStatusPanel();
                OrderStatusPanel.FormClosed += OrderStatusClosed;
                OrderStatusPanel.MdiParent = this;
                OrderStatusPanel.Dock = DockStyle.Fill;
                OrderStatusPanel.Show();
            }
            else
            {
                OrderStatusPanel.Activate();
            }
        }


        private void ProOutOfStock_Click(object sender, EventArgs e)
        {
            if (editProductPanel == null)
            {
                editProductPanel = new EditProductPanel();
                editProductPanel.FormClosed += editProductPanelClosed;
                editProductPanel.MdiParent = this;
                editProductPanel.Dock = DockStyle.Fill;
                editProductPanel.Show();
            }
            else
            {
                editProductPanel.Activate();
            }
        }

        private void AllOrders_Click(object sender, EventArgs e)
        {

            if (allOrdersPanal == null)
            {
                allOrdersPanal = new AllOrdersPanal();
                allOrdersPanal.FormClosed += AllOrdersPanalClosed;
                allOrdersPanal.MdiParent = this;
                allOrdersPanal.Dock = DockStyle.Fill;
                allOrdersPanal.Show();
            }
            else
            {
                allOrdersPanal.Activate();
            }
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {

        }

        private void LogoutBTN_Click(object sender, EventArgs e)
        {
            loginAndRegister = new LoginAndRegister();
            this.Hide();
            loginAndRegister.Show();
        }
    }
}

