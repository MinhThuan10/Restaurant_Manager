namespace RestaurantManager.GUI.UserControls
{
    partial class UC_Bills
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeleteBillBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PayBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TableSetBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FilterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TimeUnitCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhaHangAnUongDataSet = new RestaurantManager.QuanLyNhaHangAnUongDataSet();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new RestaurantManager.QuanLyNhaHangAnUongDataSetTableAdapters.HoaDonTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.BillsDG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BillDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BillDetailsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaHangAnUongDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDG)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBillBtn
            // 
            this.DeleteBillBtn.AutoRoundedCorners = true;
            this.DeleteBillBtn.BorderRadius = 21;
            this.DeleteBillBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBillBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBillBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBillBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBillBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBillBtn.Enabled = false;
            this.DeleteBillBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DeleteBillBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBillBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBillBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.DeleteBillBtn.Location = new System.Drawing.Point(900, 326);
            this.DeleteBillBtn.Name = "DeleteBillBtn";
            this.DeleteBillBtn.Size = new System.Drawing.Size(207, 45);
            this.DeleteBillBtn.TabIndex = 7;
            this.DeleteBillBtn.Text = "Xoá hoá đơn";
            this.DeleteBillBtn.Click += new System.EventHandler(this.DeleteBillBtn_Click);
            // 
            // PayBtn
            // 
            this.PayBtn.AutoRoundedCorners = true;
            this.PayBtn.BorderRadius = 21;
            this.PayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PayBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PayBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PayBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PayBtn.Enabled = false;
            this.PayBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.PayBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBtn.ForeColor = System.Drawing.Color.White;
            this.PayBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.PayBtn.Location = new System.Drawing.Point(900, 262);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(207, 45);
            this.PayBtn.TabIndex = 9;
            this.PayBtn.Text = "Thanh Toán";
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // TableSetBtn
            // 
            this.TableSetBtn.AutoRoundedCorners = true;
            this.TableSetBtn.BorderRadius = 21;
            this.TableSetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TableSetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TableSetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TableSetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TableSetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TableSetBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TableSetBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableSetBtn.ForeColor = System.Drawing.Color.White;
            this.TableSetBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.TableSetBtn.Location = new System.Drawing.Point(900, 134);
            this.TableSetBtn.Name = "TableSetBtn";
            this.TableSetBtn.Size = new System.Drawing.Size(207, 45);
            this.TableSetBtn.TabIndex = 10;
            this.TableSetBtn.Text = "Thêm hoá đơn";
            this.TableSetBtn.Click += new System.EventHandler(this.TableSetBtn_Click);
            // 
            // FilterBtn
            // 
            this.FilterBtn.AutoRoundedCorners = true;
            this.FilterBtn.BorderRadius = 16;
            this.FilterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FilterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.FilterBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBtn.ForeColor = System.Drawing.Color.White;
            this.FilterBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.FilterBtn.Location = new System.Drawing.Point(714, 68);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(134, 35);
            this.FilterBtn.TabIndex = 17;
            this.FilterBtn.Text = "Lọc";
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
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
            this.TimeUnitCB.Location = new System.Drawing.Point(546, 67);
            this.TimeUnitCB.Name = "TimeUnitCB";
            this.TimeUnitCB.Size = new System.Drawing.Size(162, 36);
            this.TimeUnitCB.TabIndex = 19;
            // 
            // quanLyNhaHangAnUongDataSet
            // 
            this.quanLyNhaHangAnUongDataSet.DataSetName = "QuanLyNhaHangAnUongDataSet";
            this.quanLyNhaHangAnUongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.quanLyNhaHangAnUongDataSet;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // BillsDG
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.BillsDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillsDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.BillsDG.ColumnHeadersHeight = 20;
            this.BillsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillsDG.DefaultCellStyle = dataGridViewCellStyle9;
            this.BillsDG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.BillsDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillsDG.Location = new System.Drawing.Point(30, 116);
            this.BillsDG.Name = "BillsDG";
            this.BillsDG.RowHeadersVisible = false;
            this.BillsDG.RowHeadersWidth = 51;
            this.BillsDG.RowTemplate.Height = 24;
            this.BillsDG.Size = new System.Drawing.Size(818, 411);
            this.BillsDG.TabIndex = 21;
            this.BillsDG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillsDG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillsDG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillsDG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillsDG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillsDG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillsDG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillsDG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BillsDG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillsDG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillsDG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillsDG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillsDG.ThemeStyle.HeaderStyle.Height = 20;
            this.BillsDG.ThemeStyle.ReadOnly = false;
            this.BillsDG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillsDG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillsDG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillsDG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillsDG.ThemeStyle.RowsStyle.Height = 24;
            this.BillsDG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillsDG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillsDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsDG_CellClick);
            // 
            // BillDateTimePicker
            // 
            this.BillDateTimePicker.AutoRoundedCorners = true;
            this.BillDateTimePicker.BorderRadius = 17;
            this.BillDateTimePicker.Checked = true;
            this.BillDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BillDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.BillDateTimePicker.Location = new System.Drawing.Point(30, 67);
            this.BillDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BillDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BillDateTimePicker.Name = "BillDateTimePicker";
            this.BillDateTimePicker.Size = new System.Drawing.Size(510, 36);
            this.BillDateTimePicker.TabIndex = 22;
            this.BillDateTimePicker.Value = new System.DateTime(2023, 11, 16, 11, 13, 41, 33);
            // 
            // BillDetailsBtn
            // 
            this.BillDetailsBtn.AutoRoundedCorners = true;
            this.BillDetailsBtn.BorderRadius = 21;
            this.BillDetailsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BillDetailsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BillDetailsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BillDetailsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BillDetailsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BillDetailsBtn.Enabled = false;
            this.BillDetailsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BillDetailsBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDetailsBtn.ForeColor = System.Drawing.Color.White;
            this.BillDetailsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.BillDetailsBtn.Location = new System.Drawing.Point(900, 197);
            this.BillDetailsBtn.Name = "BillDetailsBtn";
            this.BillDetailsBtn.Size = new System.Drawing.Size(207, 45);
            this.BillDetailsBtn.TabIndex = 7;
            this.BillDetailsBtn.Text = "Xem chi tiết";
            this.BillDetailsBtn.Click += new System.EventHandler(this.BillDetailsBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(513, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 33);
            this.label5.TabIndex = 24;
            this.label5.Text = "HOÁ ĐƠN";
            // 
            // UC_Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BillDateTimePicker);
            this.Controls.Add(this.BillsDG);
            this.Controls.Add(this.TimeUnitCB);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.BillDetailsBtn);
            this.Controls.Add(this.DeleteBillBtn);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.TableSetBtn);
            this.Name = "UC_Bills";
            this.Size = new System.Drawing.Size(1147, 560);
            this.Load += new System.EventHandler(this.UC_Bills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaHangAnUongDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button DeleteBillBtn;
        private Guna.UI2.WinForms.Guna2Button PayBtn;
        private Guna.UI2.WinForms.Guna2Button TableSetBtn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Guna.UI2.WinForms.Guna2Button FilterBtn;
        private Guna.UI2.WinForms.Guna2ComboBox TimeUnitCB;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QuanLyNhaHangAnUongDataSet quanLyNhaHangAnUongDataSet;
        private QuanLyNhaHangAnUongDataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DataGridView BillsDG;
        private Guna.UI2.WinForms.Guna2DateTimePicker BillDateTimePicker;
        private Guna.UI2.WinForms.Guna2Button BillDetailsBtn;
        private System.Windows.Forms.Label label5;
    }
}
