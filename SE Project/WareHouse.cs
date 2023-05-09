using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using BUS;

namespace SE_Project
{
    public partial class WareHouse : Form
    {
        BUS_Products products;
        BUS_DetailWareHouse detailWareHouse;
        BUS_Vendor BUS_Vendor = new BUS_Vendor();
        BUS_WareHouse wareHouse = new BUS_WareHouse();

        PrintDocument printDocument = new PrintDocument();
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

        public WareHouse()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            txtDate.Focus();
            txtID.Enabled = false;
            showID();
            showVendorID();
            products = new BUS_Products("","","","","","","");
        }

        // Show vendorID current exist
        private void showVendorID()
        {
            DataTable tb = BUS_Vendor.selectQuery();
            cbVendorID.DataSource = tb;
            cbVendorID.ValueMember = "vendorID";
        }

        // Show top 1 of warehouseID
        public void showID()
        {
            DataTable tb = wareHouse.getWarehouseID();
            if (tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();
                int stt = int.Parse(res.Substring(2, 2)) + 1;
                if (stt < 10)
                    res = "W00" + stt.ToString();
                else if (stt < 100)
                    res = "W0" + stt.ToString();
                else
                    res = "W" + stt.ToString();
                txtID.Text = res;
            }
            else
            {
                txtID.Text = "W001";
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Print(this.panel);
        }

        public void addData()
        {
            string iD, name, quantity, type, price, color;

            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                iD = dataGridView.Rows[i].Cells[0].Value.ToString();
                name = dataGridView.Rows[i].Cells[1].Value.ToString();
                quantity = dataGridView.Rows[i].Cells[2].Value.ToString();
                type = dataGridView.Rows[i].Cells[3].Value.ToString();
                price = dataGridView.Rows[i].Cells[4].Value.ToString();
                color = dataGridView.Rows[i].Cells[5].Value.ToString();

                products = new BUS_Products(iD, cbVendorID.Text, name, quantity, type, price, color);
                products.addQuery();
            }

            wareHouse = new BUS_WareHouse(txtID.Text, txtDate.Text);
            wareHouse.addQuery();

            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                iD = dataGridView.Rows[i].Cells[0].Value.ToString();

                detailWareHouse = new BUS_DetailWareHouse(txtID.Text, iD);
                detailWareHouse.addQuery();
            }
        }

        private void btn_Complete_Click(object sender, EventArgs e)
        {
            string dateInput = txtDate.Text;

            string vendorName = txtVendorName.Text;
            string circular = txtCircular.Text;
            string inputStock = txtStock.Text;
            string location = txtLocation.Text;

            int dataTable = dataGridView.Rows.Count;
            string total = txtTotal.Text;
            string preparedBy = txtPreparedName.Text;

            if(dateInput == "")
            {
                MessageBox.Show("Please, Enter the import date");
                txtDate.Focus();
            } 
            else if (vendorName == "")
            {
                MessageBox.Show("Please, Enter the vendor name");
                txtVendorName.Focus();
            }
            else if (circular == "")
            {
                MessageBox.Show("Please, Enter the circular");
                txtCircular.Focus();
            }
            else if (inputStock == "")
            {
                MessageBox.Show("Please, Enter the input at stock");
                txtStock.Focus();
            }
            else if (location == "")
            {
                MessageBox.Show("Please, Enter the location of stock");
                txtLocation.Focus();
            }
            else if (dataTable <= 1)
            {
                MessageBox.Show("Please, Enter the list of goods");
                dataGridView.Focus();
            }
            else if (total == "")
            {
                MessageBox.Show("Please, Enter the total amount");
                txtTotal.Focus();
            }
            else if (preparedBy == "")
            {
                MessageBox.Show("Please, Enter the accountant name");
                txtPreparedName.Focus();
            }
            else
            {
                // Add data from DataGridView to MSSQL
                addData();
                MessageBox.Show("Import Successfully");
                this.Close();
            }
        }

        Bitmap memory;
        public void getPrintArea(Panel pnl)
        {
            memory = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memory, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        public void printDoc_printPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(memory, (pageArea.Width / 2) - (this.panel.Width / 2), this.panel.Location.Y);
        }

        public void Print(Panel pnl)
        {
            PrinterSettings printerSettings = new PrinterSettings();
            panel = pnl;
            getPrintArea(pnl);
            printPreviewDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDoc_printPage);
            printPreviewDialog.ShowDialog();
        }
    }
}
