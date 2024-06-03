namespace RestaurantManager.GUI
{
    partial class UpdateCustomersSubForm
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
            this.UpdateCustomerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.GenderCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneNumberTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddressTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomerNameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.UpdateCustomerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.UpdateCustomerBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateCustomerBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.UpdateCustomerBtn.Location = new System.Drawing.Point(546, 379);
            this.UpdateCustomerBtn.Name = "UpdateCustomerBtn";
            this.UpdateCustomerBtn.Size = new System.Drawing.Size(203, 45);
            this.UpdateCustomerBtn.TabIndex = 18;
            this.UpdateCustomerBtn.Text = "Cập nhật";
            this.UpdateCustomerBtn.Click += new System.EventHandler(this.UpdateCustomerBtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::RestaurantManager.Properties.Resources.Customer;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(170, 25);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(76, 74);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 17;
            this.guna2PictureBox1.TabStop = false;
            // 
            // GenderCB
            // 
            this.GenderCB.AutoRoundedCorners = true;
            this.GenderCB.BackColor = System.Drawing.Color.Transparent;
            this.GenderCB.BorderRadius = 17;
            this.GenderCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GenderCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.GenderCB.ItemHeight = 30;
            this.GenderCB.Items.AddRange(new object[] {
            "Nữ",
            "Nam",
            "Khác"});
            this.GenderCB.Location = new System.Drawing.Point(296, 307);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(194, 36);
            this.GenderCB.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(98, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(98, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(98, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(300, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "CẬP NHẬT KHÁCH HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(98, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên khách hàng";
            // 
            // PhoneNumberTextbox
            // 
            this.PhoneNumberTextbox.AutoRoundedCorners = true;
            this.PhoneNumberTextbox.BorderRadius = 19;
            this.PhoneNumberTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNumberTextbox.DefaultText = "";
            this.PhoneNumberTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneNumberTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneNumberTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumberTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumberTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneNumberTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PhoneNumberTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneNumberTextbox.Location = new System.Drawing.Point(296, 184);
            this.PhoneNumberTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            this.PhoneNumberTextbox.PasswordChar = '\0';
            this.PhoneNumberTextbox.PlaceholderText = "";
            this.PhoneNumberTextbox.SelectedText = "";
            this.PhoneNumberTextbox.Size = new System.Drawing.Size(373, 41);
            this.PhoneNumberTextbox.TabIndex = 8;
            // 
            // AddressTextbox
            // 
            this.AddressTextbox.AutoRoundedCorners = true;
            this.AddressTextbox.BorderRadius = 19;
            this.AddressTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressTextbox.DefaultText = "";
            this.AddressTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddressTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddressTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddressTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTextbox.Location = new System.Drawing.Point(296, 246);
            this.AddressTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressTextbox.Name = "AddressTextbox";
            this.AddressTextbox.PasswordChar = '\0';
            this.AddressTextbox.PlaceholderText = "";
            this.AddressTextbox.SelectedText = "";
            this.AddressTextbox.Size = new System.Drawing.Size(373, 41);
            this.AddressTextbox.TabIndex = 9;
            // 
            // CustomerNameTextbox
            // 
            this.CustomerNameTextbox.AutoRoundedCorners = true;
            this.CustomerNameTextbox.BorderRadius = 19;
            this.CustomerNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerNameTextbox.DefaultText = "";
            this.CustomerNameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerNameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerNameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerNameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTextbox.Location = new System.Drawing.Point(296, 121);
            this.CustomerNameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerNameTextbox.Name = "CustomerNameTextbox";
            this.CustomerNameTextbox.PasswordChar = '\0';
            this.CustomerNameTextbox.PlaceholderText = "";
            this.CustomerNameTextbox.SelectedText = "";
            this.CustomerNameTextbox.Size = new System.Drawing.Size(373, 41);
            this.CustomerNameTextbox.TabIndex = 10;
            // 
            // UpdateCustomersSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateCustomerBtn);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.GenderCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneNumberTextbox);
            this.Controls.Add(this.AddressTextbox);
            this.Controls.Add(this.CustomerNameTextbox);
            this.Name = "UpdateCustomersSubForm";
            this.Text = "Cập nhật khách hàng";
            this.Load += new System.EventHandler(this.UpdateCustomersSubForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button UpdateCustomerBtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox GenderCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox PhoneNumberTextbox;
        private Guna.UI2.WinForms.Guna2TextBox AddressTextbox;
        private Guna.UI2.WinForms.Guna2TextBox CustomerNameTextbox;
    }
}