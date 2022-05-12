namespace TT22_QuanLyNhaXe.FormQuanLy
{
    partial class frm_QLXe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_hienThi = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgv_hienThi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_tt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.inpt_mota = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_ChuXe = new System.Windows.Forms.ComboBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.cb_LoaiXe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inp_BienXe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.inpt_timKiem = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_timTheo = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.filter_loaiXe = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.filter_tt = new System.Windows.Forms.ComboBox();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_hienThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgv_hienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_hienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BienXe,
            this.LoaiXe,
            this.ChuXe,
            this.des,
            this.trangThai});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_hienThi.DefaultCellStyle = dataGridViewCellStyle8;
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
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // BienXe
            // 
            this.BienXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BienXe.HeaderText = "Biển Xe";
            this.BienXe.Name = "BienXe";
            this.BienXe.ReadOnly = true;
            // 
            // LoaiXe
            // 
            this.LoaiXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiXe.HeaderText = "Loại xe";
            this.LoaiXe.Name = "LoaiXe";
            this.LoaiXe.ReadOnly = true;
            // 
            // ChuXe
            // 
            this.ChuXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChuXe.HeaderText = "Chủ xe";
            this.ChuXe.Name = "ChuXe";
            this.ChuXe.ReadOnly = true;
            // 
            // des
            // 
            this.des.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.des.HeaderText = "Mô tả xe";
            this.des.Name = "des";
            this.des.ReadOnly = true;
            // 
            // trangThai
            // 
            this.trangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
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
            this.panel4.Controls.Add(this.cb_tt);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btn_them);
            this.panel4.Controls.Add(this.inpt_mota);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.cb_ChuXe);
            this.panel4.Controls.Add(this.btn_xoa);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btn_sua);
            this.panel4.Controls.Add(this.cb_LoaiXe);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.inp_BienXe);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1254, 393);
            this.panel4.TabIndex = 4;
            // 
            // cb_tt
            // 
            this.cb_tt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_tt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tt.FormattingEnabled = true;
            this.cb_tt.Items.AddRange(new object[] {
            "Đang để xe",
            "Không có trong nhà xe"});
            this.cb_tt.Location = new System.Drawing.Point(532, 290);
            this.cb_tt.Name = "cb_tt";
            this.cb_tt.Size = new System.Drawing.Size(301, 28);
            this.cb_tt.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(373, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Đang để xe :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(542, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thông tin xe";
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.AutoSize = true;
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_them.Location = new System.Drawing.Point(502, 348);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(81, 32);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm xe";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // inpt_mota
            // 
            this.inpt_mota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inpt_mota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_mota.Location = new System.Drawing.Point(532, 243);
            this.inpt_mota.Name = "inpt_mota";
            this.inpt_mota.Size = new System.Drawing.Size(350, 26);
            this.inpt_mota.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(373, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 26);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mô tả xe :";
            // 
            // cb_ChuXe
            // 
            this.cb_ChuXe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_ChuXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ChuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ChuXe.FormattingEnabled = true;
            this.cb_ChuXe.Location = new System.Drawing.Point(535, 191);
            this.cb_ChuXe.Name = "cb_ChuXe";
            this.cb_ChuXe.Size = new System.Drawing.Size(236, 28);
            this.cb_ChuXe.TabIndex = 8;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_xoa.AutoSize = true;
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_xoa.Location = new System.Drawing.Point(711, 348);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 32);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(373, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chủ xe :";
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sua.AutoSize = true;
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_sua.Location = new System.Drawing.Point(589, 348);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(116, 32);
            this.btn_sua.TabIndex = 11;
            this.btn_sua.Text = "Sửa thông tin";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // cb_LoaiXe
            // 
            this.cb_LoaiXe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_LoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LoaiXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_LoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiXe.FormattingEnabled = true;
            this.cb_LoaiXe.Items.AddRange(new object[] {
            "Xe đạp",
            "Xe máy",
            "Ô tô"});
            this.cb_LoaiXe.Location = new System.Drawing.Point(535, 135);
            this.cb_LoaiXe.Name = "cb_LoaiXe";
            this.cb_LoaiXe.Size = new System.Drawing.Size(195, 28);
            this.cb_LoaiXe.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(373, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Loại xe :";
            // 
            // inp_BienXe
            // 
            this.inp_BienXe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inp_BienXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_BienXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inp_BienXe.Location = new System.Drawing.Point(535, 75);
            this.inp_BienXe.Name = "inp_BienXe";
            this.inp_BienXe.Size = new System.Drawing.Size(195, 26);
            this.inp_BienXe.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(373, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Biển xe :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.inpt_timKiem);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.cb_timTheo);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.filter_loaiXe);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.filter_tt);
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
            "Biển số",
            "Tên chủ xe",
            "Mô tả xe"});
            this.cb_timTheo.Location = new System.Drawing.Point(12, 33);
            this.cb_timTheo.Name = "cb_timTheo";
            this.cb_timTheo.Size = new System.Drawing.Size(107, 28);
            this.cb_timTheo.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(984, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "Loại xe";
            // 
            // filter_loaiXe
            // 
            this.filter_loaiXe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.filter_loaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter_loaiXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_loaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_loaiXe.FormattingEnabled = true;
            this.filter_loaiXe.Items.AddRange(new object[] {
            "Tất cả",
            "Xe đạp",
            "Xe máy",
            "Ô tô"});
            this.filter_loaiXe.Location = new System.Drawing.Point(970, 36);
            this.filter_loaiXe.Name = "filter_loaiXe";
            this.filter_loaiXe.Size = new System.Drawing.Size(100, 28);
            this.filter_loaiXe.TabIndex = 18;
            this.filter_loaiXe.SelectedIndexChanged += new System.EventHandler(this.locDL);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1159, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Tinh trạng";
            // 
            // filter_tt
            // 
            this.filter_tt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.filter_tt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter_tt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_tt.FormattingEnabled = true;
            this.filter_tt.Items.AddRange(new object[] {
            "Tất cả",
            "Đang để",
            "Không có trong nhà xe"});
            this.filter_tt.Location = new System.Drawing.Point(1086, 36);
            this.filter_tt.Name = "filter_tt";
            this.filter_tt.Size = new System.Drawing.Size(165, 28);
            this.filter_tt.TabIndex = 3;
            this.filter_tt.SelectedIndexChanged += new System.EventHandler(this.locDL);
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
            // frm_QLXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1254, 671);
            this.Controls.Add(this.pnl_hienThi);
            this.Name = "frm_QLXe";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inp_BienXe;
        private System.Windows.Forms.ComboBox cb_LoaiXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_ChuXe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox filter_tt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox filter_loaiXe;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_timTheo;
        private System.Windows.Forms.TextBox inpt_timKiem;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox inpt_mota;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn des;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_tt;
        private System.Windows.Forms.Label label2;
        private QLNXDataSet qLNXDataSet;
        private System.Windows.Forms.BindingSource veXeBindingSource;
        private QLNXDataSetTableAdapters.VeXeTableAdapter veXeTableAdapter;
    }
}