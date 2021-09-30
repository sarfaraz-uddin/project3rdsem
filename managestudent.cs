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
    public partial class managestudent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-96FNSP3\SQLEXPRESS;Initial Catalog=project3rdsem;Integrated Security=True");
        public managestudent()
        {
            InitializeComponent();
        }

        private void remove_click(object sender, EventArgs e)
        {
            try
            {
                //open sql connection
                con.Open();
                //for removinf if any of the cells are selected int he row
                //student_list.Rows.RemoveAt(student_list.CurrentRow.Index);
                if (Student_list.SelectedRows.Count > 0)
                {
                    //for removing single row
                    //student_list.Rows.RemoveAt(student_list.SelectedRows[0].Index);

                    //for removing multiple rows
                    foreach (DataGridViewRow row in Student_list.SelectedRows)
                    {

                        //int id = Convert.ToInt32(row.Cells["STDID"].Value);

                        //save data to database
                        string query = "Delete from student_details where id=@parameter_id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        //cmd.Parameters.AddWithValue("@parameter_id", id);
                        cmd.ExecuteNonQuery();
                        Student_list.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Removed succesfully");
                        //perform save action or select query

                    }
                    int i = 0;
                    foreach (DataGridViewRow row in Student_list.Rows)
                    {
                        i++;
                        row.Cells["SN"].Value = i;
                    }
                }
                else
                {
                    MessageBox.Show("select a row to delete");
                }

            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //close sql connection
                con.Close();
            }
            Displaydata();
        }//for removing single row if any cell is clicked
         //Student_list.Rows.RemoveAt(Student_list.CurrentRow.Index);

        //    if (Student_list.SelectedRows.Count > 0)
        //    {
        //        //for removing single row
        //        //Student_list.Rows.RemoveAt(Student_list.SelectedRows[0].Index);
        //        //for removing multiple rows
        //        foreach(DataGridViewRow row in Student_list.SelectedRows)
        //        {
        //            Student_list.Rows.RemoveAt(row.Index);
        //        }
        //        int i = 0;
        //        foreach(DataGridViewRow row in Student_list.Rows)
        //        {
        //            row.Cells["SN"].Value = i;

        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("please select a row to remove");
        //    }
        //}
            private void Displaydata()
        {
            try
            {
                con.Open();
                //string st_fname = textBox_fname.Text;
                //string st_lname = textBox_lname.Text;
                //string mobile = textBox__phoneno.Text;
                //DateTime Bdate = dateTimePicker_date.Value;
                //string Gender = radioButton_male.Checked ? "Male" : "Female";
                //string Address = textBox_address.Text;
                
                //save data to database
                string query = "Select * from Student_Details";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //cmd.Parameters.AddWithValue("@parameter_StdFirstName", st_fname);
                //cmd.Parameters.AddWithValue("@parameter_StdLastName", st_lname);
                //cmd.Parameters.AddWithValue("@parameter_Phone", mobile);
                //cmd.Parameters.AddWithValue("@parameter_BirthDate", Bdate);
                //cmd.Parameters.AddWithValue("@parameter_StdLastName", Gender);
                //cmd.Parameters.AddWithValue("@parameter_StdLastName", Address);
                //cmd.ExecuteNonQuery();
                Student_list.Rows.Clear();
                int i = 0;
                foreach (DataRow dataRow in dt.Rows)
                {
                    Student_list.Rows.Add();
                    Student_list.Rows[i].Cells["FirstName"].Value = dataRow["StdFirstName"];
                    Student_list.Rows[i].Cells["LastName"].Value = dataRow["StdLastName"];
                    Student_list.Rows[i].Cells["PhoneNo"].Value = dataRow["Phone"];
                    Student_list.Rows[i].Cells["BirthDate"].Value = dataRow["BirthDate"];
                    Student_list.Rows[i].Cells["Gender"].Value = dataRow["Gender"];
                    Student_list.Rows[i].Cells["Address"].Value = dataRow["Address"];
                    //if (dataRow["UploadPhoto"].ToString() != null && dataRow["UploadPhoto"].ToString() != "")
                   // {
                       // if (File.Exists(dataRow["UploadPhoto"].ToString()))
                       // {
                            Student_list.Rows[i].Cells["Photo"].Value = Image.FromFile(dataRow["UploadPhoto"].ToString());
                       // }
                   // }
                    i++;
                }
                MessageBox.Show("saved succesfully");
                //if ((textBox_fname.Text == "") || (textBox_lname.Text == "") || (textBox__phoneno.Text == "") || (textBox_address.Text == ""))
                //{
                //  MessageBox.Show("please fill all the required field");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void Button_upload_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png)|*.jpg;*.jpeg;.*.gif;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_photo.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void Managestudent_Load(object sender, EventArgs e)
        {
            Displaydata();
        }
    }
}
