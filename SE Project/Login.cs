using System;
using System.Data;
using System.Windows.Forms;
using BUS;

namespace SE_Project
{
    public partial class Login : Form
    {
        BUS_Login BUS_Login = new BUS_Login();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string ps = txtPW.Text;
            if(user == "" || ps == "")
            {
                MessageBox.Show("Please, Enter your account");
                if (user == "")
                {
                    txtUser.Focus();
                }
                else if (ps == "")
                {
                    txtPW.Focus();
                }
            }
            else
            {
                DataTable tb = BUS_Login.selectQueryUserPW(user, ps);
                if(tb.Rows.Count > 0)
                {

                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                } 
                else
                {
                    MessageBox.Show("Your account is not exist, please try again");
                    txtUser.Focus();
                }
            }
        }
    }
}
