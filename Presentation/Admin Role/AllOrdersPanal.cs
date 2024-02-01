﻿using Appliaction.Services;
using Autofac;
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
    public partial class AllOrdersPanal : Form
    {
        private readonly IOrderService orderService;

        public AllOrdersPanal()
        {
            InitializeComponent();
            var inject = AutoFact.Inject();
            orderService = inject.Resolve<IOrderService>();

            try
            {
                AllOrdersDGV.DataSource= orderService.GetAllOrders().ToList();
            }
            catch (Exception)
            {

                
            }
        }
    }
}
