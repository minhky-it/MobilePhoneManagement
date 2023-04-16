using System;
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
    public partial class PlaceOrders : Form
    {
        private Cart cart;
        PlaceOrders_Object po1 = new PlaceOrders_Object("");
        public PlaceOrders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cart = new Cart(po1);
            cart.Show();
        }

        private void PlaceOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
