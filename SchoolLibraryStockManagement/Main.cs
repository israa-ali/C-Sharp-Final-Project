﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLibraryStockManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            new Login().ShowDialog();
        }

        private void lbl_products_Click(object sender, EventArgs e)
        {
            new Product().ShowDialog();
        }

        private void lbl_categories_Click(object sender, EventArgs e)
        {
            new Category().ShowDialog();
        }

        private void lbl_users_Click(object sender, EventArgs e)
        {
            new User().ShowDialog();
        }

        private void lbl_orders_Click(object sender, EventArgs e)
        {
            new Order().ShowDialog();
        }

        private void lbl_reports_Click(object sender, EventArgs e)
        {
            new Report().ShowDialog();
        }

        private void lbl_settings_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }
    }
}