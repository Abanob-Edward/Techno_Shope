using Appliaction.Services;
using Autofac;
using Context;
using Infrastructure.Contract;
using Infrastructure.Repositores;
using System;
using System.Collections;
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
    public partial class uHomePanel : Form
    {
        int CurrentUserID;
        IProductService ProductService;
        ICartService cartService;
        CartproudectRepository cartproudectRepository;

        public uHomePanel(int currentUserID=0)
        {

            InitializeComponent();
            var inject = AutoFact.Inject();
            ProductService = inject.Resolve<IProductService>();
            cartService = inject.Resolve<ICartService>();
            cartproudectRepository= new CartproudectRepository(new _Context());
            CurrentUserID= currentUserID;
        }
        DataGridViewButtonColumn addToCart = new DataGridViewButtonColumn();
        
        private void uHomePanel_Load(object sender, EventArgs e)
        {
            /*.Select(p => new
            {
                ID = p.Id,
                Name = p.Name,
                Price = p.Price,
                Image = p.Image
            })*/
            // ID  -  Name   - price    - image --   add to cart 
        
            ProductsDGV.ColumnCount = 4;
            ProductsDGV.Columns[0].Name = "ID";
            ProductsDGV.Columns[1].Name = "Name ";
            ProductsDGV.Columns[2].Name = "Price";
            ProductsDGV.Columns[3].Name = "Image";
            //  ProductsDGV.Columns[4].Name = "ID";

            ArrayList list;
            var listOfproduct = ProductService.GetAlltech();

            foreach (var item in listOfproduct)
            {
                list = new ArrayList();
                list.Add(item.Id);
                list.Add(item.Name);
                list.Add(item.Price);
                list.Add(item.Image);
                ProductsDGV.Rows.Add(list.ToArray());
            }
            addToCart.Text = "Add to Cart";
            addToCart.Name = "addToCartBtn";
            addToCart.HeaderText = "Cart Item";
            addToCart.UseColumnTextForButtonValue = true;
            ProductsDGV.Columns.Add(addToCart);
        }
    /*    private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here

                ProductsDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }*/
        private void ProductsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex== 4)
            {
                var ProductID = int.Parse(ProductsDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                // ProductsDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
                int cartID = cartService.GetCartByUserID(CurrentUserID).Id;
                cartService.addproductToCart(ProductID, cartID);
                ProductsDGV.CurrentCell.Style.BackColor = Color.Green;
                Success.Text = "Success ADD to cart item " + ProductID.ToString();
                //MessageBox.Show(yarab);
            }
        }



    }
}
