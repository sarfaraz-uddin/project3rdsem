using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project3rdsem
{
    public partial class StudentManagementSystem : Form
    {
        public StudentManagementSystem()
        {
            InitializeComponent();
            customizedesign();
        }

        private void StudentManagementSystem_Load(object sender, EventArgs e)
        {

        }
        private void customizedesign()
        {
            panel_stdsubmenu.Visible = false;
            panel_cousubmenu.Visible = false;
        }
        private void hidesubmenu()
        {
            if (panel_stdsubmenu.Visible == true)
                panel_stdsubmenu.Visible = false;
            if (panel_cousubmenu.Visible == true)
                panel_cousubmenu.Visible = false;
        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void Button_student_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_stdsubmenu);
        }

        private void Button_stdregister_Click(object sender, EventArgs e)
        {
            openchildform(new registrationform());
            hidesubmenu();
        }

        private void Button_stdmanage_Click(object sender, EventArgs e)
        {
            openchildform(new managestudent());
            hidesubmenu();
        }

        private void Button_stdstatus_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hidesubmenu();
        }

        private void Button_stdprint_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hidesubmenu();
        }

        private void Button_course_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_cousubmenu);
        }

        private void Button_counew_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hidesubmenu();
        }

        private void Button_coumanage_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hidesubmenu();
        }

        private void Button_couprint_Click(object sender, EventArgs e)
        {
            //..
            //your code
            //..
            hidesubmenu();
        }
        //to show register form in main form
        private Form activeform = null;
        private void openchildform(Form childform)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childform);
            panel_main.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void Exit_button(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Dashboard_Click(object sender, EventArgs e)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            panel_main.Controls.Add(panel_cover);
        }
    }
}
