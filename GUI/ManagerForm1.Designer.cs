namespace RestaurantManager.GUI
{
    partial class ManagerForm1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm1));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.MaterialPurchaseTabBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EmployeeTabBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerTabBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BillTabBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.ProductTagBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MaterialTabBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TableTabBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ContainerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1343, 50);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.TableTabBtn);
            this.guna2Panel1.Controls.Add(this.MaterialPurchaseTabBtn);
            this.guna2Panel1.Controls.Add(this.BillTabBtn);
            this.guna2Panel1.Controls.Add(this.EmployeeTabBtn);
            this.guna2Panel1.Controls.Add(this.CustomerTabBtn);
            this.guna2Panel1.Controls.Add(this.guna2Button6);
            this.guna2Panel1.Controls.Add(this.ProductTagBtn);
            this.guna2Panel1.Controls.Add(this.MaterialTabBtn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 50);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(214, 563);
            this.guna2Panel1.TabIndex = 1;
            // 
            // MaterialPurchaseTabBtn
            // 
            this.MaterialPurchaseTabBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.MaterialPurchaseTabBtn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaterialPurchaseTabBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.MaterialPurchaseTabBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaterialPurchaseTabBtn.CustomBorderColor = System.Drawing.Color.White;
            this.MaterialPurchaseTabBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.MaterialPurchaseTabBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MaterialPurchaseTabBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MaterialPurchaseTabBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MaterialPurchaseTabBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MaterialPurchaseTabBtn.FillColor = System.Drawing.Color.White;
            this.MaterialPurchaseTabBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialPurchaseTabBtn.ForeColor = System.Drawing.Color.Black;
            this.MaterialPurchaseTabBtn.HoverState.FillColor = System.Drawing.Color.Silver;
            this.MaterialPurchaseTabBtn.Image = global::RestaurantManager.Properties.Resources.checklist;
            this.MaterialPurchaseTabBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaterialPurchaseTabBtn.Location = new System.Drawing.Point(3, 301);
            this.MaterialPurchaseTabBtn.Name = "MaterialPurchaseTabBtn";
            this.MaterialPurchaseTabBtn.Size = new System.Drawing.Size(211, 60);
            this.MaterialPurchaseTabBtn.TabIndex = 0;
            this.MaterialPurchaseTabBtn.Text = "Đơn nhập";
            this.MaterialPurchaseTabBtn.TextOffset = new System.Drawing.Point(10, 0);
            this.MaterialPurchaseTabBtn.Click += new System.EventHandler(this.MaterialPurchaseTabBtn_Click);
            // 
            // EmployeeTabBtn
            // 
            this.EmployeeTabBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.EmployeeTabBtn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EmployeeTabBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.EmployeeTabBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeeTabBtn.CustomBorderColor = System.Drawing.Color.White;
            this.EmployeeTabBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.EmployeeTabBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeTabBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeTabBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmployeeTabBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmployeeTabBtn.FillColor = System.Drawing.Color.White;
            this.EmployeeTabBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeTabBtn.ForeColor = System.Drawing.Color.Black;
            this.EmployeeTabBtn.HoverState.FillColor = System.Drawing.Color.Silver;
            this.EmployeeTabBtn.Image = global::RestaurantManager.Properties.Resources.employee;
            this.EmployeeTabBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmployeeTabBtn.Location = new System.Drawing.Point(3, 180);
            this.EmployeeTabBtn.Name = "EmployeeTabBtn";
            this.EmployeeTabBtn.Size = new System.Drawing.Size(211, 60);
            this.EmployeeTabBtn.TabIndex = 0;
            this.EmployeeTabBtn.Text = "Nhân viên";
            this.EmployeeTabBtn.TextOffset = new System.Drawing.Point(10, 0);
            this.EmployeeTabBtn.Click += new System.EventHandler(this.EmployeeTabBtn_Click);
            // 
            // CustomerTabBtn
            // 
            this.CustomerTabBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CustomerTabBtn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CustomerTabBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.CustomerTabBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerTabBtn.CustomBorderColor = System.Drawing.Color.White;
            this.CustomerTabBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.CustomerTabBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CustomerTabBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CustomerTabBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomerTabBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CustomerTabBtn.FillColor = System.Drawing.Color.White;
            this.CustomerTabBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerTabBtn.ForeColor = System.Drawing.Color.Black;
            this.CustomerTabBtn.HoverState.FillColor = System.Drawing.Color.Silver;
            this.CustomerTabBtn.Image = global::RestaurantManager.Properties.Resources.Customer;
            this.CustomerTabBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomerTabBtn.Location = new System.Drawing.Point(3, 120);
            this.CustomerTabBtn.Name = "CustomerTabBtn";
            this.CustomerTabBtn.Size = new System.Drawing.Size(211, 60);
            this.CustomerTabBtn.TabIndex = 0;
            this.CustomerTabBtn.Text = "Khách hàng";
            this.CustomerTabBtn.TextOffset = new System.Drawing.Point(10, 0);
            this.CustomerTabBtn.Click += new System.EventHandler(this.CustomerTabBtn_Click);
            // 
            // BillTabBtn
            // 
            this.BillTabBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BillTabBtn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BillTabBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.BillTabBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BillTabBtn.CustomBorderColor = System.Drawing.Color.White;
            this.BillTabBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.BillTabBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BillTabBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BillTabBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BillTabBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BillTabBtn.FillColor = System.Drawing.Color.White;
            this.BillTabBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillTabBtn.ForeColor = System.Drawing.Color.Black;
            this.BillTabBtn.HoverState.FillColor = System.Drawing.Color.Silver;
            this.BillTabBtn.Image = global::RestaurantManager.Properties.Resources.bill;
            this.BillTabBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BillTabBtn.ImageSize = new System.Drawing.Size(22, 22);
            this.BillTabBtn.Location = new System.Drawing.Point(3, 0);
            this.BillTabBtn.Name = "BillTabBtn";
            this.BillTabBtn.Size = new System.Drawing.Size(211, 60);
            this.BillTabBtn.TabIndex = 0;
            this.BillTabBtn.Text = "Hoá đơn";
            this.BillTabBtn.TextOffset = new System.Drawing.Point(10, 0);
            this.BillTabBtn.Click += new System.EventHandler(this.BillTabBtn_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button6.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button6.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button6.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Button6.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.White;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.Black;
            this.guna2Button6.HoverState.FillColor = System.Drawing.Color.Silver;
            this.guna2Button6.Location = new System.Drawing.Point(3, 135);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(172, 60);
            this.guna2Button6.TabIndex = 0;
            this.guna2Button6.Text = "Đơn nhập";
            // 
            // ProductTagBtn
            // 
            this.ProductTagBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ProductTagBtn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProductTagBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.ProductTagBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductTagBtn.CustomBorderColor = System.Drawing.Color.White;
            this.ProductTagBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.ProductTagBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProductTagBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProductTagBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProductTagBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProductTagBtn.FillColor = System.Drawing.Color.White;
            this.ProductTagBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTagBtn.ForeColor = System.Drawing.Color.Black;
            this.ProductTagBtn.HoverState.FillColor = System.Drawing.Color.Silver;
            this.ProductTagBtn.Image = global::RestaurantManager.Properties.Resources.revenue;
            this.ProductTagBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductTagBtn.Location = new System.Drawing.Point(3, 355);
            this.ProductTagBtn.Name = "ProductTagBtn";
            this.ProductTagBtn.Size = new System.Drawing.Size(211, 60);
            this.ProductTagBtn.TabIndex = 0;
            this.ProductTagBtn.Text = "Các chỉ số";
            this.ProductTagBtn.TextOffset = new System.Drawing.Point(10, 0);
            this.ProductTagBtn.Click += new System.EventHandler(this.ProductTagBtn_Click);
            // 
            // MaterialTabBtn
            // 
            this.MaterialTabBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.MaterialTabBtn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaterialTabBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.MaterialTabBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaterialTabBtn.CustomBorderColor = System.Drawing.Color.White;
            this.MaterialTabBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.MaterialTabBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MaterialTabBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MaterialTabBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MaterialTabBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MaterialTabBtn.FillColor = System.Drawing.Color.White;
            this.MaterialTabBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialTabBtn.ForeColor = System.Drawing.Color.Black;
            this.MaterialTabBtn.HoverState.FillColor = System.Drawing.Color.Silver;
            this.MaterialTabBtn.Image = global::RestaurantManager.Properties.Resources.carrots;
            this.MaterialTabBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaterialTabBtn.Location = new System.Drawing.Point(3, 241);
            this.MaterialTabBtn.Name = "MaterialTabBtn";
            this.MaterialTabBtn.Size = new System.Drawing.Size(211, 60);
            this.MaterialTabBtn.TabIndex = 0;
            this.MaterialTabBtn.Text = "Nguyên liệu";
            this.MaterialTabBtn.TextOffset = new System.Drawing.Point(10, 0);
            this.MaterialTabBtn.Click += new System.EventHandler(this.MaterialTabBtn_Click);
            // 
            // TableTabBtn
            // 
            this.TableTabBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.TableTabBtn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TableTabBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.TableTabBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TableTabBtn.CustomBorderColor = System.Drawing.Color.White;
            this.TableTabBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.TableTabBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TableTabBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TableTabBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TableTabBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TableTabBtn.FillColor = System.Drawing.Color.White;
            this.TableTabBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableTabBtn.ForeColor = System.Drawing.Color.Black;
            this.TableTabBtn.HoverState.FillColor = System.Drawing.Color.Silver;
            this.TableTabBtn.Image = global::RestaurantManager.Properties.Resources.dinner_table;
            this.TableTabBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TableTabBtn.ImageSize = new System.Drawing.Size(22, 22);
            this.TableTabBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TableTabBtn.Location = new System.Drawing.Point(3, 60);
            this.TableTabBtn.Name = "TableTabBtn";
            this.TableTabBtn.Size = new System.Drawing.Size(211, 60);
            this.TableTabBtn.TabIndex = 0;
            this.TableTabBtn.Text = "Bàn ăn";
            this.TableTabBtn.TextOffset = new System.Drawing.Point(10, 0);
            this.TableTabBtn.Click += new System.EventHandler(this.TableTabBtn_Click);
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(214, 50);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(1129, 563);
            this.ContainerPanel.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bill.png");
            this.imageList1.Images.SetKeyName(1, "manager_icon_129392.ico");
            this.imageList1.Images.SetKeyName(2, "table.png");
            // 
            // ManagerForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 613);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerForm1";
            this.Text = "Quản lý nhà hàng";
            this.Load += new System.EventHandler(this.ManagerForm1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button TableTabBtn;
        private Guna.UI2.WinForms.Guna2Button BillTabBtn;
        private Guna.UI2.WinForms.Guna2Button CustomerTabBtn;
        private Guna.UI2.WinForms.Guna2Button MaterialTabBtn;
        private Guna.UI2.WinForms.Guna2Button EmployeeTabBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button MaterialPurchaseTabBtn;
        private Guna.UI2.WinForms.Guna2Panel ContainerPanel;
        private Guna.UI2.WinForms.Guna2Button ProductTagBtn;
        private System.Windows.Forms.ImageList imageList1;
    }
}