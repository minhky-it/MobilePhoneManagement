﻿using System;
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
        PlaceOrders_Object po = new PlaceOrders_Object("", "","", "", "", "", "");

        private BUS_Products products;
        private BUS_Vendor vendor;
        private BUS_Staff staff;
        private DataTable cartTable = new DataTable("Cart");

        public PlaceOrders()
        {
            InitializeComponent();
        }
        //Config for first loading
        private void formload()
        {
            products = new BUS_Products("", "", "", "", "", "", "");
            vendor = new BUS_Vendor("", "", "", "");
            staff = new BUS_Staff("", "", "", "", "", "");

            txtEmailStaff.ReadOnly = true;
            txtPhoneStaff.ReadOnly = true;
            txtNameStaff.ReadOnly = true;
            txtNameStaff.Text = "Nguyen Minh Ky";
            txtPhoneStaff.Text = "01234567";
            txtEmailStaff.Text = "minhky.book@gmail.com";


            //Show the list of vendor
            showVendor();

            //Show Products by Vendor
            showProducts();

            //Initial a new cart
            // Create a new DataTable.

            cartTable.Columns.Add("Product ID", typeof(String));
            cartTable.Columns.Add("Vendor ID", typeof(String));
            cartTable.Columns.Add("Name", typeof(String));
            cartTable.Columns.Add("Quantity", typeof(String));
            cartTable.Columns.Add("Type", typeof(String));
            cartTable.Columns.Add("Price", typeof(String));
            cartTable.Columns.Add("Color", typeof(String));
        }
        //Open Cart
        private void button1_Click(object sender, EventArgs e)
        {
            po._id = "34e2asda";
            po._staffId = "xacasd2";
            po._vendorId = cb_Vendor.SelectedValue.ToString();
            po._address = txtBillAdrr.Text;
            po._deliverytime = deliveryDate.Value.ToString("MM/dd/yyyy");

            cart = new Cart(po);
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

        //Show product
        private void showProducts()
        {
            string vendorID = cb_Vendor.SelectedValue.ToString();
            grd_ProductsOfVendor.DataSource = products.selectVendorId(vendorID);
        }

        //Select vendor
        private void cb_Vendor_TextChanged(object sender, EventArgs e)
        {
            showProducts();
        }

        //Add product to cart
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //grd_ProductsOfVendor.CurrentRow.Cells[0].Value.ToString();

            

            DataRow dr = cartTable.NewRow();

            dr[0] = grd_ProductsOfVendor.CurrentRow.Cells[0].Value.ToString();
            dr[1] = grd_ProductsOfVendor.CurrentRow.Cells[1].Value.ToString();
            dr[2] = grd_ProductsOfVendor.CurrentRow.Cells[2].Value.ToString();
            dr[3] = txtQuantityItem.Text;
            dr[4] = grd_ProductsOfVendor.CurrentRow.Cells[4].Value.ToString();
            dr[5] = grd_ProductsOfVendor.CurrentRow.Cells[5].Value.ToString();
            dr[6] = grd_ProductsOfVendor.CurrentRow.Cells[6].Value.ToString();

            cartTable.Rows.Add(dr);//this will add the row at the end of the datatable
            po._data = cartTable;
            MessageBox.Show("Adding success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Edit the quantity
        private void grd_ProductsOfVendor_Click(object sender, EventArgs e)
        {
            txtNameItem.Text = grd_ProductsOfVendor.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
