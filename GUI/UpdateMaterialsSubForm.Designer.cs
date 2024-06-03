namespace RestaurantManager.GUI
{
    partial class UpdateMaterialsSubForm
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
            this.AddMaterialBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QuantityLimitTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmployeeIDTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.QuantityTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UnitTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddMaterialBtn
            // 
            this.AddMaterialBtn.AutoRoundedCorners = true;
            this.AddMaterialBtn.BorderRadius = 26;
            this.AddMaterialBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMaterialBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddMaterialBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddMaterialBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddMaterialBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddMaterialBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.AddMaterialBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMaterialBtn.ForeColor = System.Drawing.Color.White;
            this.AddMaterialBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.AddMaterialBtn.Location = new System.Drawing.Point(494, 424);
            this.AddMaterialBtn.Name = "AddMaterialBtn";
            this.AddMaterialBtn.Size = new System.Drawing.Size(217, 54);
            this.AddMaterialBtn.TabIndex = 21;
            this.AddMaterialBtn.Text = "Cập nhật NL";
            this.AddMaterialBtn.Click += new System.EventHandler(this.AddMaterialBtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::RestaurantManager.Properties.Resources.carrots;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(138, 13);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(76, 74);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 20;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(245, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(351, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "CẬP NHẬT NGUYÊN LIỆU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(40, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "SL tồn kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(40, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mã NV quản lý";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(40, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(40, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Đơn vị tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(40, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên nguyên liệu";
            // 
            // QuantityLimitTextbox
            // 
            this.QuantityLimitTextbox.AutoRoundedCorners = true;
            this.QuantityLimitTextbox.BorderRadius = 17;
            this.QuantityLimitTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityLimitTextbox.DefaultText = "";
            this.QuantityLimitTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuantityLimitTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuantityLimitTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityLimitTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityLimitTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityLimitTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QuantityLimitTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityLimitTextbox.Location = new System.Drawing.Point(274, 362);
            this.QuantityLimitTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuantityLimitTextbox.Name = "QuantityLimitTextbox";
            this.QuantityLimitTextbox.PasswordChar = '\0';
            this.QuantityLimitTextbox.PlaceholderText = "";
            this.QuantityLimitTextbox.SelectedText = "";
            this.QuantityLimitTextbox.Size = new System.Drawing.Size(331, 37);
            this.QuantityLimitTextbox.TabIndex = 9;
            // 
            // EmployeeIDTextbox
            // 
            this.EmployeeIDTextbox.AutoRoundedCorners = true;
            this.EmployeeIDTextbox.BorderRadius = 17;
            this.EmployeeIDTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmployeeIDTextbox.DefaultText = "";
            this.EmployeeIDTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmployeeIDTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmployeeIDTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmployeeIDTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmployeeIDTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeeIDTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmployeeIDTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeeIDTextbox.Location = new System.Drawing.Point(274, 295);
            this.EmployeeIDTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeeIDTextbox.Name = "EmployeeIDTextbox";
            this.EmployeeIDTextbox.PasswordChar = '\0';
            this.EmployeeIDTextbox.PlaceholderText = "";
            this.EmployeeIDTextbox.SelectedText = "";
            this.EmployeeIDTextbox.Size = new System.Drawing.Size(331, 37);
            this.EmployeeIDTextbox.TabIndex = 10;
            // 
            // QuantityTextbox
            // 
            this.QuantityTextbox.AutoRoundedCorners = true;
            this.QuantityTextbox.BorderRadius = 17;
            this.QuantityTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityTextbox.DefaultText = "";
            this.QuantityTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuantityTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuantityTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QuantityTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTextbox.Location = new System.Drawing.Point(274, 232);
            this.QuantityTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuantityTextbox.Name = "QuantityTextbox";
            this.QuantityTextbox.PasswordChar = '\0';
            this.QuantityTextbox.PlaceholderText = "";
            this.QuantityTextbox.SelectedText = "";
            this.QuantityTextbox.Size = new System.Drawing.Size(331, 37);
            this.QuantityTextbox.TabIndex = 11;
            // 
            // UnitTextbox
            // 
            this.UnitTextbox.AutoRoundedCorners = true;
            this.UnitTextbox.BorderRadius = 17;
            this.UnitTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UnitTextbox.DefaultText = "";
            this.UnitTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UnitTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UnitTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UnitTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UnitTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UnitTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UnitTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UnitTextbox.Location = new System.Drawing.Point(274, 166);
            this.UnitTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UnitTextbox.Name = "UnitTextbox";
            this.UnitTextbox.PasswordChar = '\0';
            this.UnitTextbox.PlaceholderText = "";
            this.UnitTextbox.SelectedText = "";
            this.UnitTextbox.Size = new System.Drawing.Size(331, 37);
            this.UnitTextbox.TabIndex = 12;
            // 
            // NameTextbox
            // 
            this.NameTextbox.AutoRoundedCorners = true;
            this.NameTextbox.BorderRadius = 17;
            this.NameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextbox.DefaultText = "";
            this.NameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTextbox.Location = new System.Drawing.Point(274, 106);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.PasswordChar = '\0';
            this.NameTextbox.PlaceholderText = "";
            this.NameTextbox.SelectedText = "";
            this.NameTextbox.Size = new System.Drawing.Size(331, 37);
            this.NameTextbox.TabIndex = 13;
            // 
            // UpdateMaterialsSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 489);
            this.Controls.Add(this.AddMaterialBtn);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuantityLimitTextbox);
            this.Controls.Add(this.EmployeeIDTextbox);
            this.Controls.Add(this.QuantityTextbox);
            this.Controls.Add(this.UnitTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Name = "UpdateMaterialsSubForm";
            this.Text = "UpdateMaterialsSubForm";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button AddMaterialBtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox QuantityLimitTextbox;
        private Guna.UI2.WinForms.Guna2TextBox EmployeeIDTextbox;
        private Guna.UI2.WinForms.Guna2TextBox QuantityTextbox;
        private Guna.UI2.WinForms.Guna2TextBox UnitTextbox;
        private Guna.UI2.WinForms.Guna2TextBox NameTextbox;
    }
}