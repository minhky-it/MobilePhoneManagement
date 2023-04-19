using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using BUS;

namespace SE_Project
{
    public partial class WareHouse : Form
    {
        BUS_Products products;
        PrintPreviewDialog printPreviewDialog = new  PrintPreviewDialog();
        PrintDocument printDocument = new PrintDocument();
        public WareHouse()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            txtID.Focus();
            products = new BUS_Products("","","","","","","");
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Print(this.panel);
        }

        private void btn_Complete_Click(object sender, EventArgs e)
        {
            // Add data from DataGridView to MSSQL
            string iD, name, quantity, type, price, color;

            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                iD = dataGridView.Rows[i].Cells[0].Value.ToString();
                name = dataGridView.Rows[i].Cells[1].Value.ToString();
                quantity = dataGridView.Rows[i].Cells[2].Value.ToString();
                type = dataGridView.Rows[i].Cells[3].Value.ToString();
                price = dataGridView.Rows[i].Cells[4].Value.ToString();
                color = dataGridView.Rows[i].Cells[5].Value.ToString();

                products = new BUS_Products(iD, txtVendorID.Text, name, quantity, type, price, color);
                products.addQuery();
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
