namespace RestaurantManager.GUI
{
    partial class AddEmployeesSubForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpLastNameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmpFirstNameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BirthDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.GenderCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneNumberTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddressTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.StartingDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.JobTitlesCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AddEmployeeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UsernameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(325, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "THÊM NHÂN VIÊN MỚI";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::RestaurantManager.Properties.Resources.employee;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(195, 28);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(76, 74);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(45, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên nhân viên";
            // 
            // EmpLastNameTextbox
            // 
            this.EmpLastNameTextbox.AutoRoundedCorners = true;
            this.EmpLastNameTextbox.BorderRadius = 19;
            this.EmpLastNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpLastNameTextbox.DefaultText = "";
            this.EmpLastNameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpLastNameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpLastNameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpLastNameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpLastNameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpLastNameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpLastNameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpLastNameTextbox.Location = new System.Drawing.Point(227, 122);
            this.EmpLastNameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpLastNameTextbox.Name = "EmpLastNameTextbox";
            this.EmpLastNameTextbox.PasswordChar = '\0';
            this.EmpLastNameTextbox.PlaceholderText = "Họ nhân viên";
            this.EmpLastNameTextbox.SelectedText = "";
            this.EmpLastNameTextbox.Size = new System.Drawing.Size(190, 41);
            this.EmpLastNameTextbox.TabIndex = 7;
            // 
            // EmpFirstNameTextbox
            // 
            this.EmpFirstNameTextbox.AutoRoundedCorners = true;
            this.EmpFirstNameTextbox.BorderRadius = 19;
            this.EmpFirstNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpFirstNameTextbox.DefaultText = "";
            this.EmpFirstNameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpFirstNameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpFirstNameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpFirstNameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpFirstNameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpFirstNameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpFirstNameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpFirstNameTextbox.Location = new System.Drawing.Point(423, 122);
            this.EmpFirstNameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpFirstNameTextbox.Name = "EmpFirstNameTextbox";
            this.EmpFirstNameTextbox.PasswordChar = '\0';
            this.EmpFirstNameTextbox.PlaceholderText = "Tên nhân viên";
            this.EmpFirstNameTextbox.SelectedText = "";
            this.EmpFirstNameTextbox.Size = new System.Drawing.Size(188, 41);
            this.EmpFirstNameTextbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(45, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày sinh";
            // 
            // BirthDateTimePicker
            // 
            this.BirthDateTimePicker.AutoRoundedCorners = true;
            this.BirthDateTimePicker.BorderRadius = 17;
            this.BirthDateTimePicker.Checked = true;
            this.BirthDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.BirthDateTimePicker.Location = new System.Drawing.Point(227, 175);
            this.BirthDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BirthDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BirthDateTimePicker.Name = "BirthDateTimePicker";
            this.BirthDateTimePicker.Size = new System.Drawing.Size(384, 36);
            this.BirthDateTimePicker.TabIndex = 8;
            this.BirthDateTimePicker.Value = new System.DateTime(2023, 11, 14, 10, 55, 29, 266);
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
            this.GenderCB.Location = new System.Drawing.Point(227, 223);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(190, 36);
            this.GenderCB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(45, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(46, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(46, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Số điện thoại";
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
            this.PhoneNumberTextbox.Location = new System.Drawing.Point(225, 276);
            this.PhoneNumberTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            this.PhoneNumberTextbox.PasswordChar = '\0';
            this.PhoneNumberTextbox.PlaceholderText = "";
            this.PhoneNumberTextbox.SelectedText = "";
            this.PhoneNumberTextbox.Size = new System.Drawing.Size(386, 41);
            this.PhoneNumberTextbox.TabIndex = 15;
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
            this.AddressTextbox.Location = new System.Drawing.Point(227, 331);
            this.AddressTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressTextbox.Name = "AddressTextbox";
            this.AddressTextbox.PasswordChar = '\0';
            this.AddressTextbox.PlaceholderText = "";
            this.AddressTextbox.SelectedText = "";
            this.AddressTextbox.Size = new System.Drawing.Size(382, 41);
            this.AddressTextbox.TabIndex = 15;
            // 
            // StartingDateTimePicker
            // 
            this.StartingDateTimePicker.AutoRoundedCorners = true;
            this.StartingDateTimePicker.BorderRadius = 17;
            this.StartingDateTimePicker.Checked = true;
            this.StartingDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.StartingDateTimePicker.Location = new System.Drawing.Point(227, 382);
            this.StartingDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.StartingDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.StartingDateTimePicker.Name = "StartingDateTimePicker";
            this.StartingDateTimePicker.Size = new System.Drawing.Size(384, 36);
            this.StartingDateTimePicker.TabIndex = 17;
            this.StartingDateTimePicker.Value = new System.DateTime(2023, 11, 14, 10, 55, 29, 266);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(45, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ngày tuyển dụng";
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.AutoRoundedCorners = true;
            this.guna2TextBox3.BorderRadius = 19;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "1";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(225, 431);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(386, 41);
            this.guna2TextBox3.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(46, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mã quản lý";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(44, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Công việc";
            // 
            // JobTitlesCB
            // 
            this.JobTitlesCB.AutoRoundedCorners = true;
            this.JobTitlesCB.BackColor = System.Drawing.Color.Transparent;
            this.JobTitlesCB.BorderRadius = 17;
            this.JobTitlesCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.JobTitlesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JobTitlesCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.JobTitlesCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.JobTitlesCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.JobTitlesCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.JobTitlesCB.ItemHeight = 30;
            this.JobTitlesCB.Location = new System.Drawing.Point(225, 483);
            this.JobTitlesCB.Name = "JobTitlesCB";
            this.JobTitlesCB.Size = new System.Drawing.Size(386, 36);
            this.JobTitlesCB.TabIndex = 20;
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
            this.AddEmployeeBtn.Location = new System.Drawing.Point(484, 633);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(231, 41);
            this.AddEmployeeBtn.TabIndex = 21;
            this.AddEmployeeBtn.Text = "Thêm nhân viên";
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.AutoRoundedCorners = true;
            this.UsernameTextbox.BorderRadius = 14;
            this.UsernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTextbox.DefaultText = "";
            this.UsernameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextbox.Location = new System.Drawing.Point(227, 534);
            this.UsernameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.PasswordChar = '\0';
            this.UsernameTextbox.PlaceholderText = "";
            this.UsernameTextbox.SelectedText = "";
            this.UsernameTextbox.Size = new System.Drawing.Size(384, 31);
            this.UsernameTextbox.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(46, 534);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tên đăng nhập";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(44, 576);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Mật khẩu";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.AutoRoundedCorners = true;
            this.PasswordTextbox.BorderRadius = 14;
            this.PasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextbox.DefaultText = "";
            this.PasswordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextbox.Location = new System.Drawing.Point(227, 576);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '\0';
            this.PasswordTextbox.PlaceholderText = "";
            this.PasswordTextbox.SelectedText = "";
            this.PasswordTextbox.Size = new System.Drawing.Size(384, 31);
            this.PasswordTextbox.TabIndex = 22;
            // 
            // AddEmployeesSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 695);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.AddEmployeeBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.JobTitlesCB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StartingDateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddressTextbox);
            this.Controls.Add(this.PhoneNumberTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GenderCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BirthDateTimePicker);
            this.Controls.Add(this.EmpFirstNameTextbox);
            this.Controls.Add(this.EmpLastNameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label5);
            this.Name = "AddEmployeesSubForm";
            this.Text = "AddEmployeesSubForm";
            this.Load += new System.EventHandler(this.AddEmployeesSubForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox EmpLastNameTextbox;
        private Guna.UI2.WinForms.Guna2TextBox EmpFirstNameTextbox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker BirthDateTimePicker;
        private Guna.UI2.WinForms.Guna2ComboBox GenderCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox PhoneNumberTextbox;
        private Guna.UI2.WinForms.Guna2TextBox AddressTextbox;
        private Guna.UI2.WinForms.Guna2DateTimePicker StartingDateTimePicker;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox JobTitlesCB;
        private Guna.UI2.WinForms.Guna2Button AddEmployeeBtn;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextbox;
    }
}