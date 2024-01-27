using Appliaction.Services;
using Autofac;
using Context;
using Infrastructure.Repositores;
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
        IProductService ProductService;
        ICartService cartService;
        CartproudectRepository cartproudectRepository;

        public CartItemPanel(int? userid = 0)
        {
            UserCurrenID = userid;
            InitializeComponent();
            var inject = AutoFact.Inject();
            ProductService = inject.Resolve<IProductService>();
            cartService = inject.Resolve<ICartService>();
            cartproudectRepository = new CartproudectRepository(new _Context());
          

        }

        private void CartItemPanel_Load(object sender, EventArgs e)
        {
            // get product list fot spcific User id 
            CartItemDGV.DataSource = cartproudectRepository.getAll().ToList();
        }
    }
}
