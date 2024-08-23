namespace expensisapp
{
    partial class ExpensesForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Expenses_deletebtn = new System.Windows.Forms.Button();
            this.Expenses_clearbtn = new System.Windows.Forms.Button();
            this.Expenses_updatebtn = new System.Windows.Forms.Button();
            this.Expenses_addBtn = new System.Windows.Forms.Button();
            this.Expenses_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Expenses_description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Expenses_cost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Expenses_item = new System.Windows.Forms.TextBox();
            this.Expenses_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(37, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(926, 230);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
//            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Expenses_deletebtn
            // 
            this.Expenses_deletebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Expenses_deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Expenses_deletebtn.FlatAppearance.BorderSize = 0;
            this.Expenses_deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expenses_deletebtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses_deletebtn.Location = new System.Drawing.Point(587, 187);
            this.Expenses_deletebtn.Name = "Expenses_deletebtn";
            this.Expenses_deletebtn.Size = new System.Drawing.Size(75, 28);
            this.Expenses_deletebtn.TabIndex = 14;
            this.Expenses_deletebtn.Text = "Delete";
            this.Expenses_deletebtn.UseVisualStyleBackColor = false;
            this.Expenses_deletebtn.Click += new System.EventHandler(this.Expenses_deletebtn_Click);
            // 
            // Expenses_clearbtn
            // 
            this.Expenses_clearbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Expenses_clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Expenses_clearbtn.FlatAppearance.BorderSize = 0;
            this.Expenses_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expenses_clearbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses_clearbtn.Location = new System.Drawing.Point(470, 187);
            this.Expenses_clearbtn.Name = "Expenses_clearbtn";
            this.Expenses_clearbtn.Size = new System.Drawing.Size(75, 28);
            this.Expenses_clearbtn.TabIndex = 13;
            this.Expenses_clearbtn.Text = "Clear";
            this.Expenses_clearbtn.UseVisualStyleBackColor = false;
            this.Expenses_clearbtn.Click += new System.EventHandler(this.Expenses_clearbtn_Click);
            // 
            // Expenses_updatebtn
            // 
            this.Expenses_updatebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Expenses_updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Expenses_updatebtn.FlatAppearance.BorderSize = 0;
            this.Expenses_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expenses_updatebtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses_updatebtn.Location = new System.Drawing.Point(342, 187);
            this.Expenses_updatebtn.Name = "Expenses_updatebtn";
            this.Expenses_updatebtn.Size = new System.Drawing.Size(75, 28);
            this.Expenses_updatebtn.TabIndex = 12;
            this.Expenses_updatebtn.Text = "Update";
            this.Expenses_updatebtn.UseVisualStyleBackColor = false;
            this.Expenses_updatebtn.Click += new System.EventHandler(this.Expenses_updatebtn_Click);
            // 
            // Expenses_addBtn
            // 
            this.Expenses_addBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Expenses_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Expenses_addBtn.FlatAppearance.BorderSize = 0;
            this.Expenses_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expenses_addBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses_addBtn.Location = new System.Drawing.Point(225, 187);
            this.Expenses_addBtn.Name = "Expenses_addBtn";
            this.Expenses_addBtn.Size = new System.Drawing.Size(75, 28);
            this.Expenses_addBtn.TabIndex = 11;
            this.Expenses_addBtn.Text = "Add";
            this.Expenses_addBtn.UseVisualStyleBackColor = false;
            this.Expenses_addBtn.Click += new System.EventHandler(this.Expenses_addBtn_Click);
            // 
            // Expenses_date
            // 
            this.Expenses_date.Location = new System.Drawing.Point(534, 124);
            this.Expenses_date.Name = "Expenses_date";
            this.Expenses_date.Size = new System.Drawing.Size(196, 20);
            this.Expenses_date.TabIndex = 10;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 308);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expenses List";
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
            // Expenses_description
            // 
            this.Expenses_description.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses_description.Location = new System.Drawing.Point(534, 18);
            this.Expenses_description.Multiline = true;
            this.Expenses_description.Name = "Expenses_description";
            this.Expenses_description.Size = new System.Drawing.Size(416, 96);
            this.Expenses_description.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cost:";
            // 
            // Expenses_cost
            // 
            this.Expenses_cost.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses_cost.Location = new System.Drawing.Point(93, 106);
            this.Expenses_cost.Name = "Expenses_cost";
            this.Expenses_cost.Size = new System.Drawing.Size(185, 26);
            this.Expenses_cost.TabIndex = 5;
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
            // Expenses_item
            // 
            this.Expenses_item.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses_item.Location = new System.Drawing.Point(93, 74);
            this.Expenses_item.Name = "Expenses_item";
            this.Expenses_item.Size = new System.Drawing.Size(185, 26);
            this.Expenses_item.TabIndex = 3;
            // 
            // Expenses_category
            // 
            this.Expenses_category.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses_category.FormattingEnabled = true;
            this.Expenses_category.Location = new System.Drawing.Point(93, 33);
            this.Expenses_category.Name = "Expenses_category";
            this.Expenses_category.Size = new System.Drawing.Size(185, 28);
            this.Expenses_category.TabIndex = 2;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Expenses_deletebtn);
            this.panel2.Controls.Add(this.Expenses_clearbtn);
            this.panel2.Controls.Add(this.Expenses_updatebtn);
            this.panel2.Controls.Add(this.Expenses_addBtn);
            this.panel2.Controls.Add(this.Expenses_date);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Expenses_description);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Expenses_cost);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Expenses_item);
            this.panel2.Controls.Add(this.Expenses_category);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 247);
            this.panel2.TabIndex = 4;
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ExpensesForm";
            this.Size = new System.Drawing.Size(997, 597);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Expenses_deletebtn;
        private System.Windows.Forms.Button Expenses_clearbtn;
        private System.Windows.Forms.Button Expenses_updatebtn;
        private System.Windows.Forms.Button Expenses_addBtn;
        private System.Windows.Forms.DateTimePicker Expenses_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Expenses_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Expenses_cost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Expenses_item;
        private System.Windows.Forms.ComboBox Expenses_category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}
