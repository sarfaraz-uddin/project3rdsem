namespace project3rdsem
{
    partial class resetpswd
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
            this.textBox_newpsd = new System.Windows.Forms.TextBox();
            this.textBox_renewpsd = new System.Windows.Forms.TextBox();
            this.button_rstpwd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_newpsd
            // 
            this.textBox_newpsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_newpsd.Location = new System.Drawing.Point(66, 87);
            this.textBox_newpsd.Name = "textBox_newpsd";
            this.textBox_newpsd.Size = new System.Drawing.Size(662, 30);
            this.textBox_newpsd.TabIndex = 0;
            // 
            // textBox_renewpsd
            // 
            this.textBox_renewpsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_renewpsd.Location = new System.Drawing.Point(66, 185);
            this.textBox_renewpsd.Name = "textBox_renewpsd";
            this.textBox_renewpsd.Size = new System.Drawing.Size(662, 30);
            this.textBox_renewpsd.TabIndex = 1;
            // 
            // button_rstpwd
            // 
            this.button_rstpwd.FlatAppearance.BorderSize = 3;
            this.button_rstpwd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_rstpwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rstpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rstpwd.ForeColor = System.Drawing.Color.Black;
            this.button_rstpwd.Location = new System.Drawing.Point(327, 239);
            this.button_rstpwd.Name = "button_rstpwd";
            this.button_rstpwd.Size = new System.Drawing.Size(149, 53);
            this.button_rstpwd.TabIndex = 2;
            this.button_rstpwd.Text = "Reset";
            this.button_rstpwd.UseVisualStyleBackColor = true;
            this.button_rstpwd.Click += new System.EventHandler(this.finsih_reset);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter new password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(61, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm New Password";
            // 
            // resetpswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 328);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_rstpwd);
            this.Controls.Add(this.textBox_renewpsd);
            this.Controls.Add(this.textBox_newpsd);
            this.Name = "resetpswd";
            this.Text = "resetpswd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_newpsd;
        private System.Windows.Forms.TextBox textBox_renewpsd;
        private System.Windows.Forms.Button button_rstpwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}