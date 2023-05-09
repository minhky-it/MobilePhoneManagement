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
using System.Windows.Forms.DataVisualization.Charting;
namespace SE_Project
{
    public partial class Report : Form
    {
        private BUS_DetailReceipt DetailReceipt = new BUS_DetailReceipt();
        private BUS_OrderForm orderForm = new BUS_OrderForm();
        private BUS_WareHouse warehouse = new BUS_WareHouse();
        private BUS_Bill bill = new BUS_Bill();
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            //Top selling
            grdTop.DataSource = DetailReceipt.topselling();
            drawChartTop();
            //Revenue
            //Goods out
            grdOut.DataSource = orderForm.selectQuery();
            grdGoodsOut.DataSource = orderForm.selectQueryGoodsOut();
            //Goods in
            grdIn.DataSource = warehouse.selectQuery();
            grdnAll.DataSource = warehouse.selectQueryDetailAll();
        }
        private void drawChartTop()
        {
            DataTable dt = DetailReceipt.topselling();

            chartTop.Titles.Add("Top Selling Products");

            chartTop.Series["productID"].ChartType = SeriesChartType.Column;
            chartTop.Series["productID"].XValueMember = "productID";
            chartTop.Series["productID"].YValueMembers = "quantity";
            chartTop.DataSource = dt;
            chartTop.DataBind();

            chartTop.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;

            chartTop.Series["productID"].IsValueShownAsLabel = true;
            chartTop.Series["productID"].LabelForeColor = Color.White;
            chartTop.Series["productID"].LabelBackColor = Color.Gray;
            chartTop.ChartAreas[0].AxisX.LabelStyle.Angle = 90;                            
            chartTop.ChartAreas[0].AxisX.Interval = 1;
            chartTop.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont;
            chartTop.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8);
            chartTop.ChartAreas[0].InnerPlotPosition.Auto = false;
            chartTop.ChartAreas[0].InnerPlotPosition.Width = 90;
            chartTop.ChartAreas[0].InnerPlotPosition.Height = 80;
            chartTop.ChartAreas[0].InnerPlotPosition.X = 10;
            chartTop.ChartAreas[0].InnerPlotPosition.Y = 10;

        }
        //draw chart revenue
        private void drawRevenue(DataTable dt)
        {
            chartRevenue.Series["total"].ChartType = SeriesChartType.Column;
            chartRevenue.Series["total"].XValueMember = "billID";
            chartRevenue.Series["total"].YValueMembers = "total";
            chartRevenue.DataSource = dt;
            chartRevenue.DataBind();

            chartRevenue.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;

            chartRevenue.Series["total"].IsValueShownAsLabel = true;
            chartRevenue.Series["total"].LabelForeColor = Color.White;
            chartRevenue.Series["total"].LabelBackColor = Color.Gray;
            chartRevenue.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
            chartRevenue.ChartAreas[0].AxisX.Interval = 1;
            chartRevenue.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont;
            chartRevenue.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8);
            chartRevenue.ChartAreas[0].InnerPlotPosition.Auto = true;
            chartRevenue.ChartAreas[0].InnerPlotPosition.Width = 90;
            chartRevenue.ChartAreas[0].InnerPlotPosition.Height = 80;
   
        }
        private void showRevenue() {
            string month = cbMonth.SelectedItem.ToString();
            DataTable dt = bill.selectQueryMonthly(month);
            grdRevenue.DataSource = dt;
            int total = 0;
            foreach (DataGridViewRow row in grdRevenue.Rows)
            {
                total += Convert.ToInt32(row.Cells["total"].Value);
                //More code here
            }
            txtTotal.Text = total.ToString("C0");
            drawRevenue(dt);
        }
        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            showRevenue();
        }

        private void grdOut_Click(object sender, EventArgs e)
        {
            string id = grdOut.CurrentRow.Cells[0].Value.ToString();
            grdDetailOut.DataSource = orderForm.selectQueryID(id);
        }

        private void grdGoodinDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = grdIn.CurrentRow.Cells[0].Value.ToString();
            grdGoodinDetail.DataSource = warehouse.selectQueryID(id);
        }
    }
}
