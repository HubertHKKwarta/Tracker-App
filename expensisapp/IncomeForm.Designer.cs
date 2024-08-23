namespace expensisapp
{
    partial class IncomeForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Income_deletebtn = new System.Windows.Forms.Button();
            this.Income_clearbtn = new System.Windows.Forms.Button();
            this.Income_updatebtn = new System.Windows.Forms.Button();
            this.Income_addBtn = new System.Windows.Forms.Button();
            this.Income_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Income_description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Income_income = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Income_item = new System.Windows.Forms.TextBox();
            this.Income_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 568);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Income List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Income_deletebtn);
            this.panel2.Controls.Add(this.Income_clearbtn);
            this.panel2.Controls.Add(this.Income_updatebtn);
            this.panel2.Controls.Add(this.Income_addBtn);
            this.panel2.Controls.Add(this.Income_date);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Income_description);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Income_income);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Income_item);
            this.panel2.Controls.Add(this.Income_category);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 247);
            this.panel2.TabIndex = 1;
            // 
            // Income_deletebtn
            // 
            this.Income_deletebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Income_deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Income_deletebtn.FlatAppearance.BorderSize = 0;
            this.Income_deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Income_deletebtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_deletebtn.Location = new System.Drawing.Point(587, 187);
            this.Income_deletebtn.Name = "Income_deletebtn";
            this.Income_deletebtn.Size = new System.Drawing.Size(75, 28);
            this.Income_deletebtn.TabIndex = 14;
            this.Income_deletebtn.Text = "Delete";
            this.Income_deletebtn.UseVisualStyleBackColor = false;
            this.Income_deletebtn.Click += new System.EventHandler(this.Income_deletebtn_Click);
            // 
            // Income_clearbtn
            // 
            this.Income_clearbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Income_clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Income_clearbtn.FlatAppearance.BorderSize = 0;
            this.Income_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Income_clearbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_clearbtn.Location = new System.Drawing.Point(470, 187);
            this.Income_clearbtn.Name = "Income_clearbtn";
            this.Income_clearbtn.Size = new System.Drawing.Size(75, 28);
            this.Income_clearbtn.TabIndex = 13;
            this.Income_clearbtn.Text = "Clear";
            this.Income_clearbtn.UseVisualStyleBackColor = false;
            this.Income_clearbtn.Click += new System.EventHandler(this.Income_clearbtn_Click);
            // 
            // Income_updatebtn
            // 
            this.Income_updatebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Income_updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Income_updatebtn.FlatAppearance.BorderSize = 0;
            this.Income_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Income_updatebtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_updatebtn.Location = new System.Drawing.Point(342, 187);
            this.Income_updatebtn.Name = "Income_updatebtn";
            this.Income_updatebtn.Size = new System.Drawing.Size(75, 28);
            this.Income_updatebtn.TabIndex = 12;
            this.Income_updatebtn.Text = "Update";
            this.Income_updatebtn.UseVisualStyleBackColor = false;
            this.Income_updatebtn.Click += new System.EventHandler(this.Income_updatebtn_Click);
            // 
            // Income_addBtn
            // 
            this.Income_addBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Income_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Income_addBtn.FlatAppearance.BorderSize = 0;
            this.Income_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Income_addBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_addBtn.Location = new System.Drawing.Point(225, 187);
            this.Income_addBtn.Name = "Income_addBtn";
            this.Income_addBtn.Size = new System.Drawing.Size(75, 28);
            this.Income_addBtn.TabIndex = 11;
            this.Income_addBtn.Text = "Add";
            this.Income_addBtn.UseVisualStyleBackColor = false;
            this.Income_addBtn.Click += new System.EventHandler(this.Income_addBtn_Click);
            // 
            // Income_date
            // 
            this.Income_date.Location = new System.Drawing.Point(534, 124);
            this.Income_date.Name = "Income_date";
            this.Income_date.Size = new System.Drawing.Size(196, 20);
            this.Income_date.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description:";
            // 
            // Income_description
            // 
            this.Income_description.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_description.Location = new System.Drawing.Point(534, 18);
            this.Income_description.Multiline = true;
            this.Income_description.Name = "Income_description";
            this.Income_description.Size = new System.Drawing.Size(416, 96);
            this.Income_description.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Income:";
            // 
            // Income_income
            // 
            this.Income_income.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_income.Location = new System.Drawing.Point(93, 106);
            this.Income_income.Name = "Income_income";
            this.Income_income.Size = new System.Drawing.Size(185, 26);
            this.Income_income.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item:";
            // 
            // Income_item
            // 
            this.Income_item.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_item.Location = new System.Drawing.Point(93, 74);
            this.Income_item.Name = "Income_item";
            this.Income_item.Size = new System.Drawing.Size(185, 26);
            this.Income_item.TabIndex = 3;
            // 
            // Income_category
            // 
            this.Income_category.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_category.FormattingEnabled = true;
            this.Income_category.Location = new System.Drawing.Point(93, 33);
            this.Income_category.Name = "Income_category";
            this.Income_category.Size = new System.Drawing.Size(185, 28);
            this.Income_category.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(37, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(940, 230);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IncomeForm";
            this.Size = new System.Drawing.Size(997, 597);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Income_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Income_income;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Income_item;
        private System.Windows.Forms.ComboBox Income_category;
        private System.Windows.Forms.DateTimePicker Income_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Income_updatebtn;
        private System.Windows.Forms.Button Income_addBtn;
        private System.Windows.Forms.Button Income_deletebtn;
        private System.Windows.Forms.Button Income_clearbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
