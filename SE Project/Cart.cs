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
    public partial class Cart : Form
    {
        private BUS_OrderForm orderform;
        PlaceOrders_Object po;
        public Cart(PlaceOrders_Object po1)
        {
            InitializeComponent();
            po = po1;
        }
        void formload()
        {
            txtQuantity.ReadOnly = true;
            txtQuantity.Text = "";

            btnDel.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
        }
        private void Cart_Load(object sender, EventArgs e)
        {
            formload();
            grd_Cart.DataSource = po._data;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int selectedRow;
        private void grd_Cart_Click(object sender, EventArgs e)
        {
            btnDel.Enabled = true;
            btnEdit.Enabled = true;
            selectedRow = grd_Cart.CurrentRow.Index;
            txtQuantity.Text = grd_Cart.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(btnEdit.Text != "Save")
            {
                txtQuantity.ReadOnly = false;
                txtQuantity.Focus();
                btnEdit.Text = "Save";
            }else
            {
                grd_Cart.Rows[selectedRow].Cells[2].Value = txtQuantity.Text;
                btnEdit.Text = "Edit Quantity";
                txtQuantity.Text = "";
                txtQuantity.ReadOnly = true;
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grd_Cart.Rows)
            {
                po._vendorId = row.Cells[1].Value.ToString();
                po._productId = row.Cells[0].Value.ToString();
                orderform = new BUS_OrderForm(po._id, po._vendorId, po._staffId, po._productId, po._address, po._deliverytime);
                orderform.addQuery();
            }
        }
    }
}
