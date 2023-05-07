using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using BUS;

namespace SE_Project
{
    public partial class Export : Form
    {
        private BUS_Products products = new BUS_Products();
        private BUS_OrderForm orderForm = new BUS_OrderForm();

        public Export()
        {
            InitializeComponent();
        }

        private void showOrder()
        {
            DataTable tb = orderForm.selectQuery();
            cbOrderID.DataSource = tb;
            cbOrderID.ValueMember = "orderID";
        }

        private void showOrderProducts()
        {
            string orderID = cbOrderID.SelectedValue.ToString();
            dataGridView.DataSource = products.selectOrderId(orderID);
        }

        private void Export_Load(object sender, EventArgs e)
        {
            showOrder();
            formload();
        }

        public void formload()
        {
            showOrderProducts();
        }

        private void cbOrderID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            formload();
        }

        private void btn_Complete_Click_1(object sender, EventArgs e)
        {
            Delivery_Data();
        }

        public void Delivery_Data()
        {
            DeliveryBill deliveryBill = new DeliveryBill(txtReceiverName.Text, txtPhone.Text, txtDate.Text, cbOrderID.Text);
            deliveryBill.Show();
        }
    }
}
