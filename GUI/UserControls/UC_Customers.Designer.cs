namespace RestaurantManager.GUI.UserControls
{
    partial class UC_Customers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InsertCustomerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PhoneNumberTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchCustomerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateCustomerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteCustomerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CustomersDG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDG)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertCustomerBtn
            // 
            this.InsertCustomerBtn.AutoRoundedCorners = true;
            this.InsertCustomerBtn.BorderRadius = 21;
            this.InsertCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertCustomerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.InsertCustomerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.InsertCustomerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.InsertCustomerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.InsertCustomerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.InsertCustomerBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.InsertCustomerBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.InsertCustomerBtn.Location = new System.Drawing.Point(914, 127);
            this.InsertCustomerBtn.Name = "InsertCustomerBtn";
            this.InsertCustomerBtn.Size = new System.Drawing.Size(182, 45);
            this.InsertCustomerBtn.TabIndex = 15;
            this.InsertCustomerBtn.Text = "Thêm KH";
            this.InsertCustomerBtn.Click += new System.EventHandler(this.InsertCustomerBtn_Click);
            // 
            // PhoneNumberTextbox
            // 
            this.PhoneNumberTextbox.AutoRoundedCorners = true;
            this.PhoneNumberTextbox.BorderRadius = 21;
            this.PhoneNumberTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNumberTextbox.DefaultText = "";
            this.PhoneNumberTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneNumberTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneNumberTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumberTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumberTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneNumberTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PhoneNumberTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneNumberTextbox.Location = new System.Drawing.Point(30, 65);
            this.PhoneNumberTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            this.PhoneNumberTextbox.PasswordChar = '\0';
            this.PhoneNumberTextbox.PlaceholderText = "Tìm khách hàng theo số điện thoại";
            this.PhoneNumberTextbox.SelectedText = "";
            this.PhoneNumberTextbox.Size = new System.Drawing.Size(678, 44);
            this.PhoneNumberTextbox.TabIndex = 16;
            // 
            // SearchCustomerBtn
            // 
            this.SearchCustomerBtn.AutoRoundedCorners = true;
            this.SearchCustomerBtn.BorderRadius = 19;
            this.SearchCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchCustomerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchCustomerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchCustomerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchCustomerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchCustomerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.SearchCustomerBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.SearchCustomerBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.SearchCustomerBtn.Location = new System.Drawing.Point(714, 65);
            this.SearchCustomerBtn.Name = "SearchCustomerBtn";
            this.SearchCustomerBtn.Size = new System.Drawing.Size(134, 41);
            this.SearchCustomerBtn.TabIndex = 15;
            this.SearchCustomerBtn.Text = "Tìm";
            this.SearchCustomerBtn.Click += new System.EventHandler(this.SearchCustomerBtn_Click);
            // 
            // UpdateCustomerBtn
            // 
            this.UpdateCustomerBtn.AutoRoundedCorners = true;
            this.UpdateCustomerBtn.BorderRadius = 21;
            this.UpdateCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateCustomerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateCustomerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateCustomerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateCustomerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateCustomerBtn.Enabled = false;
            this.UpdateCustomerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.UpdateCustomerBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateCustomerBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.UpdateCustomerBtn.Location = new System.Drawing.Point(914, 191);
            this.UpdateCustomerBtn.Name = "UpdateCustomerBtn";
            this.UpdateCustomerBtn.Size = new System.Drawing.Size(182, 45);
            this.UpdateCustomerBtn.TabIndex = 15;
            this.UpdateCustomerBtn.Text = "Sửa KH";
            this.UpdateCustomerBtn.Click += new System.EventHandler(this.UpdateCustomerBtn_Click);
            // 
            // DeleteCustomerBtn
            // 
            this.DeleteCustomerBtn.AutoRoundedCorners = true;
            this.DeleteCustomerBtn.BorderRadius = 21;
            this.DeleteCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteCustomerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteCustomerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteCustomerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteCustomerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteCustomerBtn.Enabled = false;
            this.DeleteCustomerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DeleteCustomerBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteCustomerBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.DeleteCustomerBtn.Location = new System.Drawing.Point(914, 255);
            this.DeleteCustomerBtn.Name = "DeleteCustomerBtn";
            this.DeleteCustomerBtn.Size = new System.Drawing.Size(182, 45);
            this.DeleteCustomerBtn.TabIndex = 15;
            this.DeleteCustomerBtn.Text = "Xoá KH";
            this.DeleteCustomerBtn.Click += new System.EventHandler(this.DeleteCustomerBtn_Click);
            // 
            // CustomersDG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CustomersDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomersDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomersDG.ColumnHeadersHeight = 20;
            this.CustomersDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomersDG.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomersDG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CustomersDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomersDG.Location = new System.Drawing.Point(30, 116);
            this.CustomersDG.Name = "CustomersDG";
            this.CustomersDG.RowHeadersVisible = false;
            this.CustomersDG.RowHeadersWidth = 51;
            this.CustomersDG.RowTemplate.Height = 24;
            this.CustomersDG.Size = new System.Drawing.Size(818, 411);
            this.CustomersDG.TabIndex = 22;
            this.CustomersDG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomersDG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomersDG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomersDG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomersDG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomersDG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomersDG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomersDG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CustomersDG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomersDG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersDG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomersDG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomersDG.ThemeStyle.HeaderStyle.Height = 20;
            this.CustomersDG.ThemeStyle.ReadOnly = false;
            this.CustomersDG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomersDG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomersDG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersDG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomersDG.ThemeStyle.RowsStyle.Height = 24;
            this.CustomersDG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomersDG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomersDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersDG_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(513, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 33);
            this.label5.TabIndex = 24;
            this.label5.Text = "KHÁCH HÀNG";
            // 
            // UC_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomersDG);
            this.Controls.Add(this.PhoneNumberTextbox);
            this.Controls.Add(this.SearchCustomerBtn);
            this.Controls.Add(this.DeleteCustomerBtn);
            this.Controls.Add(this.UpdateCustomerBtn);
            this.Controls.Add(this.InsertCustomerBtn);
            this.Name = "UC_Customers";
            this.Size = new System.Drawing.Size(1147, 560);
            this.Load += new System.EventHandler(this.UC_Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button InsertCustomerBtn;
        private Guna.UI2.WinForms.Guna2TextBox PhoneNumberTextbox;
        private Guna.UI2.WinForms.Guna2Button SearchCustomerBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateCustomerBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteCustomerBtn;
        private Guna.UI2.WinForms.Guna2DataGridView CustomersDG;
        private System.Windows.Forms.Label label5;
    }
}
