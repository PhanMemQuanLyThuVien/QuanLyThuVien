
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
            this.dateTimePickerNVL = new System.Windows.Forms.DateTimePicker();
            this.lbNVL = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEmai = new ThuVienControl.txtEmail();
            this.txtCMND = new ThuVienControl.txtSo();
            this.txtSoDT = new ThuVienControl.txtSo();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
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
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.pnNhapTT = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnNhapTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerNVL
            // 
            this.dateTimePickerNVL.CalendarForeColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNVL.CalendarMonthBackground = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNVL.CalendarTitleBackColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNVL.CalendarTitleForeColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNVL.CalendarTrailingForeColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerNVL.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNVL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNVL.Location = new System.Drawing.Point(517, 274);
            this.dateTimePickerNVL.Name = "dateTimePickerNVL";
            this.dateTimePickerNVL.Size = new System.Drawing.Size(303, 22);
            this.dateTimePickerNVL.TabIndex = 55;
            this.dateTimePickerNVL.Value = new System.DateTime(2021, 1, 27, 0, 0, 0, 0);
            // 
            // lbNVL
            // 
            this.lbNVL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNVL.Location = new System.Drawing.Point(517, 240);
            this.lbNVL.Name = "lbNVL";
            this.lbNVL.Size = new System.Drawing.Size(303, 33);
            this.lbNVL.TabIndex = 54;
            this.lbNVL.Text = "Ngày Vào Làm:";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(666, 356);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 41);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(513, 356);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 41);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbID
            // 
            this.lbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(104, 13);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(303, 33);
            this.lbID.TabIndex = 50;
            this.lbID.Text = "ID :";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(104, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(303, 22);
            this.txtID.TabIndex = 51;
            // 
            // txtEmai
            // 
            this.txtEmai.ForeColor = System.Drawing.Color.Black;
            this.txtEmai.Location = new System.Drawing.Point(104, 367);
            this.txtEmai.Name = "txtEmai";
            this.txtEmai.Size = new System.Drawing.Size(303, 22);
            this.txtEmai.TabIndex = 49;
            // 
            // txtCMND
            // 
            this.txtCMND.ForeColor = System.Drawing.Color.Black;
            this.txtCMND.Location = new System.Drawing.Point(513, 115);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(303, 22);
            this.txtCMND.TabIndex = 48;
            // 
            // txtSoDT
            // 
            this.txtSoDT.ForeColor = System.Drawing.Color.Black;
            this.txtSoDT.Location = new System.Drawing.Point(517, 47);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(303, 22);
            this.txtSoDT.TabIndex = 47;
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
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(104, 194);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(303, 22);
            this.dateTimePickerNgaySinh.TabIndex = 46;
            this.dateTimePickerNgaySinh.Value = new System.DateTime(2021, 1, 27, 0, 0, 0, 0);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(833, 356);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 41);
            this.btnLuu.TabIndex = 45;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.Location = new System.Drawing.Point(104, 240);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(303, 33);
            this.lbGioiTinh.TabIndex = 42;
            this.lbGioiTinh.Text = "Giới Tính:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoNam);
            this.panel1.Controls.Add(this.rdoNu);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(104, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 33);
            this.panel1.TabIndex = 41;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Location = new System.Drawing.Point(3, 3);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(58, 21);
            this.rdoNam.TabIndex = 40;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(125, 3);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(47, 21);
            this.rdoNu.TabIndex = 39;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(517, 160);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(303, 33);
            this.lbDiaChi.TabIndex = 37;
            this.lbDiaChi.Text = "Địa Chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(513, 194);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(303, 22);
            this.txtDiaChi.TabIndex = 38;
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(104, 333);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(303, 33);
            this.lbEmail.TabIndex = 35;
            this.lbEmail.Text = "Email:";
            // 
            // lbSDT
            // 
            this.lbSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(517, 13);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(303, 33);
            this.lbSDT.TabIndex = 33;
            this.lbSDT.Text = "Số Điện Thoại:";
            // 
            // lbCMND
            // 
            this.lbCMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMND.Location = new System.Drawing.Point(513, 81);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(303, 33);
            this.lbCMND.TabIndex = 31;
            this.lbCMND.Text = "CMND:";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(104, 160);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(303, 33);
            this.lbNgaySinh.TabIndex = 29;
            this.lbNgaySinh.Text = "Ngày Sinh:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(104, 81);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(303, 33);
            this.lbHoTen.TabIndex = 5;
            this.lbHoTen.Text = "Họ Tên:";
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.ForeColor = System.Drawing.Color.Black;
            this.txtHoTenNV.Location = new System.Drawing.Point(104, 115);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(303, 22);
            this.txtHoTenNV.TabIndex = 11;
            // 
            // pnNhapTT
            // 
            this.pnNhapTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnNhapTT.Controls.Add(this.dateTimePickerNVL);
            this.pnNhapTT.Controls.Add(this.lbNVL);
            this.pnNhapTT.Controls.Add(this.btnSua);
            this.pnNhapTT.Controls.Add(this.btnXoa);
            this.pnNhapTT.Controls.Add(this.lbID);
            this.pnNhapTT.Controls.Add(this.txtID);
            this.pnNhapTT.Controls.Add(this.txtEmai);
            this.pnNhapTT.Controls.Add(this.txtCMND);
            this.pnNhapTT.Controls.Add(this.txtSoDT);
            this.pnNhapTT.Controls.Add(this.dateTimePickerNgaySinh);
            this.pnNhapTT.Controls.Add(this.btnLuu);
            this.pnNhapTT.Controls.Add(this.lbGioiTinh);
            this.pnNhapTT.Controls.Add(this.panel1);
            this.pnNhapTT.Controls.Add(this.lbDiaChi);
            this.pnNhapTT.Controls.Add(this.txtDiaChi);
            this.pnNhapTT.Controls.Add(this.lbEmail);
            this.pnNhapTT.Controls.Add(this.lbSDT);
            this.pnNhapTT.Controls.Add(this.lbCMND);
            this.pnNhapTT.Controls.Add(this.lbNgaySinh);
            this.pnNhapTT.Controls.Add(this.lbHoTen);
            this.pnNhapTT.Controls.Add(this.txtHoTenNV);
            this.pnNhapTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNhapTT.Location = new System.Drawing.Point(0, 0);
            this.pnNhapTT.Name = "pnNhapTT";
            this.pnNhapTT.Size = new System.Drawing.Size(1020, 484);
            this.pnNhapTT.TabIndex = 31;
            // 
            // frmChiTietNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 484);
            this.Controls.Add(this.pnNhapTT);
            this.Name = "frmChiTietNhanVien";
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

        private System.Windows.Forms.DateTimePicker dateTimePickerNVL;
        private System.Windows.Forms.Label lbNVL;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private ThuVienControl.txtEmail txtEmai;
        private ThuVienControl.txtSo txtCMND;
        private ThuVienControl.txtSo txtSoDT;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.Button btnLuu;
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
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.Panel pnNhapTT;
    }
}