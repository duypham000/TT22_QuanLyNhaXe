namespace TT22_QuanLyNhaXe.FormQuanLy
{
    partial class frm_QLKhach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_hienThi = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgv_hienThi = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.inp_diachi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inp_ten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inp_sdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.inpt_timKiem = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_timTheo = new System.Windows.Forms.ComboBox();
            this.qLNXDataSet = new TT22_QuanLyNhaXe.QLNXDataSet();
            this.veXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veXeTableAdapter = new TT22_QuanLyNhaXe.QLNXDataSetTableAdapters.VeXeTableAdapter();
            this.pnl_hienThi.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hienThi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veXeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_hienThi
            // 
            this.pnl_hienThi.Controls.Add(this.panel2);
            this.pnl_hienThi.Controls.Add(this.panel1);
            this.pnl_hienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_hienThi.Location = new System.Drawing.Point(0, 0);
            this.pnl_hienThi.Name = "pnl_hienThi";
            this.pnl_hienThi.Size = new System.Drawing.Size(1254, 671);
            this.pnl_hienThi.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgv_hienThi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 211);
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
            this.id,
            this.ten,
            this.diachi,
            this.sdt});
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
            this.dtgv_hienThi.Size = new System.Drawing.Size(1254, 211);
            this.dtgv_hienThi.TabIndex = 0;
            this.dtgv_hienThi.Click += new System.EventHandler(this.dtgv_hienThi_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ten
            // 
            this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten.HeaderText = "Tên khách hàng";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 460);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.inp_diachi);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.inp_ten);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.inp_sdt);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btn_them);
            this.panel4.Controls.Add(this.btn_xoa);
            this.panel4.Controls.Add(this.btn_sua);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1254, 393);
            this.panel4.TabIndex = 4;
            // 
            // inp_diachi
            // 
            this.inp_diachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inp_diachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inp_diachi.Location = new System.Drawing.Point(563, 187);
            this.inp_diachi.Name = "inp_diachi";
            this.inp_diachi.Size = new System.Drawing.Size(301, 26);
            this.inp_diachi.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(401, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 21;
            this.label7.Text = "Địa chỉ :";
            // 
            // inp_ten
            // 
            this.inp_ten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inp_ten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inp_ten.Location = new System.Drawing.Point(563, 128);
            this.inp_ten.Name = "inp_ten";
            this.inp_ten.Size = new System.Drawing.Size(301, 26);
            this.inp_ten.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(401, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tên nhân viên :";
            // 
            // inp_sdt
            // 
            this.inp_sdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inp_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inp_sdt.Location = new System.Drawing.Point(563, 243);
            this.inp_sdt.Name = "inp_sdt";
            this.inp_sdt.Size = new System.Drawing.Size(195, 26);
            this.inp_sdt.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(401, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Số điện thoại :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(446, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.AutoSize = true;
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_them.Location = new System.Drawing.Point(468, 331);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(133, 32);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm khách";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_xoa.AutoSize = true;
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_xoa.Location = new System.Drawing.Point(729, 331);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 32);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sua.AutoSize = true;
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_sua.Location = new System.Drawing.Point(607, 331);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(116, 32);
            this.btn_sua.TabIndex = 11;
            this.btn_sua.Text = "Sửa thông tin";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.inpt_timKiem);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.cb_timTheo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 393);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1254, 67);
            this.panel5.TabIndex = 3;
            // 
            // inpt_timKiem
            // 
            this.inpt_timKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inpt_timKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_timKiem.Location = new System.Drawing.Point(124, 31);
            this.inpt_timKiem.Name = "inpt_timKiem";
            this.inpt_timKiem.Size = new System.Drawing.Size(532, 30);
            this.inpt_timKiem.TabIndex = 11;
            this.inpt_timKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inpt_timKiem_KeyPress);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(12, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "Tìm kiếm theo";
            // 
            // cb_timTheo
            // 
            this.cb_timTheo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_timTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_timTheo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_timTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_timTheo.FormattingEnabled = true;
            this.cb_timTheo.Items.AddRange(new object[] {
            "Tên khách hàng",
            "Địa chỉ",
            "Số điện thoại"});
            this.cb_timTheo.Location = new System.Drawing.Point(12, 33);
            this.cb_timTheo.Name = "cb_timTheo";
            this.cb_timTheo.Size = new System.Drawing.Size(107, 28);
            this.cb_timTheo.TabIndex = 20;
            // 
            // qLNXDataSet
            // 
            this.qLNXDataSet.DataSetName = "QLNXDataSet";
            this.qLNXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veXeBindingSource
            // 
            this.veXeBindingSource.DataMember = "VeXe";
            this.veXeBindingSource.DataSource = this.qLNXDataSet;
            // 
            // veXeTableAdapter
            // 
            this.veXeTableAdapter.ClearBeforeFill = true;
            // 
            // frm_QLKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1254, 671);
            this.Controls.Add(this.pnl_hienThi);
            this.Name = "frm_QLKhach";
            this.Text = "Quản lý nhà xe";
            this.Load += new System.EventHandler(this.layout_ManHinhChinh_Load);
            this.pnl_hienThi.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hienThi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veXeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_hienThi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgv_hienThi;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_timTheo;
        private System.Windows.Forms.TextBox inpt_timKiem;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label1;
        private QLNXDataSet qLNXDataSet;
        private System.Windows.Forms.BindingSource veXeBindingSource;
        private QLNXDataSetTableAdapters.VeXeTableAdapter veXeTableAdapter;
        private System.Windows.Forms.TextBox inp_diachi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inp_ten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inp_sdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}