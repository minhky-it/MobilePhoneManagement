﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class Cart : Form
    {
        PlaceOrders_Object po1;
        public Cart(PlaceOrders_Object po)
        {
            InitializeComponent();
            po1 = po;
        }

        private void Cart_Load(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
