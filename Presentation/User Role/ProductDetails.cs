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
    public partial class ProductDetails : Form
    {
        public ProductDetails(int? proID)
        {
            InitializeComponent();
            Idlabel.Text = proID.ToString();
        }
       
    }
}
