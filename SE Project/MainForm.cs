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
        private Report rp;
        private ExportOrders eo;
        private WareHouse wh; 
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            eo = new ExportOrders();
            eo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rp = new Report();
            rp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wh = new WareHouse();
            wh.Show();
        }
    }
}
