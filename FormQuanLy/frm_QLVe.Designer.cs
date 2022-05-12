namespace TT22_QuanLyNhaXe.FormQuanLy
{
    partial class frm_QLVe
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
            this.lbl_gia = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_nLay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_tt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_BienXe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_LoaiVe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_nGui = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.inpt_timKiem = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_timTheo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.filter_loaiVe = new System.Windows.Forms.ComboBox();
            this.dt_ngayGui = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.filter_tt = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.s_mta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.s_chu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.s_loai = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.s_bien = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chx_huy = new System.Windows.Forms.CheckBox();
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
            this.panel4.Controls.Add(this.lbl_gia);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.dt_nLay);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cb_tt);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cb_BienXe);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cb_LoaiVe);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dt_nGui);
            this.panel4.Location = new System.Drawing.Point(-5, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(630, 344);
            this.panel4.TabIndex = 4;
            // 
            // lbl_gia
            // 
            this.lbl_gia.AutoSize = true;
            this.lbl_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gia.ForeColor = System.Drawing.Color.White;
            this.lbl_gia.Location = new System.Drawing.Point(543, 285);
            this.lbl_gia.Name = "lbl_gia";
            this.lbl_gia.Size = new System.Drawing.Size(84, 26);
            this.lbl_gia.TabIndex = 54;
            this.lbl_gia.Text = "000000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(479, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 26);
            this.label11.TabIndex = 53;
            this.label11.Text = "Giá :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(135, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 26);
            this.label6.TabIndex = 52;
            this.label6.Text = "Ngày lấy :";
            // 
            // dt_nLay
            // 
            this.dt_nLay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dt_nLay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_nLay.CustomFormat = " dd/MM/yyyy HH:mm";
            this.dt_nLay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_nLay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_nLay.Location = new System.Drawing.Point(285, 285);
            this.dt_nLay.Name = "dt_nLay";
            this.dt_nLay.ShowUpDown = true;
            this.dt_nLay.Size = new System.Drawing.Size(164, 26);
            this.dt_nLay.TabIndex = 51;
            this.dt_nLay.Value = new System.DateTime(2022, 5, 1, 11, 39, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(135, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 26);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ngày gửi :";
            // 
            // cb_tt
            // 
            this.cb_tt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tt.FormattingEnabled = true;
            this.cb_tt.Items.AddRange(new object[] {
            "Đang gửi",
            "Đã lấy",
            "Quá hạn"});
            this.cb_tt.Location = new System.Drawing.Point(285, 172);
            this.cb_tt.Name = "cb_tt";
            this.cb_tt.Size = new System.Drawing.Size(249, 28);
            this.cb_tt.TabIndex = 48;
            this.cb_tt.SelectedIndexChanged += new System.EventHandler(this.cb_tt_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(135, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 47;
            this.label3.Text = "Trạng thái :";
            // 
            // cb_BienXe
            // 
            this.cb_BienXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_BienXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_BienXe.FormattingEnabled = true;
            this.cb_BienXe.Location = new System.Drawing.Point(288, 121);
            this.cb_BienXe.Name = "cb_BienXe";
            this.cb_BienXe.Size = new System.Drawing.Size(249, 28);
            this.cb_BienXe.TabIndex = 6;
            this.cb_BienXe.SelectedIndexChanged += new System.EventHandler(this.cb_BienXe_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(138, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Biển xe :";
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
            this.cb_LoaiVe.Location = new System.Drawing.Point(288, 63);
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
            this.label2.Location = new System.Drawing.Point(138, 65);
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
            // dt_nGui
            // 
            this.dt_nGui.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dt_nGui.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_nGui.CustomFormat = " dd/MM/yyyy HH:mm";
            this.dt_nGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_nGui.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_nGui.Location = new System.Drawing.Point(285, 233);
            this.dt_nGui.Name = "dt_nGui";
            this.dt_nGui.ShowUpDown = true;
            this.dt_nGui.Size = new System.Drawing.Size(164, 26);
            this.dt_nGui.TabIndex = 40;
            this.dt_nGui.Value = new System.DateTime(2022, 5, 1, 11, 39, 0, 0);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.chx_huy);
            this.panel5.Controls.Add(this.inpt_timKiem);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.cb_timTheo);
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
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(830, 13);
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
            this.filter_loaiVe.Location = new System.Drawing.Point(816, 36);
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
            this.dt_ngayGui.Location = new System.Drawing.Point(955, 41);
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
            this.label14.Location = new System.Drawing.Point(976, 13);
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
            this.panel3.Controls.Add(this.btn_them);
            this.panel3.Controls.Add(this.btn_xoa);
            this.panel3.Controls.Add(this.btn_sua);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.s_mta);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.s_chu);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.s_loai);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.s_bien);
            this.panel3.Controls.Add(this.label13);
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel3.Location = new System.Drawing.Point(629, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 344);
            this.panel3.TabIndex = 2;
            // 
            // btn_them
            // 
            this.btn_them.AutoSize = true;
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_them.Location = new System.Drawing.Point(158, 285);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(81, 32);
            this.btn_them.TabIndex = 28;
            this.btn_them.Text = "Thêm vé";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AutoSize = true;
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_xoa.Location = new System.Drawing.Point(367, 285);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 32);
            this.btn_xoa.TabIndex = 27;
            this.btn_xoa.Text = "Xóa vé";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.AutoSize = true;
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_sua.Location = new System.Drawing.Point(245, 285);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(116, 32);
            this.btn_sua.TabIndex = 26;
            this.btn_sua.Text = "Sửa thông tin";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(242, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 37);
            this.label7.TabIndex = 25;
            this.label7.Text = "Thông tin xe";
            // 
            // s_mta
            // 
            this.s_mta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.s_mta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.s_mta.Enabled = false;
            this.s_mta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_mta.Location = new System.Drawing.Point(240, 233);
            this.s_mta.Name = "s_mta";
            this.s_mta.Size = new System.Drawing.Size(350, 26);
            this.s_mta.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(81, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 26);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mô tả xe :";
            // 
            // s_chu
            // 
            this.s_chu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.s_chu.Enabled = false;
            this.s_chu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.s_chu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_chu.FormattingEnabled = true;
            this.s_chu.Location = new System.Drawing.Point(243, 181);
            this.s_chu.Name = "s_chu";
            this.s_chu.Size = new System.Drawing.Size(236, 28);
            this.s_chu.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(81, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "Chủ xe :";
            // 
            // s_loai
            // 
            this.s_loai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.s_loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.s_loai.Enabled = false;
            this.s_loai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.s_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_loai.FormattingEnabled = true;
            this.s_loai.Items.AddRange(new object[] {
            "Xe đạp",
            "Xe máy",
            "Ô tô"});
            this.s_loai.Location = new System.Drawing.Point(243, 125);
            this.s_loai.Name = "s_loai";
            this.s_loai.Size = new System.Drawing.Size(195, 28);
            this.s_loai.TabIndex = 20;
            this.s_loai.SelectedIndexChanged += new System.EventHandler(this.tinhTien);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(81, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 26);
            this.label10.TabIndex = 19;
            this.label10.Text = "Loại xe :";
            // 
            // s_bien
            // 
            this.s_bien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.s_bien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.s_bien.Enabled = false;
            this.s_bien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_bien.Location = new System.Drawing.Point(243, 65);
            this.s_bien.Name = "s_bien";
            this.s_bien.Size = new System.Drawing.Size(195, 26);
            this.s_bien.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(81, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 26);
            this.label13.TabIndex = 17;
            this.label13.Text = "Biển xe :";
            // 
            // chx_huy
            // 
            this.chx_huy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chx_huy.AutoSize = true;
            this.chx_huy.ForeColor = System.Drawing.Color.White;
            this.chx_huy.Location = new System.Drawing.Point(1073, 43);
            this.chx_huy.Name = "chx_huy";
            this.chx_huy.Size = new System.Drawing.Size(45, 17);
            this.chx_huy.TabIndex = 45;
            this.chx_huy.Text = "Hủy";
            this.chx_huy.UseVisualStyleBackColor = true;
            this.chx_huy.CheckedChanged += new System.EventHandler(this.chx_huy_CheckedChanged);
            // 
            // frm_QLVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1254, 671);
            this.Controls.Add(this.pnl_hienThi);
            this.Name = "frm_QLVe";
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
        private System.Windows.Forms.ComboBox cb_BienXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox filter_tt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dt_ngayGui;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox filter_loaiVe;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_timTheo;
        private System.Windows.Forms.TextBox inpt_timKiem;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox s_mta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox s_chu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox s_loai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox s_bien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dt_nGui;
        private System.Windows.Forms.ComboBox cb_tt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_nLay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_gia;
        private System.Windows.Forms.CheckBox chx_huy;
    }
}