namespace QuanLyThuVien
{
    partial class frmChiTietNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietNhanVien));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dateTimePickerNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmai = new ThuVienControl.txtEmail();
            this.txtCMND = new ThuVienControl.txtSo();
            this.txtSoDT = new ThuVienControl.txtSo();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.pnNhapTT = new System.Windows.Forms.Panel();
            this.btnLuu = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSua = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNgung = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            this.pnNhapTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerNgayLap
            // 
            this.dateTimePickerNgayLap.CalendarForeColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNgayLap.CalendarMonthBackground = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNgayLap.CalendarTitleBackColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNgayLap.CalendarTitleForeColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNgayLap.CalendarTrailingForeColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayLap.Location = new System.Drawing.Point(191, 284);
            this.dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            this.dateTimePickerNgayLap.Size = new System.Drawing.Size(303, 33);
            this.dateTimePickerNgayLap.TabIndex = 55;
            this.dateTimePickerNgayLap.Value = new System.DateTime(2021, 1, 27, 0, 0, 0, 0);
            this.dateTimePickerNgayLap.ValueChanged += new System.EventHandler(this.dateTimePickerNgayLap_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 33);
            this.label1.TabIndex = 54;
            this.label1.Text = "Ngày Vào Làm:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmai
            // 
            this.txtEmai.Enabled = false;
            this.txtEmai.ForeColor = System.Drawing.Color.Black;
            this.txtEmai.Location = new System.Drawing.Point(191, 125);
            this.txtEmai.Name = "txtEmai";
            this.txtEmai.Size = new System.Drawing.Size(303, 33);
            this.txtEmai.TabIndex = 49;
            this.txtEmai.TextChanged += new System.EventHandler(this.txtEmai_TextChanged);
            // 
            // txtCMND
            // 
            this.txtCMND.ForeColor = System.Drawing.Color.Black;
            this.txtCMND.Location = new System.Drawing.Point(191, 47);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(303, 33);
            this.txtCMND.TabIndex = 48;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            // 
            // txtSoDT
            // 
            this.txtSoDT.ForeColor = System.Drawing.Color.Black;
            this.txtSoDT.Location = new System.Drawing.Point(191, 86);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(303, 33);
            this.txtSoDT.TabIndex = 47;
            this.txtSoDT.TextChanged += new System.EventHandler(this.txtSoDT_TextChanged);
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.CalendarForeColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNgaySinh.CalendarMonthBackground = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNgaySinh.CalendarTitleBackColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNgaySinh.CalendarTitleForeColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNgaySinh.CalendarTrailingForeColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(191, 203);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(303, 33);
            this.dateTimePickerNgaySinh.TabIndex = 46;
            this.dateTimePickerNgaySinh.Value = new System.DateTime(2021, 1, 27, 0, 0, 0, 0);
            this.dateTimePickerNgaySinh.ValueChanged += new System.EventHandler(this.dateTimePickerNgaySinh_ValueChanged);
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lbGioiTinh.Location = new System.Drawing.Point(11, 242);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(174, 33);
            this.lbGioiTinh.TabIndex = 42;
            this.lbGioiTinh.Text = "Giới Tính:";
            this.lbGioiTinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbGioiTinh.Click += new System.EventHandler(this.lbGioiTinh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoNam);
            this.panel1.Controls.Add(this.rdoNu);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(191, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 33);
            this.panel1.TabIndex = 41;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Location = new System.Drawing.Point(3, 3);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(85, 33);
            this.rdoNam.TabIndex = 40;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            this.rdoNam.CheckedChanged += new System.EventHandler(this.rdoNam_CheckedChanged);
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(125, 3);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(65, 33);
            this.rdoNu.TabIndex = 39;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            this.rdoNu.CheckedChanged += new System.EventHandler(this.rdoNu_CheckedChanged);
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lbDiaChi.Location = new System.Drawing.Point(11, 164);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(174, 33);
            this.lbDiaChi.TabIndex = 37;
            this.lbDiaChi.Text = "Địa Chỉ:";
            this.lbDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDiaChi.Click += new System.EventHandler(this.lbDiaChi_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(191, 164);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(303, 33);
            this.txtDiaChi.TabIndex = 38;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Black;
            this.lbEmail.Location = new System.Drawing.Point(11, 125);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(174, 33);
            this.lbEmail.TabIndex = 35;
            this.lbEmail.Text = "Email:";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbEmail.Click += new System.EventHandler(this.lbEmail_Click);
            // 
            // lbSDT
            // 
            this.lbSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.ForeColor = System.Drawing.Color.Black;
            this.lbSDT.Location = new System.Drawing.Point(11, 86);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(174, 33);
            this.lbSDT.TabIndex = 33;
            this.lbSDT.Text = "Số Điện Thoại:";
            this.lbSDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbSDT.Click += new System.EventHandler(this.lbSDT_Click);
            // 
            // lbCMND
            // 
            this.lbCMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMND.ForeColor = System.Drawing.Color.Black;
            this.lbCMND.Location = new System.Drawing.Point(11, 47);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(174, 33);
            this.lbCMND.TabIndex = 31;
            this.lbCMND.Text = "CMND:";
            this.lbCMND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCMND.Click += new System.EventHandler(this.lbCMND_Click);
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.lbNgaySinh.Location = new System.Drawing.Point(11, 203);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(174, 33);
            this.lbNgaySinh.TabIndex = 29;
            this.lbNgaySinh.Text = "Ngày Sinh:";
            this.lbNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNgaySinh.Click += new System.EventHandler(this.lbNgaySinh_Click);
            // 
            // lbHoTen
            // 
            this.lbHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.ForeColor = System.Drawing.Color.Black;
            this.lbHoTen.Location = new System.Drawing.Point(11, 8);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(174, 33);
            this.lbHoTen.TabIndex = 5;
            this.lbHoTen.Text = "Họ Tên:";
            this.lbHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHoTen.Click += new System.EventHandler(this.lbHoTen_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(191, 8);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(303, 33);
            this.txtHoTen.TabIndex = 11;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // pnNhapTT
            // 
            this.pnNhapTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnNhapTT.Controls.Add(this.btnLuu);
            this.pnNhapTT.Controls.Add(this.btnSua);
            this.pnNhapTT.Controls.Add(this.btnNgung);
            this.pnNhapTT.Controls.Add(this.dateTimePickerNgayLap);
            this.pnNhapTT.Controls.Add(this.label1);
            this.pnNhapTT.Controls.Add(this.txtEmai);
            this.pnNhapTT.Controls.Add(this.txtCMND);
            this.pnNhapTT.Controls.Add(this.txtSoDT);
            this.pnNhapTT.Controls.Add(this.dateTimePickerNgaySinh);
            this.pnNhapTT.Controls.Add(this.lbGioiTinh);
            this.pnNhapTT.Controls.Add(this.panel1);
            this.pnNhapTT.Controls.Add(this.lbDiaChi);
            this.pnNhapTT.Controls.Add(this.txtDiaChi);
            this.pnNhapTT.Controls.Add(this.lbEmail);
            this.pnNhapTT.Controls.Add(this.lbSDT);
            this.pnNhapTT.Controls.Add(this.lbCMND);
            this.pnNhapTT.Controls.Add(this.lbNgaySinh);
            this.pnNhapTT.Controls.Add(this.lbHoTen);
            this.pnNhapTT.Controls.Add(this.txtHoTen);
            this.pnNhapTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNhapTT.Location = new System.Drawing.Point(0, 0);
            this.pnNhapTT.Name = "pnNhapTT";
            this.pnNhapTT.Size = new System.Drawing.Size(530, 393);
            this.pnNhapTT.TabIndex = 31;
            this.pnNhapTT.Paint += new System.Windows.Forms.PaintEventHandler(this.pnNhapTT_Paint);
            // 
            // btnLuu
            // 
            this.btnLuu.AllowAnimations = true;
            this.btnLuu.AllowMouseEffects = true;
            this.btnLuu.AllowToggling = false;
            this.btnLuu.AnimationSpeed = 200;
            this.btnLuu.AutoGenerateColors = false;
            this.btnLuu.AutoRoundBorders = false;
            this.btnLuu.AutoSizeLeftIcon = true;
            this.btnLuu.AutoSizeRightIcon = true;
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLuu.ButtonText = "Lưu";
            this.btnLuu.ButtonTextMarginLeft = 0;
            this.btnLuu.ColorContrastOnClick = 45;
            this.btnLuu.ColorContrastOnHover = 45;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLuu.CustomizableEdges = borderEdges1;
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLuu.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLuu.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLuu.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLuu.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLuu.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLuu.IconMarginLeft = 11;
            this.btnLuu.IconPadding = 10;
            this.btnLuu.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLuu.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLuu.IconSize = 25;
            this.btnLuu.IdleBorderColor = System.Drawing.Color.White;
            this.btnLuu.IdleBorderRadius = 30;
            this.btnLuu.IdleBorderThickness = 1;
            this.btnLuu.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.IdleIconLeftImage = null;
            this.btnLuu.IdleIconRightImage = null;
            this.btnLuu.IndicateFocus = false;
            this.btnLuu.Location = new System.Drawing.Point(370, 323);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLuu.OnDisabledState.BorderRadius = 30;
            this.btnLuu.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLuu.OnDisabledState.BorderThickness = 1;
            this.btnLuu.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLuu.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLuu.OnDisabledState.IconLeftImage = null;
            this.btnLuu.OnDisabledState.IconRightImage = null;
            this.btnLuu.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLuu.onHoverState.BorderRadius = 30;
            this.btnLuu.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLuu.onHoverState.BorderThickness = 1;
            this.btnLuu.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLuu.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLuu.onHoverState.IconLeftImage = null;
            this.btnLuu.onHoverState.IconRightImage = null;
            this.btnLuu.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnLuu.OnIdleState.BorderRadius = 30;
            this.btnLuu.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLuu.OnIdleState.BorderThickness = 1;
            this.btnLuu.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLuu.OnIdleState.IconLeftImage = null;
            this.btnLuu.OnIdleState.IconRightImage = null;
            this.btnLuu.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.OnPressedState.BorderRadius = 30;
            this.btnLuu.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLuu.OnPressedState.BorderThickness = 1;
            this.btnLuu.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLuu.OnPressedState.IconLeftImage = null;
            this.btnLuu.OnPressedState.IconRightImage = null;
            this.btnLuu.Size = new System.Drawing.Size(124, 41);
            this.btnLuu.TabIndex = 73;
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLuu.TextMarginLeft = 0;
            this.btnLuu.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLuu.UseDefaultRadiusAndThickness = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.AllowAnimations = true;
            this.btnSua.AllowMouseEffects = true;
            this.btnSua.AllowToggling = false;
            this.btnSua.AnimationSpeed = 200;
            this.btnSua.AutoGenerateColors = false;
            this.btnSua.AutoRoundBorders = false;
            this.btnSua.AutoSizeLeftIcon = true;
            this.btnSua.AutoSizeRightIcon = true;
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.ButtonTextMarginLeft = 0;
            this.btnSua.ColorContrastOnClick = 45;
            this.btnSua.ColorContrastOnHover = 45;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSua.CustomizableEdges = borderEdges2;
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSua.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSua.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSua.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSua.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSua.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSua.IconMarginLeft = 11;
            this.btnSua.IconPadding = 10;
            this.btnSua.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSua.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSua.IconSize = 25;
            this.btnSua.IdleBorderColor = System.Drawing.Color.White;
            this.btnSua.IdleBorderRadius = 30;
            this.btnSua.IdleBorderThickness = 1;
            this.btnSua.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.IdleIconLeftImage = null;
            this.btnSua.IdleIconRightImage = null;
            this.btnSua.IndicateFocus = false;
            this.btnSua.Location = new System.Drawing.Point(228, 323);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSua.OnDisabledState.BorderRadius = 30;
            this.btnSua.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSua.OnDisabledState.BorderThickness = 1;
            this.btnSua.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSua.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSua.OnDisabledState.IconLeftImage = null;
            this.btnSua.OnDisabledState.IconRightImage = null;
            this.btnSua.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSua.onHoverState.BorderRadius = 30;
            this.btnSua.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSua.onHoverState.BorderThickness = 1;
            this.btnSua.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSua.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSua.onHoverState.IconLeftImage = null;
            this.btnSua.onHoverState.IconRightImage = null;
            this.btnSua.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnSua.OnIdleState.BorderRadius = 30;
            this.btnSua.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSua.OnIdleState.BorderThickness = 1;
            this.btnSua.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSua.OnIdleState.IconLeftImage = null;
            this.btnSua.OnIdleState.IconRightImage = null;
            this.btnSua.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.OnPressedState.BorderRadius = 30;
            this.btnSua.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSua.OnPressedState.BorderThickness = 1;
            this.btnSua.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSua.OnPressedState.IconLeftImage = null;
            this.btnSua.OnPressedState.IconRightImage = null;
            this.btnSua.Size = new System.Drawing.Size(136, 41);
            this.btnSua.TabIndex = 72;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSua.TextMarginLeft = 0;
            this.btnSua.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSua.UseDefaultRadiusAndThickness = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnNgung
            // 
            this.btnNgung.AllowAnimations = true;
            this.btnNgung.AllowMouseEffects = true;
            this.btnNgung.AllowToggling = false;
            this.btnNgung.AnimationSpeed = 200;
            this.btnNgung.AutoGenerateColors = false;
            this.btnNgung.AutoRoundBorders = false;
            this.btnNgung.AutoSizeLeftIcon = true;
            this.btnNgung.AutoSizeRightIcon = true;
            this.btnNgung.BackColor = System.Drawing.Color.Transparent;
            this.btnNgung.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnNgung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNgung.BackgroundImage")));
            this.btnNgung.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNgung.ButtonText = "Ngừng Hoạt Động";
            this.btnNgung.ButtonTextMarginLeft = 0;
            this.btnNgung.ColorContrastOnClick = 45;
            this.btnNgung.ColorContrastOnHover = 45;
            this.btnNgung.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnNgung.CustomizableEdges = borderEdges3;
            this.btnNgung.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNgung.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNgung.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNgung.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNgung.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNgung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnNgung.ForeColor = System.Drawing.Color.White;
            this.btnNgung.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNgung.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNgung.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNgung.IconMarginLeft = 11;
            this.btnNgung.IconPadding = 10;
            this.btnNgung.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNgung.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNgung.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNgung.IconSize = 25;
            this.btnNgung.IdleBorderColor = System.Drawing.Color.White;
            this.btnNgung.IdleBorderRadius = 30;
            this.btnNgung.IdleBorderThickness = 1;
            this.btnNgung.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnNgung.IdleIconLeftImage = null;
            this.btnNgung.IdleIconRightImage = null;
            this.btnNgung.IndicateFocus = false;
            this.btnNgung.Location = new System.Drawing.Point(16, 323);
            this.btnNgung.Name = "btnNgung";
            this.btnNgung.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNgung.OnDisabledState.BorderRadius = 30;
            this.btnNgung.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNgung.OnDisabledState.BorderThickness = 1;
            this.btnNgung.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNgung.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNgung.OnDisabledState.IconLeftImage = null;
            this.btnNgung.OnDisabledState.IconRightImage = null;
            this.btnNgung.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNgung.onHoverState.BorderRadius = 30;
            this.btnNgung.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNgung.onHoverState.BorderThickness = 1;
            this.btnNgung.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNgung.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNgung.onHoverState.IconLeftImage = null;
            this.btnNgung.onHoverState.IconRightImage = null;
            this.btnNgung.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnNgung.OnIdleState.BorderRadius = 30;
            this.btnNgung.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNgung.OnIdleState.BorderThickness = 1;
            this.btnNgung.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnNgung.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNgung.OnIdleState.IconLeftImage = null;
            this.btnNgung.OnIdleState.IconRightImage = null;
            this.btnNgung.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNgung.OnPressedState.BorderRadius = 30;
            this.btnNgung.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNgung.OnPressedState.BorderThickness = 1;
            this.btnNgung.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnNgung.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNgung.OnPressedState.IconLeftImage = null;
            this.btnNgung.OnPressedState.IconRightImage = null;
            this.btnNgung.Size = new System.Drawing.Size(206, 41);
            this.btnNgung.TabIndex = 71;
            this.btnNgung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNgung.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNgung.TextMarginLeft = 0;
            this.btnNgung.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNgung.UseDefaultRadiusAndThickness = true;
            this.btnNgung.Click += new System.EventHandler(this.btnNgung_Click);
            // 
            // frmChiTietNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 393);
            this.Controls.Add(this.pnNhapTT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 445);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 445);
            this.Name = "frmChiTietNhanVien";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Nhân Viên";
            this.Load += new System.EventHandler(this.frmChiTietNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnNhapTT.ResumeLayout(false);
            this.pnNhapTT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLuu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSua;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNgung;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLap;
        private System.Windows.Forms.Label label1;
        private ThuVienControl.txtEmail txtEmai;
        private ThuVienControl.txtSo txtCMND;
        private ThuVienControl.txtSo txtSoDT;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Panel pnNhapTT;
    }
}