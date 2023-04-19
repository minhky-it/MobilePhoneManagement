using System;
using System.Windows.Forms;
using BUS;

namespace SE_Project
{
    public partial class WareHouse : Form
    {
        BUS_Products products;
        public WareHouse()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            txtID.Focus();
            products = new BUS_Products("","","","","","","");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Add data from DataGridView to MSSQL
            string iD, vendorID, name, quantity, type, price, color;
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                iD = dataGridView.Rows[i].Cells[0].Value.ToString();
                vendorID = dataGridView.Rows[i].Cells[1].Value.ToString();
                name = dataGridView.Rows[i].Cells[2].Value.ToString();
                quantity = dataGridView.Rows[i].Cells[3].Value.ToString();
                type = dataGridView.Rows[i].Cells[4].Value.ToString();
                price = dataGridView.Rows[i].Cells[5].Value.ToString();
                color = dataGridView.Rows[i].Cells[6].Value.ToString();

                products = new BUS_Products(iD, vendorID, name, quantity, type, price, color);
                products.addQuery();
            }
        }
    }
}
