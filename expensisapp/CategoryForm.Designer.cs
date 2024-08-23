namespace expensisapp
{
    partial class CategoryForm
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
            this.category_DeleteBtn = new System.Windows.Forms.Button();
            this.category_ClearBtn = new System.Windows.Forms.Button();
            this.category_UpdateBtn = new System.Windows.Forms.Button();
            this.category_addBtn = new System.Windows.Forms.Button();
            this.category_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.category_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.category_category = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.category_DeleteBtn);
            this.panel1.Controls.Add(this.category_ClearBtn);
            this.panel1.Controls.Add(this.category_UpdateBtn);
            this.panel1.Controls.Add(this.category_addBtn);
            this.panel1.Controls.Add(this.category_status);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.category_type);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.category_category);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 568);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // category_DeleteBtn
            // 
            this.category_DeleteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.category_DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category_DeleteBtn.FlatAppearance.BorderSize = 0;
            this.category_DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_DeleteBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_DeleteBtn.Location = new System.Drawing.Point(121, 413);
            this.category_DeleteBtn.Name = "category_DeleteBtn";
            this.category_DeleteBtn.Size = new System.Drawing.Size(75, 28);
            this.category_DeleteBtn.TabIndex = 6;
            this.category_DeleteBtn.Text = "Delete";
            this.category_DeleteBtn.UseVisualStyleBackColor = false;
            this.category_DeleteBtn.Click += new System.EventHandler(this.category_DeleteBtn_Click);
            // 
            // category_ClearBtn
            // 
            this.category_ClearBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.category_ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category_ClearBtn.FlatAppearance.BorderSize = 0;
            this.category_ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_ClearBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_ClearBtn.Location = new System.Drawing.Point(28, 413);
            this.category_ClearBtn.Name = "category_ClearBtn";
            this.category_ClearBtn.Size = new System.Drawing.Size(75, 28);
            this.category_ClearBtn.TabIndex = 5;
            this.category_ClearBtn.Text = "Clear";
            this.category_ClearBtn.UseVisualStyleBackColor = false;
            this.category_ClearBtn.Click += new System.EventHandler(this.category_ClearBtn_Click);
            // 
            // category_UpdateBtn
            // 
            this.category_UpdateBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.category_UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category_UpdateBtn.FlatAppearance.BorderSize = 0;
            this.category_UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_UpdateBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_UpdateBtn.Location = new System.Drawing.Point(121, 349);
            this.category_UpdateBtn.Name = "category_UpdateBtn";
            this.category_UpdateBtn.Size = new System.Drawing.Size(75, 28);
            this.category_UpdateBtn.TabIndex = 4;
            this.category_UpdateBtn.Text = "Update";
            this.category_UpdateBtn.UseVisualStyleBackColor = false;
            this.category_UpdateBtn.Click += new System.EventHandler(this.category_UpdateBtn_Click);
            // 
            // category_addBtn
            // 
            this.category_addBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.category_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category_addBtn.FlatAppearance.BorderSize = 0;
            this.category_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_addBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_addBtn.Location = new System.Drawing.Point(28, 349);
            this.category_addBtn.Name = "category_addBtn";
            this.category_addBtn.Size = new System.Drawing.Size(75, 28);
            this.category_addBtn.TabIndex = 0;
            this.category_addBtn.Text = "Add";
            this.category_addBtn.UseVisualStyleBackColor = false;
            this.category_addBtn.Click += new System.EventHandler(this.category_addBtn_Click);
            // 
            // category_status
            // 
            this.category_status.FormattingEnabled = true;
            this.category_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.category_status.Location = new System.Drawing.Point(28, 292);
            this.category_status.Name = "category_status";
            this.category_status.Size = new System.Drawing.Size(168, 21);
            this.category_status.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status";
            // 
            // category_type
            // 
            this.category_type.FormattingEnabled = true;
            this.category_type.Items.AddRange(new object[] {
            "Income",
            "Expenses"});
            this.category_type.Location = new System.Drawing.Point(28, 202);
            this.category_type.Name = "category_type";
            this.category_type.Size = new System.Drawing.Size(168, 21);
            this.category_type.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // category_category
            // 
            this.category_category.Location = new System.Drawing.Point(28, 101);
            this.category_category.Name = "category_category";
            this.category_category.Size = new System.Drawing.Size(168, 20);
            this.category_category.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(266, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 568);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Categies List";
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(706, 506);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CategoryForm";
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox category_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox category_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox category_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button category_UpdateBtn;
        private System.Windows.Forms.Button category_addBtn;
        private System.Windows.Forms.Button category_DeleteBtn;
        private System.Windows.Forms.Button category_ClearBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
