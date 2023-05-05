using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void formload()
        {
            btnExport.FlatStyle = FlatStyle.Flat;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnReport.FlatStyle = FlatStyle.Flat;
            
            btnExport.FlatAppearance.BorderSize = 0;
            btnImport.FlatAppearance.BorderSize = 0;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnReport.FlatAppearance.BorderSize = 0;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            formload();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Export ep = new Export();
            ep.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            WareHouse wh = new WareHouse();
            wh.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://localhost:44397/OrderForms");
        }
    }
}
