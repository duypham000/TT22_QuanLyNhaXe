namespace TT22_QuanLyNhaXe.FormQuanLy
{
    partial class frm_DoanhThu
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
            this.dt_den = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tongTien = new System.Windows.Forms.Label();
            this.dt_tu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_hienThi = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgv_hienThi = new System.Windows.Forms.DataGridView();
            this.nXet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.pnl_hienThi.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hienThi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_den
            // 
            this.dt_den.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_den.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_den.CustomFormat = "dd/MM/yyyy";
            this.dt_den.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_den.Location = new System.Drawing.Point(164, 36);
            this.dt_den.Name = "dt_den";
            this.dt_den.Size = new System.Drawing.Size(112, 20);
            this.dt_den.TabIndex = 15;
            this.dt_den.ValueChanged += new System.EventHandler(this.dt_den_ValueChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(185, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Tới ngày";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(983, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Tổng tiền: ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.tongTien);
            this.panel5.Controls.Add(this.dt_tu);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.dt_den);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1254, 67);
            this.panel5.TabIndex = 3;
            // 
            // tongTien
            // 
            this.tongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tongTien.AutoSize = true;
            this.tongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongTien.ForeColor = System.Drawing.Color.White;
            this.tongTien.Location = new System.Drawing.Point(1072, 36);
            this.tongTien.Name = "tongTien";
            this.tongTien.Size = new System.Drawing.Size(18, 20);
            this.tongTien.TabIndex = 24;
            this.tongTien.Text = "0";
            // 
            // dt_tu
            // 
            this.dt_tu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_tu.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_tu.CustomFormat = "dd/MM/yyyy";
            this.dt_tu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_tu.Location = new System.Drawing.Point(19, 36);
            this.dt_tu.Name = "dt_tu";
            this.dt_tu.Size = new System.Drawing.Size(112, 20);
            this.dt_tu.TabIndex = 23;
            this.dt_tu.ValueChanged += new System.EventHandler(this.dt_tu_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Từ ngày";
            // 
            // pnl_hienThi
            // 
            this.pnl_hienThi.Controls.Add(this.panel2);
            this.pnl_hienThi.Controls.Add(this.panel1);
            this.pnl_hienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_hienThi.Location = new System.Drawing.Point(0, 0);
            this.pnl_hienThi.Name = "pnl_hienThi";
            this.pnl_hienThi.Size = new System.Drawing.Size(1254, 671);
            this.pnl_hienThi.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgv_hienThi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 603);
            this.panel2.TabIndex = 1;
            // 
            // dtgv_hienThi
            // 
            this.dtgv_hienThi.AllowUserToAddRows = false;
            this.dtgv_hienThi.AllowUserToDeleteRows = false;
            this.dtgv_hienThi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_hienThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_hienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_hienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nXet,
            this.soLuong,
            this.SoTien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_hienThi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_hienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_hienThi.Location = new System.Drawing.Point(0, 0);
            this.dtgv_hienThi.MultiSelect = false;
            this.dtgv_hienThi.Name = "dtgv_hienThi";
            this.dtgv_hienThi.ReadOnly = true;
            this.dtgv_hienThi.RowTemplate.Height = 30;
            this.dtgv_hienThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_hienThi.Size = new System.Drawing.Size(1254, 603);
            this.dtgv_hienThi.TabIndex = 0;
            // 
            // nXet
            // 
            this.nXet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nXet.HeaderText = "Ngày";
            this.nXet.Name = "nXet";
            this.nXet.ReadOnly = true;
            // 
            // soLuong
            // 
            this.soLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soLuong.HeaderText = "Số lượng xe";
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            // 
            // SoTien
            // 
            this.SoTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTien.HeaderText = "Số tiền";
            this.SoTien.Name = "SoTien";
            this.SoTien.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 68);
            this.panel1.TabIndex = 0;
            // 
            // frm_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 671);
            this.Controls.Add(this.pnl_hienThi);
            this.Name = "frm_DoanhThu";
            this.Text = "frm_DoanhThu";
            this.Load += new System.EventHandler(this.frm_DoanhThu_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnl_hienThi.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hienThi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dt_den;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnl_hienThi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgv_hienThi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nXet;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DateTimePicker dt_tu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tongTien;
    }
}