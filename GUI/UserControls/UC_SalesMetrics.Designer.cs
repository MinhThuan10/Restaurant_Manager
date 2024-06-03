namespace RestaurantManager.GUI.UserControls
{
    partial class UC_SalesMetrics
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
            this.ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.AddEmployeeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TotalTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // ComboBox1
            // 
            this.ComboBox1.AutoRoundedCorners = true;
            this.ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox1.BorderRadius = 17;
            this.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox1.ItemHeight = 30;
            this.ComboBox1.Items.AddRange(new object[] {
            "Doanh Thu",
            "Chi Phí"});
            this.ComboBox1.Location = new System.Drawing.Point(226, 209);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(392, 36);
            this.ComboBox1.TabIndex = 0;
            // 
            // ComboBox2
            // 
            this.ComboBox2.AutoRoundedCorners = true;
            this.ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox2.BorderRadius = 17;
            this.ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox2.ItemHeight = 30;
            this.ComboBox2.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Năm"});
            this.ComboBox2.Location = new System.Drawing.Point(226, 268);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(392, 36);
            this.ComboBox2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(418, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "DOANH THU VÀ CHI PHÍ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Theo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(863, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng tiền";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.AutoRoundedCorners = true;
            this.DateTimePicker.BorderRadius = 17;
            this.DateTimePicker.Checked = true;
            this.DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker.Location = new System.Drawing.Point(226, 327);
            this.DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(392, 36);
            this.DateTimePicker.TabIndex = 8;
            this.DateTimePicker.Value = new System.DateTime(2023, 11, 21, 13, 34, 5, 181);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chọn ngày";
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.AutoRoundedCorners = true;
            this.AddEmployeeBtn.BorderRadius = 19;
            this.AddEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployeeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddEmployeeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddEmployeeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddEmployeeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddEmployeeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.AddEmployeeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.AddEmployeeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.AddEmployeeBtn.Location = new System.Drawing.Point(465, 400);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(153, 41);
            this.AddEmployeeBtn.TabIndex = 22;
            this.AddEmployeeBtn.Text = "Xem";
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // TotalTextbox
            // 
            this.TotalTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TotalTextbox.DefaultText = "0";
            this.TotalTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TotalTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TotalTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TotalTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TotalTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TotalTextbox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TotalTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TotalTextbox.Location = new System.Drawing.Point(790, 236);
            this.TotalTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TotalTextbox.Name = "TotalTextbox";
            this.TotalTextbox.PasswordChar = '\0';
            this.TotalTextbox.PlaceholderText = "";
            this.TotalTextbox.ReadOnly = true;
            this.TotalTextbox.SelectedText = "";
            this.TotalTextbox.Size = new System.Drawing.Size(244, 68);
            this.TotalTextbox.TabIndex = 23;
            // 
            // UC_SalesMetrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TotalTextbox);
            this.Controls.Add(this.AddEmployeeBtn);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.ComboBox1);
            this.Name = "UC_SalesMetrics";
            this.Size = new System.Drawing.Size(1147, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox ComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button AddEmployeeBtn;
        private Guna.UI2.WinForms.Guna2TextBox TotalTextbox;
    }
}
