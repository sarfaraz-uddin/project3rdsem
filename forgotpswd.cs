using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace project3rdsem
{
    public partial class forgotpswd : Form
    {
        string randomcode;
        public static string to;
        public forgotpswd()
        {
            InitializeComponent();
        }

        private void send_code(object sender, EventArgs e)
        {
            string from, pass, messagebody;
            Random rand = new Random();
            randomcode = (rand.Next(99999)).ToString();
            MailMessage message = new MailMessage();
            to = (textBox_emailadd.Text).ToString();
            from = "alphatalibaan7860@gmail.com";
            pass = "miememeyu";
            messagebody = "your password reset code is" + randomcode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "password resting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("code sent succesfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex. Message);
            }

            
        }

        private void verify_coode(object sender, EventArgs e)
        {
            if (randomcode == (textBox_vercode.Text).ToString())
            {
                to = textBox_emailadd.Text;
                resetpswd rp = new resetpswd();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("wrong code");
            }
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.Show();
        }
    }
}
