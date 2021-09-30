namespace project3rdsem
{
    partial class managestudent
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
            this.button_remove = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.Student_list = new System.Windows.Forms.DataGridView();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox__phoneno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.label_fname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_list)).BeginInit();
            this.SuspendLayout();
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.Tomato;
            this.button_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_remove.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_remove.Location = new System.Drawing.Point(341, 535);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(148, 61);
            this.button_remove.TabIndex = 10;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.remove_click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.LightPink;
            this.button_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_edit.Location = new System.Drawing.Point(178, 535);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(148, 61);
            this.button_edit.TabIndex = 9;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            // 
            // button_upload
            // 
            this.button_upload.BackColor = System.Drawing.Color.SandyBrown;
            this.button_upload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_upload.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_upload.Location = new System.Drawing.Point(706, 561);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(165, 35);
            this.button_upload.TabIndex = 8;
            this.button_upload.Text = "Upload photo";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.Button_upload_Click);
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.BackColor = System.Drawing.Color.LavenderBlush;
            this.pictureBox_photo.Location = new System.Drawing.Point(732, 434);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(120, 121);
            this.pictureBox_photo.TabIndex = 34;
            this.pictureBox_photo.TabStop = false;
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
            this.Student_list.Location = new System.Drawing.Point(9, 4);
            this.Student_list.Name = "Student_list";
            this.Student_list.ReadOnly = true;
            this.Student_list.RowTemplate.Height = 80;
            this.Student_list.Size = new System.Drawing.Size(872, 343);
            this.Student_list.TabIndex = 48;
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
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(118, 440);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(499, 67);
            this.textBox_address.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(7, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "Address :";
            // 
            // textBox__phoneno
            // 
            this.textBox__phoneno.Location = new System.Drawing.Point(688, 357);
            this.textBox__phoneno.Name = "textBox__phoneno";
            this.textBox__phoneno.Size = new System.Drawing.Size(191, 30);
            this.textBox__phoneno.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(576, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 46;
            this.label5.Text = "Phone no :";
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton_female.Location = new System.Drawing.Point(766, 399);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(104, 29);
            this.radioButton_female.TabIndex = 42;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Checked = true;
            this.radioButton_male.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton_male.Location = new System.Drawing.Point(681, 399);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(80, 29);
            this.radioButton_male.TabIndex = 40;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(577, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "Gender :";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(148, 399);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(364, 30);
            this.dateTimePicker_date.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(2, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Date Of Birth :";
            // 
            // textBox_lname
            // 
            this.textBox_lname.Location = new System.Drawing.Point(405, 357);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.Size = new System.Drawing.Size(165, 30);
            this.textBox_lname.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(289, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Last name :";
            // 
            // textBox_fname
            // 
            this.textBox_fname.Location = new System.Drawing.Point(118, 357);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(165, 30);
            this.textBox_fname.TabIndex = 35;
            // 
            // label_fname
            // 
            this.label_fname.AutoSize = true;
            this.label_fname.BackColor = System.Drawing.Color.Transparent;
            this.label_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_fname.Location = new System.Drawing.Point(1, 359);
            this.label_fname.Name = "label_fname";
            this.label_fname.Size = new System.Drawing.Size(120, 24);
            this.label_fname.TabIndex = 36;
            this.label_fname.Text = "First name :";
            // 
            // managestudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 603);
            this.Controls.Add(this.Student_list);
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
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.pictureBox_photo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "managestudent";
            this.Text = "managestudent";
            this.Load += new System.EventHandler(this.Managestudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.DataGridView Student_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Photo;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox__phoneno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_fname;
        private System.Windows.Forms.Label label_fname;
    }
}