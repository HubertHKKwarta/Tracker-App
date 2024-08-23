namespace expensisapp
{
    partial class Registerapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registerapp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Register_registerbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Register_showpassword = new System.Windows.Forms.CheckBox();
            this.Register_button = new System.Windows.Forms.Button();
            this.Reg_password = new System.Windows.Forms.TextBox();
            this.Register_password = new System.Windows.Forms.Label();
            this.Register_username = new System.Windows.Forms.TextBox();
            this.Register_usarename = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Regis_confpass = new System.Windows.Forms.TextBox();
            this.Register_confpass = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Register_registerbutton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 477);
            this.panel1.TabIndex = 1;
            // 
            // Register_registerbutton
            // 
            this.Register_registerbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_registerbutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_registerbutton.Location = new System.Drawing.Point(16, 425);
            this.Register_registerbutton.Name = "Register_registerbutton";
            this.Register_registerbutton.Size = new System.Drawing.Size(275, 40);
            this.Register_registerbutton.TabIndex = 8;
            this.Register_registerbutton.Text = "Sign In";
            this.Register_registerbutton.UseVisualStyleBackColor = true;
            this.Register_registerbutton.Click += new System.EventHandler(this.Register_registerbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sign In Here";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Do you have account?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Income and Expenses Tracker";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 143);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Register_showpassword
            // 
            this.Register_showpassword.AutoSize = true;
            this.Register_showpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_showpassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_showpassword.Location = new System.Drawing.Point(587, 365);
            this.Register_showpassword.Name = "Register_showpassword";
            this.Register_showpassword.Size = new System.Drawing.Size(117, 20);
            this.Register_showpassword.TabIndex = 15;
            this.Register_showpassword.Text = "Show password";
            this.Register_showpassword.UseVisualStyleBackColor = true;
            this.Register_showpassword.CheckedChanged += new System.EventHandler(this.Register_showpassword_CheckedChanged);
            // 
            // Register_button
            // 
            this.Register_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_button.Location = new System.Drawing.Point(338, 425);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(100, 40);
            this.Register_button.TabIndex = 14;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Reg_password
            // 
            this.Reg_password.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reg_password.Location = new System.Drawing.Point(349, 239);
            this.Reg_password.Name = "Reg_password";
            this.Reg_password.PasswordChar = '*';
            this.Reg_password.Size = new System.Drawing.Size(355, 22);
            this.Reg_password.TabIndex = 13;
            this.Reg_password.TextChanged += new System.EventHandler(this.Login_password_TextChanged);
            // 
            // Register_password
            // 
            this.Register_password.AutoSize = true;
            this.Register_password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_password.Location = new System.Drawing.Point(356, 212);
            this.Register_password.Name = "Register_password";
            this.Register_password.Size = new System.Drawing.Size(69, 20);
            this.Register_password.TabIndex = 12;
            this.Register_password.Text = "Password";
            // 
            // Register_username
            // 
            this.Register_username.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_username.Location = new System.Drawing.Point(349, 175);
            this.Register_username.Name = "Register_username";
            this.Register_username.Size = new System.Drawing.Size(355, 22);
            this.Register_username.TabIndex = 11;
            // 
            // Register_usarename
            // 
            this.Register_usarename.AutoSize = true;
            this.Register_usarename.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_usarename.Location = new System.Drawing.Point(356, 137);
            this.Register_usarename.Name = "Register_usarename";
            this.Register_usarename.Size = new System.Drawing.Size(71, 20);
            this.Register_usarename.TabIndex = 10;
            this.Register_usarename.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Register";
            // 
            // Regis_confpass
            // 
            this.Regis_confpass.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regis_confpass.Location = new System.Drawing.Point(349, 317);
            this.Regis_confpass.Name = "Regis_confpass";
            this.Regis_confpass.PasswordChar = '*';
            this.Regis_confpass.Size = new System.Drawing.Size(355, 22);
            this.Regis_confpass.TabIndex = 17;
            this.Regis_confpass.TextChanged += new System.EventHandler(this.Regis_confpass_TextChanged);
            // 
            // Register_confpass
            // 
            this.Register_confpass.AutoSize = true;
            this.Register_confpass.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_confpass.Location = new System.Drawing.Point(356, 285);
            this.Register_confpass.Name = "Register_confpass";
            this.Register_confpass.Size = new System.Drawing.Size(123, 20);
            this.Register_confpass.TabIndex = 16;
            this.Register_confpass.Text = "Confirm Password";
            this.Register_confpass.Click += new System.EventHandler(this.label7_Click);
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(714, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(18, 18);
            this.Close.TabIndex = 18;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Registerapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 477);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Regis_confpass);
            this.Controls.Add(this.Register_confpass);
            this.Controls.Add(this.Register_showpassword);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Reg_password);
            this.Controls.Add(this.Register_password);
            this.Controls.Add(this.Register_username);
            this.Controls.Add(this.Register_usarename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registerapp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registerapp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Register_registerbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox Register_showpassword;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.TextBox Reg_password;
        private System.Windows.Forms.Label Register_password;
        private System.Windows.Forms.TextBox Register_username;
        private System.Windows.Forms.Label Register_usarename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Regis_confpass;
        private System.Windows.Forms.Label Register_confpass;
        private System.Windows.Forms.Label Close;
    }
}