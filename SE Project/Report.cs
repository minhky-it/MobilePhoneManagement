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
    public partial class Report : Form
    {
        private BUS_DetailReceipt DetailReceipt = new BUS_DetailReceipt();
        private BUS_Bill bill = new BUS_Bill();
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            //Top selling
            grdTop.DataSource = DetailReceipt.topselling();
            //Revenue
        }
        private void showRevenue() {
            string month = cbMonth.SelectedItem.ToString();
            grdRevenue.DataSource = bill.selectQueryMonthly(month);
            int total = 0;
            foreach (DataGridViewRow row in grdRevenue.Rows)
            {
                total += Convert.ToInt32(row.Cells["total"].Value);
                //More code here
            }
            txtTotal.Text = total.ToString("C0");
        }
        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            showRevenue();
        }
    }
}
