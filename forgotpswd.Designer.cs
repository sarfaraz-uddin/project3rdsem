namespace project3rdsem
{
    partial class forgotpswd
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
            this.textBox_emailadd = new System.Windows.Forms.TextBox();
            this.textBox_vercode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_sendcode = new System.Windows.Forms.Button();
            this.button_vercode = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_emailadd
            // 
            this.textBox_emailadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_emailadd.Location = new System.Drawing.Point(54, 81);
            this.textBox_emailadd.Name = "textBox_emailadd";
            this.textBox_emailadd.Size = new System.Drawing.Size(684, 30);
            this.textBox_emailadd.TabIndex = 0;
            // 
            // textBox_vercode
            // 
            this.textBox_vercode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_vercode.Location = new System.Drawing.Point(54, 240);
            this.textBox_vercode.Name = "textBox_vercode";
            this.textBox_vercode.Size = new System.Drawing.Size(684, 30);
            this.textBox_vercode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your Email Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(696, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "A recovery code has been sent to your email. Plz enter the code.";
            // 
            // button_sendcode
            // 
            this.button_sendcode.FlatAppearance.BorderSize = 3;
            this.button_sendcode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_sendcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sendcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sendcode.ForeColor = System.Drawing.Color.Black;
            this.button_sendcode.Location = new System.Drawing.Point(319, 122);
            this.button_sendcode.Name = "button_sendcode";
            this.button_sendcode.Size = new System.Drawing.Size(149, 49);
            this.button_sendcode.TabIndex = 1;
            this.button_sendcode.Text = "Send Code";
            this.button_sendcode.UseVisualStyleBackColor = true;
            this.button_sendcode.Click += new System.EventHandler(this.send_code);
            // 
            // button_vercode
            // 
            this.button_vercode.FlatAppearance.BorderSize = 3;
            this.button_vercode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_vercode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_vercode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_vercode.ForeColor = System.Drawing.Color.Black;
            this.button_vercode.Location = new System.Drawing.Point(312, 276);
            this.button_vercode.Name = "button_vercode";
            this.button_vercode.Size = new System.Drawing.Size(165, 54);
            this.button_vercode.TabIndex = 3;
            this.button_vercode.Text = "Verify Code";
            this.button_vercode.UseVisualStyleBackColor = true;
            this.button_vercode.Click += new System.EventHandler(this.verify_coode);
            // 
            // button_cancel
            // 
            this.button_cancel.FlatAppearance.BorderSize = 3;
            this.button_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.Black;
            this.button_cancel.Location = new System.Drawing.Point(610, 349);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(128, 54);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // forgotpswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_vercode);
            this.Controls.Add(this.button_sendcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_vercode);
            this.Controls.Add(this.textBox_emailadd);
            this.Name = "forgotpswd";
            this.Text = "forgotpswd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_emailadd;
        private System.Windows.Forms.TextBox textBox_vercode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_sendcode;
        private System.Windows.Forms.Button button_vercode;
        private System.Windows.Forms.Button button_cancel;
    }
}