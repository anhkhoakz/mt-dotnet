namespace PI_Store
{
    partial class AdminAddProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DataUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdminAddProduct_StatusComboBox = new System.Windows.Forms.ComboBox();
            this.AdminAddProduct_TypeComboBox = new System.Windows.Forms.ComboBox();
            this.AdminAddProduct_ClearButton = new System.Windows.Forms.Button();
            this.AdminAddProduct_DeleteButton = new System.Windows.Forms.Button();
            this.AdminAddProduct_UpdateButton = new System.Windows.Forms.Button();
            this.AdminAddProduct_AddButton = new System.Windows.Forms.Button();
            this.AdminAddProduct_ImportButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminAddProductImageView = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminAddProduct_PriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AdminAddProduct_StockTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AdminAddProduct_NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminAddProduct_IDTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataUsersDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAddProductImageView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DataUsersDataGridView);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 711);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data of Product";
            // 
            // DataUsersDataGridView
            // 
            this.DataUsersDataGridView.AllowUserToAddRows = false;
            this.DataUsersDataGridView.AllowUserToDeleteRows = false;
            this.DataUsersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataUsersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataUsersDataGridView.EnableHeadersVisualStyles = false;
            this.DataUsersDataGridView.Location = new System.Drawing.Point(3, 47);
            this.DataUsersDataGridView.Name = "DataUsersDataGridView";
            this.DataUsersDataGridView.ReadOnly = true;
            this.DataUsersDataGridView.RowHeadersVisible = false;
            this.DataUsersDataGridView.Size = new System.Drawing.Size(822, 400);
            this.DataUsersDataGridView.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.AdminAddProduct_StatusComboBox);
            this.panel2.Controls.Add(this.AdminAddProduct_TypeComboBox);
            this.panel2.Controls.Add(this.AdminAddProduct_ClearButton);
            this.panel2.Controls.Add(this.AdminAddProduct_DeleteButton);
            this.panel2.Controls.Add(this.AdminAddProduct_UpdateButton);
            this.panel2.Controls.Add(this.AdminAddProduct_AddButton);
            this.panel2.Controls.Add(this.AdminAddProduct_ImportButton);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.AdminAddProduct_PriceTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.AdminAddProduct_StockTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.AdminAddProduct_NameTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.AdminAddProduct_IDTextBox);
            this.panel2.Controls.Add(this.IDLabel);
            this.panel2.Location = new System.Drawing.Point(3, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 249);
            this.panel2.TabIndex = 1;
            // 
            // AdminAddProduct_StatusComboBox
            // 
            this.AdminAddProduct_StatusComboBox.FormattingEnabled = true;
            this.AdminAddProduct_StatusComboBox.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.AdminAddProduct_StatusComboBox.Location = new System.Drawing.Point(383, 98);
            this.AdminAddProduct_StatusComboBox.Name = "AdminAddProduct_StatusComboBox";
            this.AdminAddProduct_StatusComboBox.Size = new System.Drawing.Size(100, 21);
            this.AdminAddProduct_StatusComboBox.TabIndex = 24;
            // 
            // AdminAddProduct_TypeComboBox
            // 
            this.AdminAddProduct_TypeComboBox.FormattingEnabled = true;
            this.AdminAddProduct_TypeComboBox.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.AdminAddProduct_TypeComboBox.Location = new System.Drawing.Point(80, 94);
            this.AdminAddProduct_TypeComboBox.Name = "AdminAddProduct_TypeComboBox";
            this.AdminAddProduct_TypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.AdminAddProduct_TypeComboBox.TabIndex = 23;
            // 
            // AdminAddProduct_ClearButton
            // 
            this.AdminAddProduct_ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(87)))));
            this.AdminAddProduct_ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminAddProduct_ClearButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddProduct_ClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.AdminAddProduct_ClearButton.Location = new System.Drawing.Point(368, 166);
            this.AdminAddProduct_ClearButton.Name = "AdminAddProduct_ClearButton";
            this.AdminAddProduct_ClearButton.Size = new System.Drawing.Size(85, 30);
            this.AdminAddProduct_ClearButton.TabIndex = 22;
            this.AdminAddProduct_ClearButton.Text = "Clear";
            this.AdminAddProduct_ClearButton.UseVisualStyleBackColor = false;
            // 
            // AdminAddProduct_DeleteButton
            // 
            this.AdminAddProduct_DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(87)))));
            this.AdminAddProduct_DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminAddProduct_DeleteButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddProduct_DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.AdminAddProduct_DeleteButton.Location = new System.Drawing.Point(277, 166);
            this.AdminAddProduct_DeleteButton.Name = "AdminAddProduct_DeleteButton";
            this.AdminAddProduct_DeleteButton.Size = new System.Drawing.Size(85, 30);
            this.AdminAddProduct_DeleteButton.TabIndex = 21;
            this.AdminAddProduct_DeleteButton.Text = "Delete";
            this.AdminAddProduct_DeleteButton.UseVisualStyleBackColor = false;
            // 
            // AdminAddProduct_UpdateButton
            // 
            this.AdminAddProduct_UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(87)))));
            this.AdminAddProduct_UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminAddProduct_UpdateButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddProduct_UpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.AdminAddProduct_UpdateButton.Location = new System.Drawing.Point(186, 166);
            this.AdminAddProduct_UpdateButton.Name = "AdminAddProduct_UpdateButton";
            this.AdminAddProduct_UpdateButton.Size = new System.Drawing.Size(85, 30);
            this.AdminAddProduct_UpdateButton.TabIndex = 20;
            this.AdminAddProduct_UpdateButton.Text = "Update";
            this.AdminAddProduct_UpdateButton.UseVisualStyleBackColor = false;
            // 
            // AdminAddProduct_AddButton
            // 
            this.AdminAddProduct_AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(87)))));
            this.AdminAddProduct_AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminAddProduct_AddButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddProduct_AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.AdminAddProduct_AddButton.Location = new System.Drawing.Point(95, 166);
            this.AdminAddProduct_AddButton.Name = "AdminAddProduct_AddButton";
            this.AdminAddProduct_AddButton.Size = new System.Drawing.Size(85, 30);
            this.AdminAddProduct_AddButton.TabIndex = 19;
            this.AdminAddProduct_AddButton.Text = "Add";
            this.AdminAddProduct_AddButton.UseVisualStyleBackColor = false;
            this.AdminAddProduct_AddButton.Click += new System.EventHandler(this.AdminAddProduct_AddButton_Click);
            // 
            // AdminAddProduct_ImportButton
            // 
            this.AdminAddProduct_ImportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(87)))));
            this.AdminAddProduct_ImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminAddProduct_ImportButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddProduct_ImportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.AdminAddProduct_ImportButton.Location = new System.Drawing.Point(710, 166);
            this.AdminAddProduct_ImportButton.Name = "AdminAddProduct_ImportButton";
            this.AdminAddProduct_ImportButton.Size = new System.Drawing.Size(80, 30);
            this.AdminAddProduct_ImportButton.TabIndex = 13;
            this.AdminAddProduct_ImportButton.Text = "Import";
            this.AdminAddProduct_ImportButton.UseVisualStyleBackColor = false;
            this.AdminAddProduct_ImportButton.Click += new System.EventHandler(this.AdminAddProduct_ImportButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminAddProductImageView);
            this.panel3.Location = new System.Drawing.Point(710, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 100);
            this.panel3.TabIndex = 18;
            // 
            // adminAddProductImageView
            // 
            this.adminAddProductImageView.Location = new System.Drawing.Point(0, 0);
            this.adminAddProductImageView.Name = "adminAddProductImageView";
            this.adminAddProductImageView.Size = new System.Drawing.Size(80, 100);
            this.adminAddProductImageView.TabIndex = 19;
            this.adminAddProductImageView.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Status";
            // 
            // AdminAddProduct_PriceTextBox
            // 
            this.AdminAddProduct_PriceTextBox.Location = new System.Drawing.Point(383, 70);
            this.AdminAddProduct_PriceTextBox.Name = "AdminAddProduct_PriceTextBox";
            this.AdminAddProduct_PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdminAddProduct_PriceTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(323, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Price";
            // 
            // AdminAddProduct_StockTextBox
            // 
            this.AdminAddProduct_StockTextBox.Location = new System.Drawing.Point(383, 44);
            this.AdminAddProduct_StockTextBox.Name = "AdminAddProduct_StockTextBox";
            this.AdminAddProduct_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdminAddProduct_StockTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type";
            // 
            // AdminAddProduct_NameTextBox
            // 
            this.AdminAddProduct_NameTextBox.Location = new System.Drawing.Point(80, 68);
            this.AdminAddProduct_NameTextBox.Name = "AdminAddProduct_NameTextBox";
            this.AdminAddProduct_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdminAddProduct_NameTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // AdminAddProduct_IDTextBox
            // 
            this.AdminAddProduct_IDTextBox.Location = new System.Drawing.Point(80, 42);
            this.AdminAddProduct_IDTextBox.Name = "AdminAddProduct_IDTextBox";
            this.AdminAddProduct_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdminAddProduct_IDTextBox.TabIndex = 7;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(47, 44);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(27, 19);
            this.IDLabel.TabIndex = 6;
            this.IDLabel.Text = "ID";
            // 
            // AdminAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddProduct";
            this.Size = new System.Drawing.Size(834, 711);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataUsersDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminAddProductImageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DataUsersDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdminAddProduct_PriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AdminAddProduct_StockTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdminAddProduct_NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdminAddProduct_IDTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AdminAddProduct_ImportButton;
        private System.Windows.Forms.PictureBox adminAddProductImageView;
        private System.Windows.Forms.Button AdminAddProduct_ClearButton;
        private System.Windows.Forms.Button AdminAddProduct_DeleteButton;
        private System.Windows.Forms.Button AdminAddProduct_UpdateButton;
        private System.Windows.Forms.Button AdminAddProduct_AddButton;
        private System.Windows.Forms.ComboBox AdminAddProduct_TypeComboBox;
        private System.Windows.Forms.ComboBox AdminAddProduct_StatusComboBox;
    }
}
