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
            string ID = txtNo.Text;
            string dateInput = txtDate.Text;

            string receiverName = txtReceiverName.Text;
            string phone = txtPhone.Text;
            string reason = txtReason.Text;
            string exportAt = txtExported.Text;
            string location = txtLocation.Text;

            string total = txtTotal.Text;
            string statusPayment = txtPaymentStatus.Text;

            if (ID == "")
            {
                MessageBox.Show("Please, Enter the No.");
                txtNo.Focus();
            }
            else if (dateInput == "")
            {
                MessageBox.Show("Please, Enter the export date");
                txtDate.Focus();
            }
            else if (receiverName == "")
            {
                MessageBox.Show("Please, Enter the receiver name");
                txtReceiverName.Focus();
            }
            else if (phone == "")
            {
                MessageBox.Show("Please, Enter the phone number");
                txtPhone.Focus();
            }
            else if (reason == "")
            {
                MessageBox.Show("Please, Enter the export reason");
                txtReason.Focus();
            }
            else if (exportAt == "")
            {
                MessageBox.Show("Please, Enter the export at");
                txtExported.Focus();
            }
            else if (location == "")
            {
                MessageBox.Show("Please, Enter the location");
                txtLocation.Focus();
            }
            else if (total == "")
            {
                MessageBox.Show("Please, Enter the total amount");
                txtTotal.Focus();
            }
            else if (statusPayment == "")
            {
                MessageBox.Show("Please, Enter the payment status");
                txtPaymentStatus.Focus();
            }
            else
            {
                MessageBox.Show("Export Successfully");
                Delivery_Data();
            }
        }

        public void Delivery_Data()
        {
            DeliveryBill deliveryBill = new DeliveryBill(txtReceiverName.Text, txtPhone.Text, txtDate.Text, cbOrderID.Text);
            deliveryBill.Show();
        }
    }
}
