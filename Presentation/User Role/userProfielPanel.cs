using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.User_Role
{
    public partial class userProfielPanel : Form
    {
        public int? UserCurrenID;
        public userProfielPanel(int? userCurrenID)
        {
            InitializeComponent();
            UserCurrenID = userCurrenID;

        }

        private void userProfielPanel_Load(object sender, EventArgs e)
        {
            label1.Text = "test";
        }
    }
}
