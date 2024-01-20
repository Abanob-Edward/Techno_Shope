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
    public partial class LoginAndRegister : Form
    {
        public LoginAndRegister()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel_register_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_GoToLogin_Click(object sender, EventArgs e)
        {
            // Show the login panel
            panel_login.BringToFront();
        }

        private void button_GoTo_Register_Click(object sender, EventArgs e)
        {
            // Show the register panel
            panel_register.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
