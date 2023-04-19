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
    public partial class PlaceOrders : Form
    {
        private Cart cart;
        PlaceOrders_Object po1 = new PlaceOrders_Object("");

        private BUS_Products products;
        private BUS_Vendor vendor;
        private BUS_Staff staff;

        public PlaceOrders()
        {
            InitializeComponent();
        }
        private void formload()
        {
            products = new BUS_Products("", "", "", "", "", "", "");
            vendor = new BUS_Vendor("", "", "", "");
            staff = new BUS_Staff("", "", "", "", "", "");

            //Show the list of vendor
            showVendor();

            //Show Products by Vendor
            showProducts();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            cart = new Cart(po1);
            cart.Show();
        }
        private void showVendor()
        {

            DataTable tb = vendor.selectQuery();
            cb_Vendor.DataSource = tb;
            cb_Vendor.DisplayMember = "vendorName";
            cb_Vendor.ValueMember = "vendorID";
        }
       
        private void PlaceOrders_Load(object sender, EventArgs e)
        {
            formload();
        }

        private void showProducts()
        {
            string vendorID = cb_Vendor.SelectedValue.ToString();
            grd_ProductsOfVendor.DataSource = products.selectVendorId(vendorID);
        }
        private void cb_Vendor_TextChanged(object sender, EventArgs e)
        {
            showProducts();
        }
    }
}
