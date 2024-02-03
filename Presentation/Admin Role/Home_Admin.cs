using System;
using System.Windows.Forms;

namespace Presentation.Admin_Role
{
    public partial class Home_Admin : Form
    {
        private CategoryPanel categoryPanel;
        private ProductPanel productPanel;
        private EditProductPanel editProductPanel;
        private BestSellerPanel bestSellerPanel;
        private OrderStatusPanel orderStatusPanel;
        private AllOrdersPanal allOrdersPanal;
        private LoginAndRegister loginAndRegister;

        public Home_Admin()
        {
            InitializeComponent();
        }

        private void OpenOrActivateForm<T>(ref T form) where T : Form, new()
        {
            form = FindOpenForm<T>();

            if (form == null)
            {
                form = new T();
                form.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private T FindOpenForm<T>() where T : Form
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is T)
                {
                    return (T)form;
                }
            }
            return null;
        }

        private void Home_Admin_Load(object sender, EventArgs e)
        {
           
        }

        private void but_Category_Ad_Click(object sender, EventArgs e)
        {
            OpenOrActivateForm(ref categoryPanel);
        }

        private void LogoutBTN_Ad_Click(object sender, EventArgs e)
        {
            loginAndRegister = new LoginAndRegister();
            this.Hide();
            loginAndRegister.Show();
        }

        private void but_Best_Seller_Ad_Click(object sender, EventArgs e)
        {
            OpenOrActivateForm(ref bestSellerPanel);
        }

        private void but_edit_or_delete_Prod_Ad_Click(object sender, EventArgs e)
        {
            OpenOrActivateForm(ref editProductPanel);
        }

        private void but_Show_all_products_Click(object sender, EventArgs e)
        {
            OpenOrActivateForm(ref productPanel);
        }

        private void but_All_orders_Click(object sender, EventArgs e)
        {
            OpenOrActivateForm(ref allOrdersPanal);
        }

        private void Butt_Order_Status_Ad_Click(object sender, EventArgs e)
        {
            OpenOrActivateForm(ref orderStatusPanel);
        }
    }
}
