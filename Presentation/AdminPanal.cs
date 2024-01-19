namespace Presentation
{
    public partial class AdminPanal : Form
    {
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
    }
}
