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
    public partial class ProductPanel : Form
    {
        public ProductPanel()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
