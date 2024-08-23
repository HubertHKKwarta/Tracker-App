namespace expensisapp
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.expenses_btn = new System.Windows.Forms.Button();
            this.income_btn = new System.Windows.Forms.Button();
            this.addcategory_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.usernametext = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dddd1 = new expensisapp.DDDD();
            this.expensesForm1 = new expensisapp.ExpensesForm();
            this.incomeForm1 = new expensisapp.IncomeForm();
            this.categoryForm1 = new expensisapp.CategoryForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Income and Expenses Tracker";
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(1233, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(18, 18);
            this.Close.TabIndex = 2;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Logout_btn);
            this.panel2.Controls.Add(this.expenses_btn);
            this.panel2.Controls.Add(this.income_btn);
            this.panel2.Controls.Add(this.addcategory_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.usernametext);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 625);
            this.panel2.TabIndex = 1;
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_btn.FlatAppearance.BorderSize = 0;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_btn.Location = new System.Drawing.Point(12, 573);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(200, 40);
            this.Logout_btn.TabIndex = 7;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // expenses_btn
            // 
            this.expenses_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expenses_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expenses_btn.FlatAppearance.BorderSize = 0;
            this.expenses_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenses_btn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.expenses_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenses_btn.Location = new System.Drawing.Point(12, 378);
            this.expenses_btn.Name = "expenses_btn";
            this.expenses_btn.Size = new System.Drawing.Size(200, 40);
            this.expenses_btn.TabIndex = 6;
            this.expenses_btn.Text = "Expenses";
            this.expenses_btn.UseVisualStyleBackColor = false;
            this.expenses_btn.Click += new System.EventHandler(this.expenses_btn_Click);
            // 
            // income_btn
            // 
            this.income_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.income_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_btn.FlatAppearance.BorderSize = 0;
            this.income_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_btn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.income_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.income_btn.Location = new System.Drawing.Point(12, 332);
            this.income_btn.Name = "income_btn";
            this.income_btn.Size = new System.Drawing.Size(200, 40);
            this.income_btn.TabIndex = 5;
            this.income_btn.Text = "Income";
            this.income_btn.UseVisualStyleBackColor = false;
            this.income_btn.Click += new System.EventHandler(this.income_btn_Click);
            // 
            // addcategory_btn
            // 
            this.addcategory_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addcategory_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addcategory_btn.FlatAppearance.BorderSize = 0;
            this.addcategory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcategory_btn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcategory_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addcategory_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addcategory_btn.Location = new System.Drawing.Point(12, 286);
            this.addcategory_btn.Name = "addcategory_btn";
            this.addcategory_btn.Size = new System.Drawing.Size(200, 40);
            this.addcategory_btn.TabIndex = 4;
            this.addcategory_btn.Text = "Add Category";
            this.addcategory_btn.UseVisualStyleBackColor = false;
            this.addcategory_btn.Click += new System.EventHandler(this.addcategory_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(12, 240);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(200, 40);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // usernametext
            // 
            this.usernametext.AutoSize = true;
            this.usernametext.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametext.ForeColor = System.Drawing.SystemColors.Control;
            this.usernametext.Location = new System.Drawing.Point(92, 203);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(47, 20);
            this.usernametext.TabIndex = 3;
            this.usernametext.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome, ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::expensisapp.Properties.Resources.tracker_image_preview_rev_1;
            this.pictureBox1.Location = new System.Drawing.Point(35, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 182);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dddd1);
            this.panel3.Controls.Add(this.expensesForm1);
            this.panel3.Controls.Add(this.incomeForm1);
            this.panel3.Controls.Add(this.categoryForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(233, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1030, 625);
            this.panel3.TabIndex = 2;
            // 
            // dddd1
            // 
            this.dddd1.Location = new System.Drawing.Point(0, 0);
            this.dddd1.Name = "dddd1";
            this.dddd1.Size = new System.Drawing.Size(1030, 625);
            this.dddd1.TabIndex = 3;
            // 
            // expensesForm1
            // 
            this.expensesForm1.Location = new System.Drawing.Point(0, 0);
            this.expensesForm1.Name = "expensesForm1";
            this.expensesForm1.Size = new System.Drawing.Size(983, 586);
            this.expensesForm1.TabIndex = 2;
            this.expensesForm1.Load += new System.EventHandler(this.expensesForm1_Load);
            // 
            // incomeForm1
            // 
            this.incomeForm1.Location = new System.Drawing.Point(0, 0);
            this.incomeForm1.Name = "incomeForm1";
            this.incomeForm1.Size = new System.Drawing.Size(983, 586);
            this.incomeForm1.TabIndex = 1;
            // 
            // categoryForm1
            // 
            this.categoryForm1.Location = new System.Drawing.Point(0, 0);
            this.categoryForm1.Name = "categoryForm1";
            this.categoryForm1.Size = new System.Drawing.Size(1027, 674);
            this.categoryForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 670);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label usernametext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button expenses_btn;
        private System.Windows.Forms.Button income_btn;
        private System.Windows.Forms.Button addcategory_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Panel panel3;
        private CategoryForm categoryForm1;
        private IncomeForm incomeForm1;
        private ExpensesForm expensesForm1;
        private DDDD dddd1;
    }
}