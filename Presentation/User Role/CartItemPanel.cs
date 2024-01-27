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
    public partial class CartItemPanel : Form
    {
        public int? UserCurrenID;
        public CartItemPanel(int ? userid=0)
        {
            UserCurrenID = userid;
            InitializeComponent();
            
        }
    }
}
