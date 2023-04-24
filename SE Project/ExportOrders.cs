using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace SE_Project
{
    public partial class ExportOrders : Form
    {
        private BUS_Products products = new BUS_Products();
        private BUS_OrderForm orderForm = new BUS_OrderForm();
        public ExportOrders()
        {
            InitializeComponent();
        }
        
        private void ExportOrders_Load(object sender, EventArgs e)
        {
            showOrder();
            showOrderProducts();
        }

        private void showOrder()
        {
            DataTable tb = orderForm.selectQuery();
            OrderID.DataSource = tb;
            OrderID.DisplayMember = "vendorName";
            OrderID.ValueMember = "orderID";
        }

        private void showOrderProducts()
        {
            string orderID = OrderID.SelectedValue.ToString();
            dataGridView.DataSource = products.selectOrderId(orderID);
        }

        private void OrderID_TextChanged(object sender, EventArgs e)
        {
            showOrderProducts();
        }
    }
}
