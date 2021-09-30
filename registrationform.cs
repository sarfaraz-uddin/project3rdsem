using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project3rdsem
{
    public partial class registrationform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-96FNSP3\SQLEXPRESS;Initial Catalog=project3rdsem;Integrated Security=True");
        public registrationform()
        {
            InitializeComponent();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string st_fname = textBox_fname.Text;
                string st_lname = textBox_lname.Text;
                string mobile = textBox__phoneno.Text;
                DateTime Bdate = dateTimePicker_date.Value;
                string Gender = radioButton_male.Checked ? "Male" : "Female";
                string Address = textBox_address.Text;
                string new_path = "";
                if(ofd!=null)
                {
                    new_path = Application.StartupPath + "/UploadedImages" + Path.GetFileName(ofd.FileName);
                    File.Copy(ofd.FileName, new_path, true);
                }

                //save data to database
                string query = "Insert into Student_Details(StdFirstName,StdLastName,Phone,BirthDate,Gender,Address,UploadPhoto) values (@parameter_StdFirstName, @parameter_StdLastName,@parameter_Phone,@parameter_BirthDate,@parameter_Gender,@parameter_Address,@parameter_UploadPhoto)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@parameter_StdFirstName", st_fname);
                cmd.Parameters.AddWithValue("@parameter_StdLastName", st_lname);
                cmd.Parameters.AddWithValue("@parameter_Phone", mobile);
                cmd.Parameters.AddWithValue("@parameter_BirthDate", Bdate);
                cmd.Parameters.AddWithValue("@parameter_Gender", Gender);
                cmd.Parameters.AddWithValue("@parameter_Address", Address);
                cmd.Parameters.AddWithValue("@parameter_UploadPhoto", new_path);
                cmd.ExecuteNonQuery();
                if ((textBox_fname.Text == "") || (textBox_lname.Text == "") || (textBox__phoneno.Text == "") || (textBox_address.Text == ""))
                {
                    MessageBox.Show("please fill all the required field");
                }
                MessageBox.Show("saved succesfully");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            
            //string fname = textBox_fname.Text;
            //string lname = textBox_lname.Text;
            //string phone = textBox__phoneno.Text;
            //DateTime bdate = dateTimePicker_date.Value;
            //string gender = radioButton_male.Checked ? "Male" : "Female";
            //string address = textBox_address.Text;
            ////create new rows
            //Student_list.Rows.Add();
            ////set data to display
            //Student_list.Rows.Add(Student_list.Rows.Count, fname, lname, phone, bdate, gender, address);
            Displaydata();



        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            textBox_fname.Text = "";
            textBox_lname.Text = "";
            textBox__phoneno.Text = "";
            textBox_address.Text = "";
            pictureBox_photo.Image = null;
        }

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
                    if (dataRow["UploadPhoto"].ToString() != null && dataRow["UploadPhoto"].ToString() != "")
                    {
                        if (File.Exists(dataRow["UploadPhoto"].ToString()))
                        {
                            Student_list.Rows[i].Cells["Photo"].Value = Image.FromFile(dataRow["UploadPhoto"].ToString());
                        }
                    }
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

        private void Registrationform_Load(object sender, EventArgs e)
        {
            Displaydata();
        }
    }
}
