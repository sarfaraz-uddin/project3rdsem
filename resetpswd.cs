using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace project3rdsem
{
    public partial class resetpswd : Form
    {
        string username = forgotpswd.to;

        public resetpswd()
        {
            InitializeComponent();
        }

        private void finsih_reset(object sender, EventArgs e)
        {
            if (textBox_newpsd.Text == textBox_renewpsd.Text)
            {
                SqlConnection con=new SqlConnection(@"Data Source=DESKTOP-96FNSP3\SQLEXPRESS;Initial Catalog=project3rdsem;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[forgotpswd] SET [password] ='" + textBox_renewpsd.Text + "' WHERE username='" + username + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" password reset successfully");
                login l = new login();
                this.Hide();
                l.Show();
            }
            else
            {
                MessageBox.Show("the new passwords do not match so enter correct password");
            }
        }
    }
}
