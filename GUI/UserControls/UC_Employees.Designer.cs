namespace RestaurantManager.GUI.UserControls
{
    partial class UC_Employees
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
            this.NameSearchTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchByNameBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteEmployeeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateEmployeeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TableSetBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EmployeesDG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDG)).BeginInit();
            this.SuspendLayout();
            // 
            // NameSearchTextbox
            // 
            this.NameSearchTextbox.AutoRoundedCorners = true;
            this.NameSearchTextbox.BorderRadius = 20;
            this.NameSearchTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameSearchTextbox.DefaultText = "";
            this.NameSearchTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameSearchTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameSearchTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameSearchTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameSearchTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameSearchTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameSearchTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameSearchTextbox.Location = new System.Drawing.Point(30, 66);
            this.NameSearchTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameSearchTextbox.Name = "NameSearchTextbox";
            this.NameSearchTextbox.PasswordChar = '\0';
            this.NameSearchTextbox.PlaceholderText = "Tìm nhân viên theo tên";
            this.NameSearchTextbox.SelectedText = "";
            this.NameSearchTextbox.Size = new System.Drawing.Size(678, 43);
            this.NameSearchTextbox.TabIndex = 22;
            // 
            // SearchByNameBtn
            // 
            this.SearchByNameBtn.AutoRoundedCorners = true;
            this.SearchByNameBtn.BorderRadius = 19;
            this.SearchByNameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchByNameBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchByNameBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchByNameBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchByNameBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchByNameBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.SearchByNameBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByNameBtn.ForeColor = System.Drawing.Color.White;
            this.SearchByNameBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.SearchByNameBtn.Location = new System.Drawing.Point(714, 66);
            this.SearchByNameBtn.Name = "SearchByNameBtn";
            this.SearchByNameBtn.Size = new System.Drawing.Size(134, 40);
            this.SearchByNameBtn.TabIndex = 18;
            this.SearchByNameBtn.Text = "Tìm";
            this.SearchByNameBtn.Click += new System.EventHandler(this.SearchByNameBtn_Click);
            // 
            // DeleteEmployeeBtn
            // 
            this.DeleteEmployeeBtn.AutoRoundedCorners = true;
            this.DeleteEmployeeBtn.BorderRadius = 21;
            this.DeleteEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteEmployeeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteEmployeeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteEmployeeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteEmployeeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteEmployeeBtn.Enabled = false;
            this.DeleteEmployeeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DeleteEmployeeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteEmployeeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.DeleteEmployeeBtn.Location = new System.Drawing.Point(917, 248);
            this.DeleteEmployeeBtn.Name = "DeleteEmployeeBtn";
            this.DeleteEmployeeBtn.Size = new System.Drawing.Size(182, 45);
            this.DeleteEmployeeBtn.TabIndex = 19;
            this.DeleteEmployeeBtn.Text = "Xoá NV";
            this.DeleteEmployeeBtn.Click += new System.EventHandler(this.DeleteEmployeeBtn_Click);
            // 
            // UpdateEmployeeBtn
            // 
            this.UpdateEmployeeBtn.AutoRoundedCorners = true;
            this.UpdateEmployeeBtn.BorderRadius = 21;
            this.UpdateEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateEmployeeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateEmployeeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateEmployeeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateEmployeeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateEmployeeBtn.Enabled = false;
            this.UpdateEmployeeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.UpdateEmployeeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateEmployeeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.UpdateEmployeeBtn.Location = new System.Drawing.Point(917, 184);
            this.UpdateEmployeeBtn.Name = "UpdateEmployeeBtn";
            this.UpdateEmployeeBtn.Size = new System.Drawing.Size(182, 45);
            this.UpdateEmployeeBtn.TabIndex = 20;
            this.UpdateEmployeeBtn.Text = "Sửa NV";
            this.UpdateEmployeeBtn.Click += new System.EventHandler(this.UpdateEmployeeBtn_Click);
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
            this.TableSetBtn.Location = new System.Drawing.Point(917, 120);
            this.TableSetBtn.Name = "TableSetBtn";
            this.TableSetBtn.Size = new System.Drawing.Size(182, 45);
            this.TableSetBtn.TabIndex = 21;
            this.TableSetBtn.Text = "Thêm NV";
            this.TableSetBtn.Click += new System.EventHandler(this.TableSetBtn_Click);
            // 
            // EmployeesDG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmployeesDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeesDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeesDG.ColumnHeadersHeight = 20;
            this.EmployeesDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeesDG.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeesDG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EmployeesDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeesDG.Location = new System.Drawing.Point(30, 116);
            this.EmployeesDG.Name = "EmployeesDG";
            this.EmployeesDG.RowHeadersVisible = false;
            this.EmployeesDG.RowHeadersWidth = 51;
            this.EmployeesDG.RowTemplate.Height = 24;
            this.EmployeesDG.Size = new System.Drawing.Size(818, 411);
            this.EmployeesDG.TabIndex = 23;
            this.EmployeesDG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeesDG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeesDG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeesDG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeesDG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeesDG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeesDG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeesDG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmployeesDG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeesDG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesDG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeesDG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeesDG.ThemeStyle.HeaderStyle.Height = 20;
            this.EmployeesDG.ThemeStyle.ReadOnly = false;
            this.EmployeesDG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeesDG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeesDG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesDG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeesDG.ThemeStyle.RowsStyle.Height = 24;
            this.EmployeesDG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeesDG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeesDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesDG_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(504, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 33);
            this.label5.TabIndex = 24;
            this.label5.Text = "NHÂN VIÊN";
            // 
            // UC_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmployeesDG);
            this.Controls.Add(this.NameSearchTextbox);
            this.Controls.Add(this.SearchByNameBtn);
            this.Controls.Add(this.DeleteEmployeeBtn);
            this.Controls.Add(this.UpdateEmployeeBtn);
            this.Controls.Add(this.TableSetBtn);
            this.Name = "UC_Employees";
            this.Size = new System.Drawing.Size(1147, 560);
            this.Load += new System.EventHandler(this.UC_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox NameSearchTextbox;
        private Guna.UI2.WinForms.Guna2Button SearchByNameBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteEmployeeBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateEmployeeBtn;
        private Guna.UI2.WinForms.Guna2Button TableSetBtn;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeesDG;
        private System.Windows.Forms.Label label5;
    }
}
