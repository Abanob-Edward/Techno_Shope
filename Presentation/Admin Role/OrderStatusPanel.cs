using Appliaction.Services;
using Context;
using Infrastructure.Repositores;
using Model.Models;
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
    public partial class OrderStatusPanel : Form
    {
        private readonly OrderService orderService;
        OrderStatus OrderStatus = new OrderStatus();

        int ID = 0;
        public OrderStatusPanel()
        {
            orderService = new OrderService(new OrderRepository(new _Context()));
            InitializeComponent();
            loadData();

        }

        public void loadData()
        {
            try
            {
                AllOrdersDGV.DataSource = orderService.GetAllOrders().ToList();
            }
            catch (Exception)
            {


            }
        }
        private void AllOrdersDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IDMessage.Text = AllOrdersDGV.CurrentRow.Cells[0].Value.ToString();
            ID = int.Parse( AllOrdersDGV.CurrentRow.Cells[0].Value.ToString());
            IDMessage.ForeColor = Color.Green;
        }

        private void processingradio_CheckedChanged(object sender, EventArgs e)
        {

            if (ID != 0)
                {
                    orderService.UpdateOrderStatus(ID, OrderStatus.processing);
                    loadData();

            }else
                IDMessage.Size = new System.Drawing.Size(800, 40);
                IDMessage.Width = 600;

        }

        private void shippedradio_CheckedChanged(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                orderService.UpdateOrderStatus(ID, OrderStatus.shipped);
                 loadData();

            }
            IDMessage.Focus();

        }

        private void deliveredradio_CheckedChanged(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                orderService.UpdateOrderStatus(ID, OrderStatus.delivered);
                  loadData();
            }
            IDMessage.Focus();
        }
    }
}
