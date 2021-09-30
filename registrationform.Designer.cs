namespace project3rdsem
{
    partial class registrationform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_fname = new System.Windows.Forms.Label();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.textBox_lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox__phoneno = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_upload = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.Student_list = new System.Windows.Forms.DataGridView();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Student_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_fname
            // 
            this.label_fname.AutoSize = true;
            this.label_fname.BackColor = System.Drawing.Color.Transparent;
            this.label_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_fname.Location = new System.Drawing.Point(-2, 358);
            this.label_fname.Name = "label_fname";
            this.label_fname.Size = new System.Drawing.Size(120, 24);
            this.label_fname.TabIndex = 1;
            this.label_fname.Text = "First name :";
            // 
            // textBox_fname
            // 
            this.textBox_fname.Location = new System.Drawing.Point(115, 356);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(165, 30);
            this.textBox_fname.TabIndex = 1;
            // 
            // textBox_lname
            // 
            this.textBox_lname.Location = new System.Drawing.Point(402, 356);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.Size = new System.Drawing.Size(165, 30);
            this.textBox_lname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(286, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(-1, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date Of Birth :";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(145, 398);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(364, 30);
            this.dateTimePicker_date.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(574, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gender :";
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Checked = true;
            this.radioButton_male.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton_male.Location = new System.Drawing.Point(678, 398);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(80, 29);
            this.radioButton_male.TabIndex = 5;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton_female.Location = new System.Drawing.Point(763, 398);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(104, 29);
            this.radioButton_female.TabIndex = 6;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(573, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phone no :";
            // 
            // textBox__phoneno
            // 
            this.textBox__phoneno.Location = new System.Drawing.Point(685, 356);
            this.textBox__phoneno.Name = "textBox__phoneno";
            this.textBox__phoneno.Size = new System.Drawing.Size(194, 30);
            this.textBox__phoneno.TabIndex = 3;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(115, 439);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(499, 67);
            this.textBox_address.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(4, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Address :";
            // 
            // button_upload
            // 
            this.button_upload.BackColor = System.Drawing.Color.SandyBrown;
            this.button_upload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_upload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_upload.Location = new System.Drawing.Point(694, 561);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(174, 37);
            this.button_upload.TabIndex = 8;
            this.button_upload.Text = "Upload photo";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.Button_upload_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.LightCoral;
            this.button_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_clear.Location = new System.Drawing.Point(208, 541);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(166, 53);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_add.Location = new System.Drawing.Point(384, 541);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(166, 53);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // Student_list
            // 
            this.Student_list.AllowUserToAddRows = false;
            this.Student_list.AllowUserToDeleteRows = false;
            this.Student_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Student_list.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.Student_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.FirstName,
            this.LastName,
            this.PhoneNo,
            this.BirthDate,
            this.Gender,
            this.Address,
            this.Photo});
            this.Student_list.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.Student_list.Location = new System.Drawing.Point(7, 3);
            this.Student_list.Name = "Student_list";
            this.Student_list.ReadOnly = true;
            this.Student_list.RowTemplate.Height = 80;
            this.Student_list.Size = new System.Drawing.Size(872, 343);
            this.Student_list.TabIndex = 20;
            // 
            // SN
            // 
            this.SN.HeaderText = "SN";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 50;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 200;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 200;
            // 
            // PhoneNo
            // 
            this.PhoneNo.HeaderText = "PhoneNo";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            this.PhoneNo.Width = 200;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.Width = 200;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 150;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 300;
            // 
            // Photo
            // 
            this.Photo.HeaderText = "Photo";
            this.Photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            this.Photo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Photo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Photo.Width = 150;
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.BackColor = System.Drawing.Color.Silver;
            this.pictureBox_photo.Location = new System.Drawing.Point(716, 439);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(134, 118);
            this.pictureBox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_photo.TabIndex = 16;
            this.pictureBox_photo.TabStop = false;
            // 
            // registrationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 603);
            this.Controls.Add(this.Student_list);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.pictureBox_photo);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox__phoneno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton_female);
            this.Controls.Add(this.radioButton_male);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_lname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_fname);
            this.Controls.Add(this.label_fname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "registrationform";
            this.Text = "registrationform";
            this.Load += new System.EventHandler(this.Registrationform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Student_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_fname;
        private System.Windows.Forms.TextBox textBox_fname;
        private System.Windows.Forms.TextBox textBox_lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox__phoneno;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView Student_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewImageColumn Photo;
    }
}