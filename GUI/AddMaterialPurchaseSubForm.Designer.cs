namespace RestaurantManager.GUI
{
    partial class AddMaterialPurchaseSubForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProvidersCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.MaterialsCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddProductBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.QuantityTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.MaterialsDG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AddBillBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TotalTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NameOfMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialsDG)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::RestaurantManager.Properties.Resources.checklist;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(239, 21);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(76, 74);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(346, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "THÊM ĐƠN NHẬP MỚI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(62, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chọn nhà cung cấp";
            // 
            // ProvidersCB
            // 
            this.ProvidersCB.AutoRoundedCorners = true;
            this.ProvidersCB.BackColor = System.Drawing.Color.Transparent;
            this.ProvidersCB.BorderRadius = 17;
            this.ProvidersCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProvidersCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProvidersCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProvidersCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProvidersCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ProvidersCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ProvidersCB.ItemHeight = 30;
            this.ProvidersCB.Location = new System.Drawing.Point(284, 119);
            this.ProvidersCB.Name = "ProvidersCB";
            this.ProvidersCB.Size = new System.Drawing.Size(252, 36);
            this.ProvidersCB.TabIndex = 7;
            this.ProvidersCB.SelectedIndexChanged += new System.EventHandler(this.ProvidersCB_SelectedIndexChanged);
            // 
            // MaterialsCB
            // 
            this.MaterialsCB.AutoRoundedCorners = true;
            this.MaterialsCB.BackColor = System.Drawing.Color.Transparent;
            this.MaterialsCB.BorderRadius = 17;
            this.MaterialsCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MaterialsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialsCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaterialsCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaterialsCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MaterialsCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.MaterialsCB.ItemHeight = 30;
            this.MaterialsCB.Location = new System.Drawing.Point(284, 167);
            this.MaterialsCB.Name = "MaterialsCB";
            this.MaterialsCB.Size = new System.Drawing.Size(252, 36);
            this.MaterialsCB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(62, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn nguyên liệu";
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
            this.AddProductBtn.Location = new System.Drawing.Point(409, 275);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(127, 36);
            this.AddProductBtn.TabIndex = 10;
            this.AddProductBtn.Text = "Thêm";
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(62, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số lượng";
            // 
            // QuantityTextbox
            // 
            this.QuantityTextbox.AutoRoundedCorners = true;
            this.QuantityTextbox.BorderRadius = 17;
            this.QuantityTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityTextbox.DefaultText = "50";
            this.QuantityTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuantityTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuantityTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QuantityTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTextbox.Location = new System.Drawing.Point(284, 216);
            this.QuantityTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuantityTextbox.Name = "QuantityTextbox";
            this.QuantityTextbox.PasswordChar = '\0';
            this.QuantityTextbox.PlaceholderText = "";
            this.QuantityTextbox.SelectedText = "";
            this.QuantityTextbox.Size = new System.Drawing.Size(252, 37);
            this.QuantityTextbox.TabIndex = 11;
            // 
            // MaterialsDG
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.MaterialsDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MaterialsDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.MaterialsDG.ColumnHeadersHeight = 20;
            this.MaterialsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MaterialsDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfMaterial,
            this.Price,
            this.Quantity,
            this.Value});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MaterialsDG.DefaultCellStyle = dataGridViewCellStyle6;
            this.MaterialsDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MaterialsDG.Location = new System.Drawing.Point(616, 126);
            this.MaterialsDG.Name = "MaterialsDG";
            this.MaterialsDG.RowHeadersVisible = false;
            this.MaterialsDG.RowHeadersWidth = 51;
            this.MaterialsDG.RowTemplate.Height = 24;
            this.MaterialsDG.Size = new System.Drawing.Size(351, 295);
            this.MaterialsDG.TabIndex = 9;
            this.MaterialsDG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MaterialsDG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MaterialsDG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MaterialsDG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MaterialsDG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MaterialsDG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MaterialsDG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MaterialsDG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MaterialsDG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MaterialsDG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialsDG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MaterialsDG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MaterialsDG.ThemeStyle.HeaderStyle.Height = 20;
            this.MaterialsDG.ThemeStyle.ReadOnly = false;
            this.MaterialsDG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MaterialsDG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MaterialsDG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialsDG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MaterialsDG.ThemeStyle.RowsStyle.Height = 24;
            this.MaterialsDG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MaterialsDG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // AddBillBtn
            // 
            this.AddBillBtn.AutoRoundedCorners = true;
            this.AddBillBtn.BorderRadius = 23;
            this.AddBillBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBillBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBillBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBillBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBillBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBillBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.AddBillBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBillBtn.ForeColor = System.Drawing.Color.White;
            this.AddBillBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.AddBillBtn.Location = new System.Drawing.Point(736, 449);
            this.AddBillBtn.Name = "AddBillBtn";
            this.AddBillBtn.Size = new System.Drawing.Size(231, 48);
            this.AddBillBtn.TabIndex = 12;
            this.AddBillBtn.Text = "Thêm đơn nhập";
            this.AddBillBtn.Click += new System.EventHandler(this.AddBillBtn_Click);
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
            this.TotalTextbox.Location = new System.Drawing.Point(186, 408);
            this.TotalTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TotalTextbox.Name = "TotalTextbox";
            this.TotalTextbox.PasswordChar = '\0';
            this.TotalTextbox.PlaceholderText = "";
            this.TotalTextbox.ReadOnly = true;
            this.TotalTextbox.SelectedText = "";
            this.TotalTextbox.Size = new System.Drawing.Size(350, 68);
            this.TotalTextbox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(313, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tổng tiền";
            // 
            // NameOfMaterial
            // 
            this.NameOfMaterial.HeaderText = "Tên NL";
            this.NameOfMaterial.MinimumWidth = 6;
            this.NameOfMaterial.Name = "NameOfMaterial";
            // 
            // Price
            // 
            this.Price.HeaderText = "Đơn giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Value
            // 
            this.Value.HeaderText = "Tổng";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            // 
            // AddMaterialPurchaseSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 509);
            this.Controls.Add(this.TotalTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddBillBtn);
            this.Controls.Add(this.QuantityTextbox);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.MaterialsDG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaterialsCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProvidersCB);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label6);
            this.Name = "AddMaterialPurchaseSubForm";
            this.Text = "AddMaterialPurchaseSubForm";
            this.Load += new System.EventHandler(this.AddMaterialPurchaseSubForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialsDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox ProvidersCB;
        private Guna.UI2.WinForms.Guna2ComboBox MaterialsCB;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button AddProductBtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox QuantityTextbox;
        private Guna.UI2.WinForms.Guna2DataGridView MaterialsDG;
        private Guna.UI2.WinForms.Guna2Button AddBillBtn;
        private Guna.UI2.WinForms.Guna2TextBox TotalTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}