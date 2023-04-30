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
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        PrintDocument printDocument = new PrintDocument();
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

        private void cbOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            formload();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Print(this.panel);
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
