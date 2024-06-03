namespace RestaurantManager.GUI.UserControls
{
    partial class UC_Materials
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MaterialsDG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TableSetBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateMaterialBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteMaterialBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialsDG)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MaterialsDG.DefaultCellStyle = dataGridViewCellStyle6;
            this.MaterialsDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MaterialsDG.Location = new System.Drawing.Point(30, 116);
            this.MaterialsDG.Name = "MaterialsDG";
            this.MaterialsDG.RowHeadersVisible = false;
            this.MaterialsDG.RowHeadersWidth = 51;
            this.MaterialsDG.RowTemplate.Height = 24;
            this.MaterialsDG.Size = new System.Drawing.Size(818, 411);
            this.MaterialsDG.TabIndex = 1;
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
            this.MaterialsDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MaterialsDG_CellClick);
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
            this.TableSetBtn.Location = new System.Drawing.Point(907, 126);
            this.TableSetBtn.Name = "TableSetBtn";
            this.TableSetBtn.Size = new System.Drawing.Size(187, 45);
            this.TableSetBtn.TabIndex = 6;
            this.TableSetBtn.Text = "Thêm NL mới";
            this.TableSetBtn.Click += new System.EventHandler(this.TableSetBtn_Click);
            // 
            // UpdateMaterialBtn
            // 
            this.UpdateMaterialBtn.AutoRoundedCorners = true;
            this.UpdateMaterialBtn.BorderRadius = 21;
            this.UpdateMaterialBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateMaterialBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateMaterialBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateMaterialBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateMaterialBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateMaterialBtn.Enabled = false;
            this.UpdateMaterialBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.UpdateMaterialBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateMaterialBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateMaterialBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.UpdateMaterialBtn.Location = new System.Drawing.Point(907, 194);
            this.UpdateMaterialBtn.Name = "UpdateMaterialBtn";
            this.UpdateMaterialBtn.Size = new System.Drawing.Size(187, 45);
            this.UpdateMaterialBtn.TabIndex = 6;
            this.UpdateMaterialBtn.Text = "Sửa NL";
            this.UpdateMaterialBtn.Click += new System.EventHandler(this.UpdateMaterialBtn_Click);
            // 
            // DeleteMaterialBtn
            // 
            this.DeleteMaterialBtn.AutoRoundedCorners = true;
            this.DeleteMaterialBtn.BorderRadius = 21;
            this.DeleteMaterialBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteMaterialBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteMaterialBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteMaterialBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteMaterialBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteMaterialBtn.Enabled = false;
            this.DeleteMaterialBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DeleteMaterialBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMaterialBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteMaterialBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.DeleteMaterialBtn.Location = new System.Drawing.Point(907, 265);
            this.DeleteMaterialBtn.Name = "DeleteMaterialBtn";
            this.DeleteMaterialBtn.Size = new System.Drawing.Size(187, 45);
            this.DeleteMaterialBtn.TabIndex = 6;
            this.DeleteMaterialBtn.Text = "Xoá NL";
            this.DeleteMaterialBtn.Click += new System.EventHandler(this.DeleteMaterialBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(503, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 33);
            this.label5.TabIndex = 24;
            this.label5.Text = "NGUYÊN LIỆU";
            // 
            // UC_Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteMaterialBtn);
            this.Controls.Add(this.UpdateMaterialBtn);
            this.Controls.Add(this.TableSetBtn);
            this.Controls.Add(this.MaterialsDG);
            this.Name = "UC_Materials";
            this.Size = new System.Drawing.Size(1147, 560);
            this.Load += new System.EventHandler(this.UC_Materials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialsDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView MaterialsDG;
        private Guna.UI2.WinForms.Guna2Button TableSetBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateMaterialBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteMaterialBtn;
        private System.Windows.Forms.Label label5;
    }
}
