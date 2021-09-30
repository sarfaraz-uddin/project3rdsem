using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project3rdsem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void exit_btn(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_pw(object sender, MouseEventArgs e)
        {
            textBox_pw.UseSystemPasswordChar = false;
        }

        private void picdown_pw(object sender, MouseEventArgs e)
        {
            textBox_pw.UseSystemPasswordChar = true;

        }

        private void Button_resetpw_Click(object sender, EventArgs e)
        {
            forgotpswd fp = new forgotpswd();
            this.Hide();
            fp.Show();
        }

        private void login_btn(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-96FNSP3\SQLEXPRESS;Initial Catalog=project3rdsem;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from forgotpswd where username='"+textBox_username.Text+"' and password='"+textBox_pw.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("login successfully");
                StudentManagementSystem sms = new StudentManagementSystem();
                this.Hide();
                sms.Show();
            }
            else
            {
                MessageBox.Show("login failed");
            }
        }
    }
}
