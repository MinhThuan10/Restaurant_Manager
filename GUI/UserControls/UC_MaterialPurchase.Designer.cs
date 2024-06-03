namespace RestaurantManager.GUI.UserControls
{
    partial class UC_MaterialPurchase
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
            this.AddMPBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MaterialPurchasesDG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DeleteMPBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TimeUnitCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MPDetailsBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialPurchasesDG)).BeginInit();
            this.SuspendLayout();
            // 
            // AddMPBtn
            // 
            this.AddMPBtn.AutoRoundedCorners = true;
            this.AddMPBtn.BorderRadius = 21;
            this.AddMPBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMPBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddMPBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddMPBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddMPBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddMPBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.AddMPBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMPBtn.ForeColor = System.Drawing.Color.White;
            this.AddMPBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.AddMPBtn.Location = new System.Drawing.Point(905, 133);
            this.AddMPBtn.Name = "AddMPBtn";
            this.AddMPBtn.Size = new System.Drawing.Size(193, 45);
            this.AddMPBtn.TabIndex = 25;
            this.AddMPBtn.Text = "Thêm ĐN";
            this.AddMPBtn.Click += new System.EventHandler(this.AddMPBtn_Click);
            // 
            // MaterialPurchasesDG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MaterialPurchasesDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MaterialPurchasesDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MaterialPurchasesDG.ColumnHeadersHeight = 20;
            this.MaterialPurchasesDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MaterialPurchasesDG.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaterialPurchasesDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MaterialPurchasesDG.Location = new System.Drawing.Point(30, 116);
            this.MaterialPurchasesDG.Name = "MaterialPurchasesDG";
            this.MaterialPurchasesDG.ReadOnly = true;
            this.MaterialPurchasesDG.RowHeadersVisible = false;
            this.MaterialPurchasesDG.RowHeadersWidth = 51;
            this.MaterialPurchasesDG.RowTemplate.Height = 24;
            this.MaterialPurchasesDG.Size = new System.Drawing.Size(818, 416);
            this.MaterialPurchasesDG.TabIndex = 22;
            this.MaterialPurchasesDG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MaterialPurchasesDG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MaterialPurchasesDG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MaterialPurchasesDG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MaterialPurchasesDG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MaterialPurchasesDG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MaterialPurchasesDG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MaterialPurchasesDG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MaterialPurchasesDG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MaterialPurchasesDG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialPurchasesDG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MaterialPurchasesDG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MaterialPurchasesDG.ThemeStyle.HeaderStyle.Height = 20;
            this.MaterialPurchasesDG.ThemeStyle.ReadOnly = true;
            this.MaterialPurchasesDG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MaterialPurchasesDG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MaterialPurchasesDG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialPurchasesDG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MaterialPurchasesDG.ThemeStyle.RowsStyle.Height = 24;
            this.MaterialPurchasesDG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MaterialPurchasesDG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MaterialPurchasesDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MaterialPurchasesDG_CellClick);
            // 
            // SearchBtn
            // 
            this.SearchBtn.AutoRoundedCorners = true;
            this.SearchBtn.BorderRadius = 19;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.SearchBtn.Location = new System.Drawing.Point(714, 66);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(134, 40);
            this.SearchBtn.TabIndex = 26;
            this.SearchBtn.Text = "Lọc";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.AutoRoundedCorners = true;
            this.DateTimePicker.BorderRadius = 17;
            this.DateTimePicker.Checked = true;
            this.DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker.Location = new System.Drawing.Point(30, 70);
            this.DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(510, 36);
            this.DateTimePicker.TabIndex = 27;
            this.DateTimePicker.Value = new System.DateTime(2023, 11, 16, 2, 44, 41, 244);
            // 
            // DeleteMPBtn
            // 
            this.DeleteMPBtn.AutoRoundedCorners = true;
            this.DeleteMPBtn.BorderRadius = 21;
            this.DeleteMPBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteMPBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteMPBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteMPBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteMPBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteMPBtn.Enabled = false;
            this.DeleteMPBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DeleteMPBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMPBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteMPBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.DeleteMPBtn.Location = new System.Drawing.Point(905, 258);
            this.DeleteMPBtn.Name = "DeleteMPBtn";
            this.DeleteMPBtn.Size = new System.Drawing.Size(193, 45);
            this.DeleteMPBtn.TabIndex = 25;
            this.DeleteMPBtn.Text = "Xoá ĐN";
            this.DeleteMPBtn.Click += new System.EventHandler(this.DeletePurchaseBtn_Click);
            // 
            // TimeUnitCB
            // 
            this.TimeUnitCB.BackColor = System.Drawing.Color.Transparent;
            this.TimeUnitCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TimeUnitCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeUnitCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeUnitCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeUnitCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TimeUnitCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TimeUnitCB.ItemHeight = 30;
            this.TimeUnitCB.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Năm"});
            this.TimeUnitCB.Location = new System.Drawing.Point(546, 70);
            this.TimeUnitCB.Name = "TimeUnitCB";
            this.TimeUnitCB.Size = new System.Drawing.Size(162, 36);
            this.TimeUnitCB.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(481, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 33);
            this.label5.TabIndex = 29;
            this.label5.Text = "ĐƠN NHẬP";
            // 
            // MPDetailsBtn
            // 
            this.MPDetailsBtn.AutoRoundedCorners = true;
            this.MPDetailsBtn.BorderRadius = 21;
            this.MPDetailsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MPDetailsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MPDetailsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MPDetailsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MPDetailsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MPDetailsBtn.Enabled = false;
            this.MPDetailsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.MPDetailsBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MPDetailsBtn.ForeColor = System.Drawing.Color.White;
            this.MPDetailsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.MPDetailsBtn.Location = new System.Drawing.Point(905, 198);
            this.MPDetailsBtn.Name = "MPDetailsBtn";
            this.MPDetailsBtn.Size = new System.Drawing.Size(193, 45);
            this.MPDetailsBtn.TabIndex = 30;
            this.MPDetailsBtn.Text = "Xem chi tiết";
            this.MPDetailsBtn.Click += new System.EventHandler(this.MPDetailsBtn_Click);
            // 
            // UC_MaterialPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MPDetailsBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TimeUnitCB);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteMPBtn);
            this.Controls.Add(this.AddMPBtn);
            this.Controls.Add(this.MaterialPurchasesDG);
            this.Name = "UC_MaterialPurchase";
            this.Size = new System.Drawing.Size(1147, 560);
            this.Load += new System.EventHandler(this.UC_MaterialPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialPurchasesDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button AddMPBtn;
        private Guna.UI2.WinForms.Guna2DataGridView MaterialPurchasesDG;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
        private Guna.UI2.WinForms.Guna2Button DeleteMPBtn;
        private Guna.UI2.WinForms.Guna2ComboBox TimeUnitCB;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button MPDetailsBtn;
    }
}
