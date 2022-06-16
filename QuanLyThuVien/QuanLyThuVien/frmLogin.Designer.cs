namespace QuanLyThuVien
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnThoat = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(91, 89);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(150, 32);
            this.lblTaiKhoan.TabIndex = 6;
            this.lblTaiKhoan.Text = "Tài Khoản";
            this.lblTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(97, 142);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(144, 32);
            this.lblMatKhau.TabIndex = 7;
            this.lblMatKhau.Text = "Mật Khẩu";
            this.lblMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(248, 89);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(208, 37);
            this.txtTaiKhoan.TabIndex = 8;
            this.txtTaiKhoan.Text = "lamchikhang.it@gmail.com";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(248, 142);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(208, 37);
            this.txtMatKhau.TabIndex = 9;
            this.txtMatKhau.Text = "lamchikhang.it@gmail.com";
            // 
            // btnDN
            // 
            this.btnDN.AllowAnimations = true;
            this.btnDN.AllowMouseEffects = true;
            this.btnDN.AllowToggling = false;
            this.btnDN.AnimationSpeed = 200;
            this.btnDN.AutoGenerateColors = false;
            this.btnDN.AutoRoundBorders = false;
            this.btnDN.AutoSizeLeftIcon = true;
            this.btnDN.AutoSizeRightIcon = true;
            this.btnDN.BackColor = System.Drawing.Color.Transparent;
            this.btnDN.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnDN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDN.BackgroundImage")));
            this.btnDN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDN.ButtonText = "Đăng Nhập";
            this.btnDN.ButtonTextMarginLeft = 0;
            this.btnDN.ColorContrastOnClick = 45;
            this.btnDN.ColorContrastOnHover = 45;
            this.btnDN.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDN.CustomizableEdges = borderEdges1;
            this.btnDN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDN.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDN.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDN.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDN.ForeColor = System.Drawing.Color.White;
            this.btnDN.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDN.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDN.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDN.IconMarginLeft = 11;
            this.btnDN.IconPadding = 10;
            this.btnDN.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDN.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDN.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDN.IconSize = 25;
            this.btnDN.IdleBorderColor = System.Drawing.Color.White;
            this.btnDN.IdleBorderRadius = 30;
            this.btnDN.IdleBorderThickness = 1;
            this.btnDN.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnDN.IdleIconLeftImage = null;
            this.btnDN.IdleIconRightImage = null;
            this.btnDN.IndicateFocus = false;
            this.btnDN.Location = new System.Drawing.Point(309, 197);
            this.btnDN.Name = "btnDN";
            this.btnDN.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDN.OnDisabledState.BorderRadius = 30;
            this.btnDN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDN.OnDisabledState.BorderThickness = 1;
            this.btnDN.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDN.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDN.OnDisabledState.IconLeftImage = null;
            this.btnDN.OnDisabledState.IconRightImage = null;
            this.btnDN.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDN.onHoverState.BorderRadius = 30;
            this.btnDN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDN.onHoverState.BorderThickness = 1;
            this.btnDN.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDN.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDN.onHoverState.IconLeftImage = null;
            this.btnDN.onHoverState.IconRightImage = null;
            this.btnDN.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnDN.OnIdleState.BorderRadius = 30;
            this.btnDN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDN.OnIdleState.BorderThickness = 1;
            this.btnDN.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDN.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDN.OnIdleState.IconLeftImage = null;
            this.btnDN.OnIdleState.IconRightImage = null;
            this.btnDN.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDN.OnPressedState.BorderRadius = 30;
            this.btnDN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDN.OnPressedState.BorderThickness = 1;
            this.btnDN.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDN.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDN.OnPressedState.IconLeftImage = null;
            this.btnDN.OnPressedState.IconRightImage = null;
            this.btnDN.Size = new System.Drawing.Size(147, 41);
            this.btnDN.TabIndex = 74;
            this.btnDN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDN.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDN.TextMarginLeft = 0;
            this.btnDN.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDN.UseDefaultRadiusAndThickness = true;
            this.btnDN.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AllowAnimations = true;
            this.btnThoat.AllowMouseEffects = true;
            this.btnThoat.AllowToggling = false;
            this.btnThoat.AnimationSpeed = 200;
            this.btnThoat.AutoGenerateColors = false;
            this.btnThoat.AutoRoundBorders = false;
            this.btnThoat.AutoSizeLeftIcon = true;
            this.btnThoat.AutoSizeRightIcon = true;
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThoat.ButtonText = "Thoát";
            this.btnThoat.ButtonTextMarginLeft = 0;
            this.btnThoat.ColorContrastOnClick = 45;
            this.btnThoat.ColorContrastOnHover = 45;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnThoat.CustomizableEdges = borderEdges2;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThoat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThoat.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThoat.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThoat.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnThoat.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnThoat.IconMarginLeft = 11;
            this.btnThoat.IconPadding = 10;
            this.btnThoat.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnThoat.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnThoat.IconSize = 25;
            this.btnThoat.IdleBorderColor = System.Drawing.Color.White;
            this.btnThoat.IdleBorderRadius = 30;
            this.btnThoat.IdleBorderThickness = 1;
            this.btnThoat.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.IdleIconLeftImage = null;
            this.btnThoat.IdleIconRightImage = null;
            this.btnThoat.IndicateFocus = false;
            this.btnThoat.Location = new System.Drawing.Point(165, 197);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThoat.OnDisabledState.BorderRadius = 30;
            this.btnThoat.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThoat.OnDisabledState.BorderThickness = 1;
            this.btnThoat.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThoat.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThoat.OnDisabledState.IconLeftImage = null;
            this.btnThoat.OnDisabledState.IconRightImage = null;
            this.btnThoat.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThoat.onHoverState.BorderRadius = 30;
            this.btnThoat.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThoat.onHoverState.BorderThickness = 1;
            this.btnThoat.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThoat.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnThoat.onHoverState.IconLeftImage = null;
            this.btnThoat.onHoverState.IconRightImage = null;
            this.btnThoat.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnThoat.OnIdleState.BorderRadius = 30;
            this.btnThoat.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThoat.OnIdleState.BorderThickness = 1;
            this.btnThoat.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnThoat.OnIdleState.IconLeftImage = null;
            this.btnThoat.OnIdleState.IconRightImage = null;
            this.btnThoat.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.OnPressedState.BorderRadius = 30;
            this.btnThoat.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThoat.OnPressedState.BorderThickness = 1;
            this.btnThoat.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnThoat.OnPressedState.IconLeftImage = null;
            this.btnThoat.OnPressedState.IconRightImage = null;
            this.btnThoat.Size = new System.Drawing.Size(119, 41);
            this.btnThoat.TabIndex = 75;
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThoat.TextMarginLeft = 0;
            this.btnThoat.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnThoat.UseDefaultRadiusAndThickness = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 328);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.txtMatKhau);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDN;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThoat;
    }
}