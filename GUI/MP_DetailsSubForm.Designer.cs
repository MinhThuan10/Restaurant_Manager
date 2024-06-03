namespace RestaurantManager.GUI
{
    partial class MP_DetailsSubForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MPDetailsDG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.QuitBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.MPDetailsDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(384, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "CHI TIẾT ĐƠN NHẬP";
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
            this.TotalTextbox.Location = new System.Drawing.Point(121, 443);
            this.TotalTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TotalTextbox.Name = "TotalTextbox";
            this.TotalTextbox.PasswordChar = '\0';
            this.TotalTextbox.PlaceholderText = "";
            this.TotalTextbox.ReadOnly = true;
            this.TotalTextbox.SelectedText = "";
            this.TotalTextbox.Size = new System.Drawing.Size(244, 68);
            this.TotalTextbox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(24, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tổng tiền";
            // 
            // MPDetailsDG
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.MPDetailsDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MPDetailsDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.MPDetailsDG.ColumnHeadersHeight = 20;
            this.MPDetailsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MPDetailsDG.DefaultCellStyle = dataGridViewCellStyle12;
            this.MPDetailsDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MPDetailsDG.Location = new System.Drawing.Point(19, 97);
            this.MPDetailsDG.Name = "MPDetailsDG";
            this.MPDetailsDG.RowHeadersVisible = false;
            this.MPDetailsDG.RowHeadersWidth = 51;
            this.MPDetailsDG.RowTemplate.Height = 24;
            this.MPDetailsDG.Size = new System.Drawing.Size(994, 319);
            this.MPDetailsDG.TabIndex = 24;
            this.MPDetailsDG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MPDetailsDG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MPDetailsDG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MPDetailsDG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MPDetailsDG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MPDetailsDG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MPDetailsDG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MPDetailsDG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MPDetailsDG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MPDetailsDG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MPDetailsDG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MPDetailsDG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MPDetailsDG.ThemeStyle.HeaderStyle.Height = 20;
            this.MPDetailsDG.ThemeStyle.ReadOnly = false;
            this.MPDetailsDG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MPDetailsDG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MPDetailsDG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MPDetailsDG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MPDetailsDG.ThemeStyle.RowsStyle.Height = 24;
            this.MPDetailsDG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MPDetailsDG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MPDetailsDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MPDetailsDG_CellContentClick);
            // 
            // QuitBtn
            // 
            this.QuitBtn.AutoRoundedCorners = true;
            this.QuitBtn.BorderRadius = 21;
            this.QuitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.QuitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.QuitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.QuitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.QuitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.QuitBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitBtn.ForeColor = System.Drawing.Color.White;
            this.QuitBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.QuitBtn.Location = new System.Drawing.Point(820, 465);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(193, 45);
            this.QuitBtn.TabIndex = 28;
            this.QuitBtn.Text = "Thoát";
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // MP_DetailsSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 535);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MPDetailsDG);
            this.Name = "MP_DetailsSubForm";
            this.Text = "Chi tiết đơn nhập";
            ((System.ComponentModel.ISupportInitialize)(this.MPDetailsDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TotalTextbox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView MPDetailsDG;
        private Guna.UI2.WinForms.Guna2Button QuitBtn;
    }
}