namespace TT22_QuanLyNhaXe.FormQuanLy
{
    partial class frm_TrangChu
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
            this.pnl_hienThi = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgv_hienThi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gGui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nLay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.inpt_mota = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_err = new System.Windows.Forms.Label();
            this.cb_ChuXe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_LoaiXe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inp_BienXe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_LoaiVe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.inpt_timKiem = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_timTheo = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.filter_loaiXe = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.filter_loaiVe = new System.Windows.Forms.ComboBox();
            this.dt_ngayGui = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.filter_tt = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_xeVao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_TienVe = new System.Windows.Forms.Label();
            this.lbel = new System.Windows.Forms.Label();
            this.btn_lay = new System.Windows.Forms.Button();
            this.btn_gui = new System.Windows.Forms.Button();
            this.inpt_DiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inpt_sdt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inpt_TenChuXe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_hienThi.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hienThi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(0, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 251);
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
            this.ID,
            this.BienXe,
            this.LoaiXe,
            this.ChuXe,
            this.loaiVe,
            this.gGui,
            this.nGui,
            this.glay,
            this.nLay,
            this.trangThai});
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
            this.dtgv_hienThi.Size = new System.Drawing.Size(1254, 251);
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
            // loaiVe
            // 
            this.loaiVe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaiVe.HeaderText = "Loại vé";
            this.loaiVe.Name = "loaiVe";
            this.loaiVe.ReadOnly = true;
            // 
            // gGui
            // 
            this.gGui.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gGui.HeaderText = "Giờ gửi";
            this.gGui.Name = "gGui";
            this.gGui.ReadOnly = true;
            // 
            // nGui
            // 
            this.nGui.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nGui.HeaderText = "Ngày gửi";
            this.nGui.Name = "nGui";
            this.nGui.ReadOnly = true;
            // 
            // glay
            // 
            this.glay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.glay.HeaderText = "Giờ lấy";
            this.glay.Name = "glay";
            this.glay.ReadOnly = true;
            // 
            // nLay
            // 
            this.nLay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nLay.HeaderText = "Ngày lấy";
            this.nLay.Name = "nLay";
            this.nLay.ReadOnly = true;
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
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 420);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.inpt_mota);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.lbl_err);
            this.panel4.Controls.Add(this.cb_ChuXe);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cb_LoaiXe);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.inp_BienXe);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cb_LoaiVe);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(-5, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(630, 344);
            this.panel4.TabIndex = 4;
            // 
            // inpt_mota
            // 
            this.inpt_mota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_mota.Location = new System.Drawing.Point(237, 294);
            this.inpt_mota.Name = "inpt_mota";
            this.inpt_mota.Size = new System.Drawing.Size(350, 26);
            this.inpt_mota.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(105, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 26);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mô tả xe :";
            // 
            // lbl_err
            // 
            this.lbl_err.AutoSize = true;
            this.lbl_err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.lbl_err.Location = new System.Drawing.Point(237, 273);
            this.lbl_err.Name = "lbl_err";
            this.lbl_err.Size = new System.Drawing.Size(129, 13);
            this.lbl_err.TabIndex = 9;
            this.lbl_err.Text = "Hãy điền thông tin chủ xe";
            // 
            // cb_ChuXe
            // 
            this.cb_ChuXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ChuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ChuXe.FormattingEnabled = true;
            this.cb_ChuXe.Location = new System.Drawing.Point(240, 242);
            this.cb_ChuXe.Name = "cb_ChuXe";
            this.cb_ChuXe.Size = new System.Drawing.Size(236, 28);
            this.cb_ChuXe.TabIndex = 8;
            this.cb_ChuXe.SelectedIndexChanged += new System.EventHandler(this.cb_ChuXe_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(119, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chủ xe :";
            // 
            // cb_LoaiXe
            // 
            this.cb_LoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LoaiXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_LoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiXe.FormattingEnabled = true;
            this.cb_LoaiXe.Items.AddRange(new object[] {
            "Xe đạp",
            "Xe máy",
            "Ô tô"});
            this.cb_LoaiXe.Location = new System.Drawing.Point(240, 186);
            this.cb_LoaiXe.Name = "cb_LoaiXe";
            this.cb_LoaiXe.Size = new System.Drawing.Size(195, 28);
            this.cb_LoaiXe.TabIndex = 6;
            this.cb_LoaiXe.SelectedIndexChanged += new System.EventHandler(this.tinhTien);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(119, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Loại xe :";
            // 
            // inp_BienXe
            // 
            this.inp_BienXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_BienXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inp_BienXe.Location = new System.Drawing.Point(240, 126);
            this.inp_BienXe.Name = "inp_BienXe";
            this.inp_BienXe.Size = new System.Drawing.Size(195, 26);
            this.inp_BienXe.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(119, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Biển xe :";
            // 
            // cb_LoaiVe
            // 
            this.cb_LoaiVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LoaiVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_LoaiVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiVe.FormattingEnabled = true;
            this.cb_LoaiVe.Items.AddRange(new object[] {
            "Vé ngày",
            "Vé qua đêm"});
            this.cb_LoaiVe.Location = new System.Drawing.Point(240, 63);
            this.cb_LoaiVe.Name = "cb_LoaiVe";
            this.cb_LoaiVe.Size = new System.Drawing.Size(176, 28);
            this.cb_LoaiVe.TabIndex = 2;
            this.cb_LoaiVe.SelectedIndexChanged += new System.EventHandler(this.tinhTien);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(119, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại vé :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(271, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vé xe";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.inpt_timKiem);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.cb_timTheo);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.filter_loaiXe);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.filter_loaiVe);
            this.panel5.Controls.Add(this.dt_ngayGui);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.filter_tt);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 353);
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
            this.inpt_timKiem.Size = new System.Drawing.Size(281, 30);
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
            "Tên chủ xe"});
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
            this.label16.Location = new System.Drawing.Point(765, 13);
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
            this.filter_loaiXe.Location = new System.Drawing.Point(751, 36);
            this.filter_loaiXe.Name = "filter_loaiXe";
            this.filter_loaiXe.Size = new System.Drawing.Size(100, 28);
            this.filter_loaiXe.TabIndex = 18;
            this.filter_loaiXe.SelectedIndexChanged += new System.EventHandler(this.locDL);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(871, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Loại vé";
            // 
            // filter_loaiVe
            // 
            this.filter_loaiVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.filter_loaiVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter_loaiVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_loaiVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_loaiVe.FormattingEnabled = true;
            this.filter_loaiVe.Items.AddRange(new object[] {
            "Tất cả",
            "Vé ngày",
            "Vé qua đêm"});
            this.filter_loaiVe.Location = new System.Drawing.Point(857, 36);
            this.filter_loaiVe.Name = "filter_loaiVe";
            this.filter_loaiVe.Size = new System.Drawing.Size(100, 28);
            this.filter_loaiVe.TabIndex = 16;
            this.filter_loaiVe.SelectedIndexChanged += new System.EventHandler(this.locDL);
            // 
            // dt_ngayGui
            // 
            this.dt_ngayGui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_ngayGui.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngayGui.CustomFormat = "dd/MM/yyyy";
            this.dt_ngayGui.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngayGui.Location = new System.Drawing.Point(996, 41);
            this.dt_ngayGui.Name = "dt_ngayGui";
            this.dt_ngayGui.Size = new System.Drawing.Size(112, 20);
            this.dt_ngayGui.TabIndex = 15;
            this.dt_ngayGui.ValueChanged += new System.EventHandler(this.locDL);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1017, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Ngày gửi";
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
            "Chưa lấy",
            "Đã lấy",
            "Quá hạn"});
            this.filter_tt.Location = new System.Drawing.Point(1151, 36);
            this.filter_tt.Name = "filter_tt";
            this.filter_tt.Size = new System.Drawing.Size(100, 28);
            this.filter_tt.TabIndex = 3;
            this.filter_tt.SelectedIndexChanged += new System.EventHandler(this.locDL);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btn_xeVao);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.lbl_TienVe);
            this.panel3.Controls.Add(this.lbel);
            this.panel3.Controls.Add(this.btn_lay);
            this.panel3.Controls.Add(this.btn_gui);
            this.panel3.Controls.Add(this.inpt_DiaChi);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.inpt_sdt);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.inpt_TenChuXe);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel3.Location = new System.Drawing.Point(629, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 344);
            this.panel3.TabIndex = 2;
            // 
            // btn_xeVao
            // 
            this.btn_xeVao.AutoSize = true;
            this.btn_xeVao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xeVao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xeVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xeVao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_xeVao.Location = new System.Drawing.Point(145, 290);
            this.btn_xeVao.Name = "btn_xeVao";
            this.btn_xeVao.Size = new System.Drawing.Size(75, 32);
            this.btn_xeVao.TabIndex = 13;
            this.btn_xeVao.Text = "Xe vào";
            this.btn_xeVao.UseVisualStyleBackColor = true;
            this.btn_xeVao.Click += new System.EventHandler(this.btn_xeVao_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.button1.Location = new System.Drawing.Point(145, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Gửi xe";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_TienVe
            // 
            this.lbl_TienVe.AutoSize = true;
            this.lbl_TienVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TienVe.ForeColor = System.Drawing.Color.White;
            this.lbl_TienVe.Location = new System.Drawing.Point(281, 241);
            this.lbl_TienVe.Name = "lbl_TienVe";
            this.lbl_TienVe.Size = new System.Drawing.Size(24, 26);
            this.lbl_TienVe.TabIndex = 11;
            this.lbl_TienVe.Text = "0";
            // 
            // lbel
            // 
            this.lbel.AutoSize = true;
            this.lbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbel.ForeColor = System.Drawing.Color.White;
            this.lbel.Location = new System.Drawing.Point(166, 241);
            this.lbel.Name = "lbel";
            this.lbel.Size = new System.Drawing.Size(106, 26);
            this.lbel.TabIndex = 10;
            this.lbel.Text = "Tiền vé :  ";
            // 
            // btn_lay
            // 
            this.btn_lay.AutoSize = true;
            this.btn_lay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lay.Enabled = false;
            this.btn_lay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_lay.Location = new System.Drawing.Point(375, 290);
            this.btn_lay.Name = "btn_lay";
            this.btn_lay.Size = new System.Drawing.Size(75, 32);
            this.btn_lay.TabIndex = 12;
            this.btn_lay.Text = "Lấy xe";
            this.btn_lay.UseVisualStyleBackColor = true;
            this.btn_lay.Click += new System.EventHandler(this.btn_lay_Click);
            // 
            // btn_gui
            // 
            this.btn_gui.AutoSize = true;
            this.btn_gui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gui.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_gui.Location = new System.Drawing.Point(260, 290);
            this.btn_gui.Name = "btn_gui";
            this.btn_gui.Size = new System.Drawing.Size(75, 32);
            this.btn_gui.TabIndex = 11;
            this.btn_gui.Text = "Gửi xe";
            this.btn_gui.UseVisualStyleBackColor = true;
            this.btn_gui.Click += new System.EventHandler(this.btn_gui_Click);
            // 
            // inpt_DiaChi
            // 
            this.inpt_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_DiaChi.Location = new System.Drawing.Point(280, 188);
            this.inpt_DiaChi.Name = "inpt_DiaChi";
            this.inpt_DiaChi.Size = new System.Drawing.Size(195, 26);
            this.inpt_DiaChi.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(166, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 26);
            this.label9.TabIndex = 9;
            this.label9.Text = "Địa chỉ :";
            // 
            // inpt_sdt
            // 
            this.inpt_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_sdt.Location = new System.Drawing.Point(280, 127);
            this.inpt_sdt.Name = "inpt_sdt";
            this.inpt_sdt.Size = new System.Drawing.Size(195, 26);
            this.inpt_sdt.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(106, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số điện thoại :";
            // 
            // inpt_TenChuXe
            // 
            this.inpt_TenChuXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_TenChuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_TenChuXe.Location = new System.Drawing.Point(280, 65);
            this.inpt_TenChuXe.Name = "inpt_TenChuXe";
            this.inpt_TenChuXe.Size = new System.Drawing.Size(195, 26);
            this.inpt_TenChuXe.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(140, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "Họ và tên :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(212, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Thông tin chủ xe";
            // 
            // frm_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1254, 671);
            this.Controls.Add(this.pnl_hienThi);
            this.Name = "frm_TrangChu";
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_hienThi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgv_hienThi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_LoaiVe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inp_BienXe;
        private System.Windows.Forms.ComboBox cb_LoaiXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_ChuXe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inpt_TenChuXe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inpt_DiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inpt_sdt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_err;
        private System.Windows.Forms.Label lbel;
        private System.Windows.Forms.ComboBox filter_tt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dt_ngayGui;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox filter_loaiVe;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox filter_loaiXe;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_timTheo;
        private System.Windows.Forms.TextBox inpt_timKiem;
        private System.Windows.Forms.Button btn_gui;
        private System.Windows.Forms.Button btn_lay;
        private System.Windows.Forms.Label lbl_TienVe;
        private System.Windows.Forms.TextBox inpt_mota;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_xeVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn gGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn glay;
        private System.Windows.Forms.DataGridViewTextBoxColumn nLay;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
    }
}