using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Windows.Forms;
using BUS;

namespace SE_Project
{
    public partial class DeliveryBill : Form
    {
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        PrintDocument printDocument = new PrintDocument();
        BUS_OrderForm BUS_OrderForm = new BUS_OrderForm();
        BUS_Products BUS_Products = new BUS_Products();

        private string text1;
        private string text2;
        private string text3;
        private string text4;

        public DeliveryBill()
        {
            InitializeComponent();
        }

        public DeliveryBill (string receiverName, string phone, string entryDate, string orderID) : this()
        {
            text1 = receiverName;
            text2 = phone;
            text3 = entryDate;
            text4 = orderID;
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

        private void btn_Print_Click_1(object sender, EventArgs e)
        {
            Print(this.panel);
        }

        private void DeliveryBill_Load(object sender, EventArgs e)
        {
            txtReceiverName.Text = text1;
            txtPhone.Text = text2;
            txtDate.Text = text3;
            txtOrderID.Text = text4;

            dataGridView.DataSource = BUS_OrderForm.selectByOrderID(text4);

            txtAddress.Text = dataGridView.Rows[0].Cells[1].Value.ToString();
            txtPayment.Text = dataGridView.Rows[0].Cells[2].Value.ToString();
            txtDelivery.Text = dataGridView.Rows[0].Cells[3].Value.ToString();
            txtDeliveryDate.Text = dataGridView.Rows[0].Cells[4].Value.ToString();

            dataGridView.DataSource = BUS_Products.selectOrderId(text4);
        }
    }
}
