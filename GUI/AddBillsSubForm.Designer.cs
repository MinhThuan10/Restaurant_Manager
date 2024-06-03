namespace RestaurantManager.GUI
{
    partial class AddBillsSubForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductsCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddProductBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TablesIDCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TotalTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddBillBtn = new Guna.UI2.WinForms.Guna2Button();
            this.QuantityTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductListDG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NameOfProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDG)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsCB
            // 
            this.ProductsCB.BackColor = System.Drawing.Color.Transparent;
            this.ProductsCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProductsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductsCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductsCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductsCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ProductsCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ProductsCB.ItemHeight = 30;
            this.ProductsCB.Location = new System.Drawing.Point(140, 103);
            this.ProductsCB.Name = "ProductsCB";
            this.ProductsCB.Size = new System.Drawing.Size(254, 36);
            this.ProductsCB.TabIndex = 0;
            this.ProductsCB.SelectedIndexChanged += new System.EventHandler(this.ProductsCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(31, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn món";
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.AutoRoundedCorners = true;
            this.AddProductBtn.BorderRadius = 17;
            this.AddProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProductBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddProductBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddProductBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddProductBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddProductBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.AddProductBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductBtn.ForeColor = System.Drawing.Color.White;
            this.AddProductBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.AddProductBtn.Location = new System.Drawing.Point(580, 103);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(127, 36);
            this.AddProductBtn.TabIndex = 6;
            this.AddProductBtn.Text = "Thêm";
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(31, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "SĐT khách hàng";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderRadius = 18;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(227, 393);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(308, 38);
            this.guna2TextBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(31, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số bàn";
            // 
            // TablesIDCB
            // 
            this.TablesIDCB.AutoRoundedCorners = true;
            this.TablesIDCB.BackColor = System.Drawing.Color.Transparent;
            this.TablesIDCB.BorderRadius = 17;
            this.TablesIDCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TablesIDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TablesIDCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TablesIDCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TablesIDCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TablesIDCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TablesIDCB.ItemHeight = 30;
            this.TablesIDCB.Location = new System.Drawing.Point(227, 453);
            this.TablesIDCB.Name = "TablesIDCB";
            this.TablesIDCB.Size = new System.Drawing.Size(88, 36);
            this.TablesIDCB.TabIndex = 9;
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
            this.TotalTextbox.Location = new System.Drawing.Point(680, 301);
            this.TotalTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TotalTextbox.Name = "TotalTextbox";
            this.TotalTextbox.PasswordChar = '\0';
            this.TotalTextbox.PlaceholderText = "";
            this.TotalTextbox.ReadOnly = true;
            this.TotalTextbox.SelectedText = "";
            this.TotalTextbox.Size = new System.Drawing.Size(244, 68);
            this.TotalTextbox.TabIndex = 10;
            // 
            // AddBillBtn
            // 
            this.AddBillBtn.AutoRoundedCorners = true;
            this.AddBillBtn.BorderRadius = 26;
            this.AddBillBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBillBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBillBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBillBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBillBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBillBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.AddBillBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBillBtn.ForeColor = System.Drawing.Color.White;
            this.AddBillBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.AddBillBtn.Location = new System.Drawing.Point(680, 427);
            this.AddBillBtn.Name = "AddBillBtn";
            this.AddBillBtn.Size = new System.Drawing.Size(231, 54);
            this.AddBillBtn.TabIndex = 6;
            this.AddBillBtn.Text = "Thêm hoá đơn";
            this.AddBillBtn.Click += new System.EventHandler(this.AddBillBtn_Click);
            // 
            // QuantityTextbox
            // 
            this.QuantityTextbox.AutoCompleteCustomSource.AddRange(new string[] {
            "1"});
            this.QuantityTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityTextbox.DefaultText = "1";
            this.QuantityTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuantityTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuantityTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QuantityTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTextbox.Location = new System.Drawing.Point(501, 103);
            this.QuantityTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuantityTextbox.Name = "QuantityTextbox";
            this.QuantityTextbox.PasswordChar = '\0';
            this.QuantityTextbox.PlaceholderText = "";
            this.QuantityTextbox.SelectedText = "";
            this.QuantityTextbox.Size = new System.Drawing.Size(55, 36);
            this.QuantityTextbox.TabIndex = 11;
            this.QuantityTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(400, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng";
            // 
            // ProductListDG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProductListDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductListDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductListDG.ColumnHeadersHeight = 18;
            this.ProductListDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductListDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfProductColumn,
            this.QuantityColumn,
            this.PriceColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductListDG.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductListDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductListDG.Location = new System.Drawing.Point(35, 167);
            this.ProductListDG.Name = "ProductListDG";
            this.ProductListDG.RowHeadersVisible = false;
            this.ProductListDG.RowHeadersWidth = 51;
            this.ProductListDG.RowTemplate.Height = 24;
            this.ProductListDG.Size = new System.Drawing.Size(521, 202);
            this.ProductListDG.TabIndex = 12;
            this.ProductListDG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductListDG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductListDG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductListDG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductListDG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductListDG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductListDG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductListDG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProductListDG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductListDG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductListDG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductListDG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductListDG.ThemeStyle.HeaderStyle.Height = 18;
            this.ProductListDG.ThemeStyle.ReadOnly = false;
            this.ProductListDG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductListDG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductListDG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductListDG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductListDG.ThemeStyle.RowsStyle.Height = 24;
            this.ProductListDG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductListDG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductListDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductListDG_CellClick);
            // 
            // NameOfProductColumn
            // 
            this.NameOfProductColumn.HeaderText = "Tên sản phẩm";
            this.NameOfProductColumn.MinimumWidth = 6;
            this.NameOfProductColumn.Name = "NameOfProductColumn";
            this.NameOfProductColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.HeaderText = "Số lượng";
            this.QuantityColumn.MinimumWidth = 6;
            this.QuantityColumn.Name = "QuantityColumn";
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Đơn giá";
            this.PriceColumn.MinimumWidth = 6;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(750, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng tiền";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoRoundedCorners = true;
            this.DeleteBtn.BorderRadius = 16;
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(580, 167);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(127, 35);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "Xoá";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(331, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "THÊM HOÁ ĐƠN MỚI";
            // 
            // AddBillsSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 535);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ProductListDG);
            this.Controls.Add(this.QuantityTextbox);
            this.Controls.Add(this.TotalTextbox);
            this.Controls.Add(this.TablesIDCB);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddBillBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductsCB);
            this.Name = "AddBillsSubForm";
            this.Text = " Thêm hoá đơn";
            this.Load += new System.EventHandler(this.AddBillsSubForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox ProductsCB;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button AddProductBtn;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox TablesIDCB;
        private Guna.UI2.WinForms.Guna2TextBox TotalTextbox;
        private Guna.UI2.WinForms.Guna2Button AddBillBtn;
        private Guna.UI2.WinForms.Guna2TextBox QuantityTextbox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView ProductListDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private System.Windows.Forms.Label label6;
    }
}