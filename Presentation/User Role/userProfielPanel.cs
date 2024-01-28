using System;
using System.Windows.Forms;
using Appliaction.Services;
using Context;
using Infrastructure.Repositores;
using Model.Models;

namespace Presentation.User_Role
{
    public partial class userProfielPanel : Form
    {
        private readonly IUserService userService;
        public int? UserCurrentID;

        public userProfielPanel(int userCurrentID)
        public int? UserCurrenID;
        public userProfielPanel(int? userCurrenID)
        {
            UserCurrentID = userCurrentID;
            InitializeComponent();
            userService = new UserService(new UserRepository(new _Context()));
        }

        private void userProfielPanel_Load(object sender, EventArgs e)
        {
            try
            {
                if (text_prof_name != null && text_email_prof != null && text_Number != null && Text_UserName != null)
                {
                    User user = userService.GetUserbyID(UserCurrentID.Value);

                    text_prof_name.Text = user?.FirstName + " " + user?.LastName;
                    text_email_prof.Text = user?.Email;
                    text_Number.Text = user?.PhoneNumber != null ? user.PhoneNumber.ToString() : string.Empty;
                    Text_UserName.Text = user?.UserName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void text_prof_name_TextChanged(object sender, EventArgs e)
        {
        }

        private void Prof_Name_Click(object sender, EventArgs e)
        {
        }

        private void text_email_prof_TextChanged(object sender, EventArgs e)
        {
        }

        private void text_Number_TextChanged(object sender, EventArgs e)
        {
        }

        private void email_prof_Click(object sender, EventArgs e)
        {
        }

        private void Phone_num_prof_Click(object sender, EventArgs e)
        {
        }

        

        private void label_UserName_Click(object sender, EventArgs e)
        {
        }

        private void Text_UserName_TextChanged(object sender, EventArgs e)
        {
            UserCurrenID = userCurrenID;

        }

        private void userProfielPanel_Load(object sender, EventArgs e)
        {
            label1.Text = "test";
        }
    }
}