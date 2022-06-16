namespace QuanLyThuVien
{
    partial class frmChoMuonSach
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoMuonSach));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.picAnhSach = new System.Windows.Forms.PictureBox();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.lbHanSD = new System.Windows.Forms.Label();
            this.lbMaSoThe = new System.Windows.Forms.Label();
            this.txtMaSoThe = new System.Windows.Forms.TextBox();
            this.txtSoDT = new ThuVienControl.txtSo();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txtHoTenDG = new System.Windows.Forms.TextBox();
            this.picAnhDG = new System.Windows.Forms.PictureBox();
            this.lbTacGia = new System.Windows.Forms.Label();
            this.grpBoxTTSach = new System.Windows.Forms.GroupBox();
            this.pnDG = new System.Windows.Forms.Panel();
            this.txtEmai = new ThuVienControl.txtSo();
            this.lbTienTheChan = new System.Windows.Forms.Label();
            this.txtTienTheChan = new ThuVienControl.txtSo();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.grpBoxSach = new System.Windows.Forms.GroupBox();
            this.pnSach = new System.Windows.Forms.Panel();
            this.txtSoLuongSachCon = new System.Windows.Forms.TextBox();
            this.lbSLKho = new System.Windows.Forms.Label();
            this.lbSoLuongMuon = new System.Windows.Forms.Label();
            this.txtSoLuongMuon = new ThuVienControl.txtSo();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.btnTim = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnXacNhan = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDG)).BeginInit();
            this.grpBoxTTSach.SuspendLayout();
            this.pnDG.SuspendLayout();
            this.grpBoxSach.SuspendLayout();
            this.pnSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // picAnhSach
            // 
            this.picAnhSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhSach.Location = new System.Drawing.Point(36, 43);
            this.picAnhSach.Name = "picAnhSach";
            this.picAnhSach.Size = new System.Drawing.Size(210, 210);
            this.picAnhSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhSach.TabIndex = 54;
            this.picAnhSach.TabStop = false;
            // 
            // lbTenSach
            // 
            this.lbTenSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSach.Location = new System.Drawing.Point(38, 265);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(303, 33);
            this.lbTenSach.TabIndex = 55;
            this.lbTenSach.Text = "Tên Sách:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Enabled = false;
            this.txtTenSach.ForeColor = System.Drawing.Color.Black;
            this.txtTenSach.Location = new System.Drawing.Point(38, 299);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(304, 33);
            this.txtTenSach.TabIndex = 56;
            // 
            // dateTimePickerNgayHetHan
            // 
            this.dateTimePickerNgayHetHan.CalendarForeColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNgayHetHan.CalendarMonthBackground = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNgayHetHan.CalendarTitleBackColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNgayHetHan.CalendarTitleForeColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNgayHetHan.CalendarTrailingForeColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNgayHetHan.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayHetHan.Enabled = false;
            this.dateTimePickerNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayHetHan.Location = new System.Drawing.Point(284, 145);
            this.dateTimePickerNgayHetHan.Name = "dateTimePickerNgayHetHan";
            this.dateTimePickerNgayHetHan.Size = new System.Drawing.Size(303, 33);
            this.dateTimePickerNgayHetHan.TabIndex = 68;
            this.dateTimePickerNgayHetHan.Value = new System.DateTime(2023, 1, 27, 0, 0, 0, 0);
            // 
            // lbHanSD
            // 
            this.lbHanSD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHanSD.Location = new System.Drawing.Point(284, 111);
            this.lbHanSD.Name = "lbHanSD";
            this.lbHanSD.Size = new System.Drawing.Size(303, 33);
            this.lbHanSD.TabIndex = 67;
            this.lbHanSD.Text = "Hạn Sử Dụng:";
            // 
            // lbMaSoThe
            // 
            this.lbMaSoThe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSoThe.Location = new System.Drawing.Point(284, 43);
            this.lbMaSoThe.Name = "lbMaSoThe";
            this.lbMaSoThe.Size = new System.Drawing.Size(303, 33);
            this.lbMaSoThe.TabIndex = 65;
            this.lbMaSoThe.Text = "Mã Số Thẻ:";
            // 
            // txtMaSoThe
            // 
            this.txtMaSoThe.Enabled = false;
            this.txtMaSoThe.ForeColor = System.Drawing.Color.Black;
            this.txtMaSoThe.Location = new System.Drawing.Point(284, 77);
            this.txtMaSoThe.Name = "txtMaSoThe";
            this.txtMaSoThe.Size = new System.Drawing.Size(303, 33);
            this.txtMaSoThe.TabIndex = 66;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Enabled = false;
            this.txtSoDT.ForeColor = System.Drawing.Color.Black;
            this.txtSoDT.Location = new System.Drawing.Point(284, 281);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(303, 33);
            this.txtSoDT.TabIndex = 63;
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(284, 315);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(303, 33);
            this.lbEmail.TabIndex = 62;
            this.lbEmail.Text = "Email:";
            // 
            // lbSDT
            // 
            this.lbSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(284, 247);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(303, 33);
            this.lbSDT.TabIndex = 61;
            this.lbSDT.Text = "Số Điện Thoại:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(284, 179);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(303, 33);
            this.lbHoTen.TabIndex = 58;
            this.lbHoTen.Text = "Họ Tên:";
            // 
            // txtHoTenDG
            // 
            this.txtHoTenDG.Enabled = false;
            this.txtHoTenDG.ForeColor = System.Drawing.Color.Black;
            this.txtHoTenDG.Location = new System.Drawing.Point(284, 213);
            this.txtHoTenDG.Name = "txtHoTenDG";
            this.txtHoTenDG.Size = new System.Drawing.Size(303, 33);
            this.txtHoTenDG.TabIndex = 59;
            // 
            // picAnhDG
            // 
            this.picAnhDG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhDG.Location = new System.Drawing.Point(49, 43);
            this.picAnhDG.Name = "picAnhDG";
            this.picAnhDG.Size = new System.Drawing.Size(210, 210);
            this.picAnhDG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhDG.TabIndex = 60;
            this.picAnhDG.TabStop = false;
            // 
            // lbTacGia
            // 
            this.lbTacGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTacGia.Location = new System.Drawing.Point(38, 333);
            this.lbTacGia.Name = "lbTacGia";
            this.lbTacGia.Size = new System.Drawing.Size(303, 33);
            this.lbTacGia.TabIndex = 69;
            this.lbTacGia.Text = "Tên Tác Giả:";
            // 
            // grpBoxTTSach
            // 
            this.grpBoxTTSach.Controls.Add(this.pnDG);
            this.grpBoxTTSach.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpBoxTTSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTTSach.ForeColor = System.Drawing.Color.Black;
            this.grpBoxTTSach.Location = new System.Drawing.Point(358, 0);
            this.grpBoxTTSach.Name = "grpBoxTTSach";
            this.grpBoxTTSach.Size = new System.Drawing.Size(665, 591);
            this.grpBoxTTSach.TabIndex = 71;
            this.grpBoxTTSach.TabStop = false;
            this.grpBoxTTSach.Text = "Độc Giả";
            // 
            // pnDG
            // 
            this.pnDG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDG.Controls.Add(this.btnXacNhan);
            this.pnDG.Controls.Add(this.btnTim);
            this.pnDG.Controls.Add(this.txtEmai);
            this.pnDG.Controls.Add(this.lbTienTheChan);
            this.pnDG.Controls.Add(this.txtTienTheChan);
            this.pnDG.Controls.Add(this.txtTim);
            this.pnDG.Controls.Add(this.picAnhDG);
            this.pnDG.Controls.Add(this.txtHoTenDG);
            this.pnDG.Controls.Add(this.dateTimePickerNgayHetHan);
            this.pnDG.Controls.Add(this.lbHoTen);
            this.pnDG.Controls.Add(this.lbHanSD);
            this.pnDG.Controls.Add(this.lbSDT);
            this.pnDG.Controls.Add(this.lbMaSoThe);
            this.pnDG.Controls.Add(this.lbEmail);
            this.pnDG.Controls.Add(this.txtMaSoThe);
            this.pnDG.Controls.Add(this.txtSoDT);
            this.pnDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDG.Location = new System.Drawing.Point(3, 29);
            this.pnDG.Name = "pnDG";
            this.pnDG.Size = new System.Drawing.Size(659, 559);
            this.pnDG.TabIndex = 29;
            // 
            // txtEmai
            // 
            this.txtEmai.Enabled = false;
            this.txtEmai.ForeColor = System.Drawing.Color.Black;
            this.txtEmai.Location = new System.Drawing.Point(284, 349);
            this.txtEmai.Name = "txtEmai";
            this.txtEmai.Size = new System.Drawing.Size(303, 33);
            this.txtEmai.TabIndex = 74;
            // 
            // lbTienTheChan
            // 
            this.lbTienTheChan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienTheChan.Location = new System.Drawing.Point(284, 385);
            this.lbTienTheChan.Name = "lbTienTheChan";
            this.lbTienTheChan.Size = new System.Drawing.Size(303, 33);
            this.lbTienTheChan.TabIndex = 72;
            this.lbTienTheChan.Text = "Tiền Thế Chân:";
            // 
            // txtTienTheChan
            // 
            this.txtTienTheChan.ForeColor = System.Drawing.Color.Black;
            this.txtTienTheChan.Location = new System.Drawing.Point(284, 419);
            this.txtTienTheChan.Name = "txtTienTheChan";
            this.txtTienTheChan.Size = new System.Drawing.Size(303, 33);
            this.txtTienTheChan.TabIndex = 73;
            this.txtTienTheChan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTim
            // 
            this.txtTim.BackColor = System.Drawing.Color.White;
            this.txtTim.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtTim.Location = new System.Drawing.Point(49, 3);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(229, 33);
            this.txtTim.TabIndex = 69;
            // 
            // grpBoxSach
            // 
            this.grpBoxSach.Controls.Add(this.pnSach);
            this.grpBoxSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxSach.ForeColor = System.Drawing.Color.Black;
            this.grpBoxSach.Location = new System.Drawing.Point(0, 0);
            this.grpBoxSach.Name = "grpBoxSach";
            this.grpBoxSach.Size = new System.Drawing.Size(358, 591);
            this.grpBoxSach.TabIndex = 72;
            this.grpBoxSach.TabStop = false;
            this.grpBoxSach.Text = "Sách";
            // 
            // pnSach
            // 
            this.pnSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSach.Controls.Add(this.txtSoLuongSachCon);
            this.pnSach.Controls.Add(this.lbSLKho);
            this.pnSach.Controls.Add(this.lbSoLuongMuon);
            this.pnSach.Controls.Add(this.txtSoLuongMuon);
            this.pnSach.Controls.Add(this.txtTenTacGia);
            this.pnSach.Controls.Add(this.picAnhSach);
            this.pnSach.Controls.Add(this.txtTenSach);
            this.pnSach.Controls.Add(this.lbTacGia);
            this.pnSach.Controls.Add(this.lbTenSach);
            this.pnSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSach.Location = new System.Drawing.Point(3, 29);
            this.pnSach.Name = "pnSach";
            this.pnSach.Size = new System.Drawing.Size(352, 559);
            this.pnSach.TabIndex = 29;
            // 
            // txtSoLuongSachCon
            // 
            this.txtSoLuongSachCon.Enabled = false;
            this.txtSoLuongSachCon.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuongSachCon.Location = new System.Drawing.Point(38, 435);
            this.txtSoLuongSachCon.Name = "txtSoLuongSachCon";
            this.txtSoLuongSachCon.Size = new System.Drawing.Size(304, 33);
            this.txtSoLuongSachCon.TabIndex = 74;
            this.txtSoLuongSachCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbSLKho
            // 
            this.lbSLKho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLKho.Location = new System.Drawing.Point(38, 401);
            this.lbSLKho.Name = "lbSLKho";
            this.lbSLKho.Size = new System.Drawing.Size(303, 33);
            this.lbSLKho.TabIndex = 73;
            this.lbSLKho.Text = "Số Lượng Sách Còn:";
            // 
            // lbSoLuongMuon
            // 
            this.lbSoLuongMuon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongMuon.Location = new System.Drawing.Point(38, 469);
            this.lbSoLuongMuon.Name = "lbSoLuongMuon";
            this.lbSoLuongMuon.Size = new System.Drawing.Size(303, 33);
            this.lbSoLuongMuon.TabIndex = 71;
            this.lbSoLuongMuon.Text = "Số Lượng Mượn:";
            // 
            // txtSoLuongMuon
            // 
            this.txtSoLuongMuon.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuongMuon.Location = new System.Drawing.Point(38, 503);
            this.txtSoLuongMuon.Name = "txtSoLuongMuon";
            this.txtSoLuongMuon.Size = new System.Drawing.Size(303, 33);
            this.txtSoLuongMuon.TabIndex = 72;
            this.txtSoLuongMuon.Text = "1";
            this.txtSoLuongMuon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.Enabled = false;
            this.txtTenTacGia.ForeColor = System.Drawing.Color.Black;
            this.txtTenTacGia.Location = new System.Drawing.Point(38, 367);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(304, 33);
            this.txtTenTacGia.TabIndex = 70;
            // 
            // btnTim
            // 
            this.btnTim.AllowAnimations = true;
            this.btnTim.AllowMouseEffects = true;
            this.btnTim.AllowToggling = false;
            this.btnTim.AnimationSpeed = 200;
            this.btnTim.AutoGenerateColors = false;
            this.btnTim.AutoRoundBorders = false;
            this.btnTim.AutoSizeLeftIcon = true;
            this.btnTim.AutoSizeRightIcon = true;
            this.btnTim.BackColor = System.Drawing.Color.Transparent;
            this.btnTim.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnTim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTim.BackgroundImage")));
            this.btnTim.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTim.ButtonText = "Tìm";
            this.btnTim.ButtonTextMarginLeft = 0;
            this.btnTim.ColorContrastOnClick = 45;
            this.btnTim.ColorContrastOnHover = 45;
            this.btnTim.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnTim.CustomizableEdges = borderEdges2;
            this.btnTim.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTim.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTim.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTim.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTim.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTim.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTim.IconMarginLeft = 11;
            this.btnTim.IconPadding = 10;
            this.btnTim.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTim.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTim.IconSize = 25;
            this.btnTim.IdleBorderColor = System.Drawing.Color.White;
            this.btnTim.IdleBorderRadius = 30;
            this.btnTim.IdleBorderThickness = 1;
            this.btnTim.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnTim.IdleIconLeftImage = null;
            this.btnTim.IdleIconRightImage = null;
            this.btnTim.IndicateFocus = false;
            this.btnTim.Location = new System.Drawing.Point(289, 3);
            this.btnTim.Name = "btnTim";
            this.btnTim.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTim.OnDisabledState.BorderRadius = 30;
            this.btnTim.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTim.OnDisabledState.BorderThickness = 1;
            this.btnTim.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTim.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTim.OnDisabledState.IconLeftImage = null;
            this.btnTim.OnDisabledState.IconRightImage = null;
            this.btnTim.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnTim.onHoverState.BorderRadius = 30;
            this.btnTim.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTim.onHoverState.BorderThickness = 1;
            this.btnTim.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnTim.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnTim.onHoverState.IconLeftImage = null;
            this.btnTim.onHoverState.IconRightImage = null;
            this.btnTim.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnTim.OnIdleState.BorderRadius = 30;
            this.btnTim.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTim.OnIdleState.BorderThickness = 1;
            this.btnTim.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnTim.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTim.OnIdleState.IconLeftImage = null;
            this.btnTim.OnIdleState.IconRightImage = null;
            this.btnTim.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTim.OnPressedState.BorderRadius = 30;
            this.btnTim.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTim.OnPressedState.BorderThickness = 1;
            this.btnTim.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnTim.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTim.OnPressedState.IconLeftImage = null;
            this.btnTim.OnPressedState.IconRightImage = null;
            this.btnTim.Size = new System.Drawing.Size(115, 33);
            this.btnTim.TabIndex = 75;
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTim.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTim.TextMarginLeft = 0;
            this.btnTim.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTim.UseDefaultRadiusAndThickness = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.AllowAnimations = true;
            this.btnXacNhan.AllowMouseEffects = true;
            this.btnXacNhan.AllowToggling = false;
            this.btnXacNhan.AnimationSpeed = 200;
            this.btnXacNhan.AutoGenerateColors = false;
            this.btnXacNhan.AutoRoundBorders = false;
            this.btnXacNhan.AutoSizeLeftIcon = true;
            this.btnXacNhan.AutoSizeRightIcon = true;
            this.btnXacNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnXacNhan.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.BackgroundImage")));
            this.btnXacNhan.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXacNhan.ButtonText = "Xác Nhận";
            this.btnXacNhan.ButtonTextMarginLeft = 0;
            this.btnXacNhan.ColorContrastOnClick = 45;
            this.btnXacNhan.ColorContrastOnHover = 45;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnXacNhan.CustomizableEdges = borderEdges1;
            this.btnXacNhan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXacNhan.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXacNhan.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXacNhan.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXacNhan.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhan.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnXacNhan.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnXacNhan.IconMarginLeft = 11;
            this.btnXacNhan.IconPadding = 10;
            this.btnXacNhan.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhan.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnXacNhan.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnXacNhan.IconSize = 25;
            this.btnXacNhan.IdleBorderColor = System.Drawing.Color.White;
            this.btnXacNhan.IdleBorderRadius = 30;
            this.btnXacNhan.IdleBorderThickness = 1;
            this.btnXacNhan.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.IdleIconLeftImage = null;
            this.btnXacNhan.IdleIconRightImage = null;
            this.btnXacNhan.IndicateFocus = false;
            this.btnXacNhan.Location = new System.Drawing.Point(445, 461);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXacNhan.OnDisabledState.BorderRadius = 30;
            this.btnXacNhan.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXacNhan.OnDisabledState.BorderThickness = 1;
            this.btnXacNhan.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXacNhan.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXacNhan.OnDisabledState.IconLeftImage = null;
            this.btnXacNhan.OnDisabledState.IconRightImage = null;
            this.btnXacNhan.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXacNhan.onHoverState.BorderRadius = 30;
            this.btnXacNhan.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXacNhan.onHoverState.BorderThickness = 1;
            this.btnXacNhan.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXacNhan.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.onHoverState.IconLeftImage = null;
            this.btnXacNhan.onHoverState.IconRightImage = null;
            this.btnXacNhan.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnXacNhan.OnIdleState.BorderRadius = 30;
            this.btnXacNhan.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXacNhan.OnIdleState.BorderThickness = 1;
            this.btnXacNhan.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.OnIdleState.IconLeftImage = null;
            this.btnXacNhan.OnIdleState.IconRightImage = null;
            this.btnXacNhan.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.OnPressedState.BorderRadius = 30;
            this.btnXacNhan.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXacNhan.OnPressedState.BorderThickness = 1;
            this.btnXacNhan.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.OnPressedState.IconLeftImage = null;
            this.btnXacNhan.OnPressedState.IconRightImage = null;
            this.btnXacNhan.Size = new System.Drawing.Size(142, 41);
            this.btnXacNhan.TabIndex = 76;
            this.btnXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXacNhan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXacNhan.TextMarginLeft = 0;
            this.btnXacNhan.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXacNhan.UseDefaultRadiusAndThickness = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // frmChoMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 591);
            this.Controls.Add(this.grpBoxSach);
            this.Controls.Add(this.grpBoxTTSach);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmChoMuonSach";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Mượn Sách";
            this.Load += new System.EventHandler(this.frmChoMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDG)).EndInit();
            this.grpBoxTTSach.ResumeLayout(false);
            this.pnDG.ResumeLayout(false);
            this.pnDG.PerformLayout();
            this.grpBoxSach.ResumeLayout(false);
            this.pnSach.ResumeLayout(false);
            this.pnSach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picAnhSach;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayHetHan;
        private System.Windows.Forms.Label lbHanSD;
        private System.Windows.Forms.Label lbMaSoThe;
        private System.Windows.Forms.TextBox txtMaSoThe;
        private ThuVienControl.txtSo txtSoDT;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txtHoTenDG;
        private System.Windows.Forms.PictureBox picAnhDG;
        private System.Windows.Forms.Label lbTacGia;
        private System.Windows.Forms.GroupBox grpBoxTTSach;
        private System.Windows.Forms.Panel pnDG;
        private System.Windows.Forms.GroupBox grpBoxSach;
        private System.Windows.Forms.Panel pnSach;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.Label lbSoLuongMuon;
        private ThuVienControl.txtSo txtSoLuongMuon;
        private System.Windows.Forms.TextBox txtSoLuongSachCon;
        private System.Windows.Forms.Label lbSLKho;
        private System.Windows.Forms.Label lbTienTheChan;
        private ThuVienControl.txtSo txtTienTheChan;
        private ThuVienControl.txtSo txtEmai;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTim;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXacNhan;
    }
}