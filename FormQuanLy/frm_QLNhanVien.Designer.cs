namespace TT22_QuanLyNhaXe.FormQuanLy
{
    partial class frm_QLNhanVien
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayvao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.inp_mk = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_ngayVao = new System.Windows.Forms.DateTimePicker();
            this.inp_diachi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inp_tennv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inp_sdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.cb_tt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inp_mnv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.filter_nVao = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.inpt_timKiem = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_timTheo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.filter_tt = new System.Windows.Forms.ComboBox();
            this.qLNXDataSet = new TT22_QuanLyNhaXe.QLNXDataSet();
            this.veXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veXeTableAdapter = new TT22_QuanLyNhaXe.QLNXDataSetTableAdapters.VeXeTableAdapter();
            this.chx_huy = new System.Windows.Forms.CheckBox();
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
            this.id,
            this.MaNV,
            this.ten,
            this.diachi,
            this.sdt,
            this.ngayvao,
            this.tt});
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
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // ten
            // 
            this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten.HeaderText = "Tên nhân viên";
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
            // ngayvao
            // 
            this.ngayvao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayvao.HeaderText = "Ngày vào làm";
            this.ngayvao.Name = "ngayvao";
            this.ngayvao.ReadOnly = true;
            // 
            // tt
            // 
            this.tt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tt.HeaderText = "Trạng thái";
            this.tt.Name = "tt";
            this.tt.ReadOnly = true;
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
            this.panel4.Controls.Add(this.inp_mk);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dt_ngayVao);
            this.panel4.Controls.Add(this.inp_diachi);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.inp_tennv);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.inp_sdt);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btn_them);
            this.panel4.Controls.Add(this.btn_xoa);
            this.panel4.Controls.Add(this.btn_sua);
            this.panel4.Controls.Add(this.cb_tt);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.inp_mnv);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1254, 393);
            this.panel4.TabIndex = 4;
            // 
            // inp_mk
            // 
            this.inp_mk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inp_mk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inp_mk.Location = new System.Drawing.Point(761, 276);
            this.inp_mk.Name = "inp_mk";
            this.inp_mk.Size = new System.Drawing.Size(301, 26);
            this.inp_mk.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(599, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 26);
            this.label8.TabIndex = 24;
            this.label8.Text = "Mật khẩu : ";
            // 
            // dt_ngayVao
            // 
            this.dt_ngayVao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_ngayVao.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngayVao.CustomFormat = "dd/MM/yyyy";
            this.dt_ngayVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngayVao.Location = new System.Drawing.Point(660, 112);
            this.dt_ngayVao.Name = "dt_ngayVao";
            this.dt_ngayVao.Size = new System.Drawing.Size(112, 20);
            this.dt_ngayVao.TabIndex = 23;
            // 
            // inp_diachi
            // 
            this.inp_diachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inp_diachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inp_diachi.Location = new System.Drawing.Point(761, 220);
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
            this.label7.Location = new System.Drawing.Point(599, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 21;
            this.label7.Text = "Địa chỉ :";
            // 
            // inp_tennv
            // 
            this.inp_tennv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inp_tennv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_tennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inp_tennv.Location = new System.Drawing.Point(761, 161);
            this.inp_tennv.Name = "inp_tennv";
            this.inp_tennv.Size = new System.Drawing.Size(301, 26);
            this.inp_tennv.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(599, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tên nhân viên :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(498, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày vào làm :";
            // 
            // inp_sdt
            // 
            this.inp_sdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inp_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inp_sdt.Location = new System.Drawing.Point(366, 276);
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
            this.label2.Location = new System.Drawing.Point(204, 276);
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
            this.label1.Location = new System.Drawing.Point(481, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.AutoSize = true;
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_them.Location = new System.Drawing.Point(439, 346);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(133, 32);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm nhân viên";
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
            this.btn_xoa.Location = new System.Drawing.Point(700, 346);
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
            this.btn_sua.Location = new System.Drawing.Point(578, 346);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(116, 32);
            this.btn_sua.TabIndex = 11;
            this.btn_sua.Text = "Sửa thông tin";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // cb_tt
            // 
            this.cb_tt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_tt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tt.FormattingEnabled = true;
            this.cb_tt.Items.AddRange(new object[] {
            "Đang làm",
            "Nghỉ phép",
            "Nghỉ việc"});
            this.cb_tt.Location = new System.Drawing.Point(366, 221);
            this.cb_tt.Name = "cb_tt";
            this.cb_tt.Size = new System.Drawing.Size(195, 28);
            this.cb_tt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(204, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tình trạng :";
            // 
            // inp_mnv
            // 
            this.inp_mnv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inp_mnv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_mnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inp_mnv.Location = new System.Drawing.Point(366, 161);
            this.inp_mnv.Name = "inp_mnv";
            this.inp_mnv.Size = new System.Drawing.Size(195, 26);
            this.inp_mnv.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(204, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã nhân viên :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.chx_huy);
            this.panel5.Controls.Add(this.filter_nVao);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.inpt_timKiem);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.cb_timTheo);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.filter_tt);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 393);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1254, 67);
            this.panel5.TabIndex = 3;
            // 
            // filter_nVao
            // 
            this.filter_nVao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.filter_nVao.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_nVao.CustomFormat = "dd/MM/yyyy";
            this.filter_nVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.filter_nVao.Location = new System.Drawing.Point(875, 36);
            this.filter_nVao.Name = "filter_nVao";
            this.filter_nVao.Size = new System.Drawing.Size(112, 20);
            this.filter_nVao.TabIndex = 23;
            this.filter_nVao.ValueChanged += new System.EventHandler(this.locDL);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(871, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Ngày vào làm";
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
            "Mã nhân viên",
            "Tên nhân viên",
            "Địa chỉ",
            "Số điện thoại"});
            this.cb_timTheo.Location = new System.Drawing.Point(12, 33);
            this.cb_timTheo.Name = "cb_timTheo";
            this.cb_timTheo.Size = new System.Drawing.Size(107, 28);
            this.cb_timTheo.TabIndex = 20;
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
            "Đang làm",
            "Nghỉ phép",
            "Nghỉ việc"});
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
            // chx_huy
            // 
            this.chx_huy.AutoSize = true;
            this.chx_huy.ForeColor = System.Drawing.Color.White;
            this.chx_huy.Location = new System.Drawing.Point(993, 39);
            this.chx_huy.Name = "chx_huy";
            this.chx_huy.Size = new System.Drawing.Size(45, 17);
            this.chx_huy.TabIndex = 44;
            this.chx_huy.Text = "Hủy";
            this.chx_huy.UseVisualStyleBackColor = true;
            this.chx_huy.CheckedChanged += new System.EventHandler(this.chx_huy_CheckedChanged);
            // 
            // frm_QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1254, 671);
            this.Controls.Add(this.pnl_hienThi);
            this.Name = "frm_QLNhanVien";
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
        private System.Windows.Forms.TextBox inp_mnv;
        private System.Windows.Forms.ComboBox cb_tt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox filter_tt;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.TextBox inp_tennv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inp_sdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_ngayVao;
        private System.Windows.Forms.DateTimePicker filter_nVao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayvao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.TextBox inp_mk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chx_huy;
    }
}