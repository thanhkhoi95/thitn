﻿namespace THITN
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.rcMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.rpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgDuLieu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgChuongTrinh = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpGiaoVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSinhVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsMaNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTenNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsNhomQuyen = new System.Windows.Forms.ToolStripStatusLabel();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.rcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // rcMain
            // 
            this.rcMain.ExpandCollapseItem.Id = 0;
            this.rcMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcMain.ExpandCollapseItem,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnSaoLuu,
            this.btnPhucHoi,
            this.btnThoat,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem4,
            this.barButtonItem6,
            this.barButtonItem5,
            this.barButtonItem3});
            this.rcMain.Location = new System.Drawing.Point(0, 0);
            this.rcMain.Margin = new System.Windows.Forms.Padding(4);
            this.rcMain.MaxItemId = 16;
            this.rcMain.Name = "rcMain";
            this.rcMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpHeThong,
            this.rpGiaoVien,
            this.rpSinhVien});
            this.rcMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.rcMain.Size = new System.Drawing.Size(1137, 143);
            this.rcMain.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Glyph")));
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Glyph")));
            this.btnDangXuat.Id = 2;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Caption = "Sao lưu";
            this.btnSaoLuu.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.Glyph")));
            this.btnSaoLuu.Id = 3;
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.Glyph")));
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.Glyph")));
            this.btnThoat.Id = 6;
            this.btnThoat.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btnThoat.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Giáo viên";
            this.barButtonItem1.Glyph = global::THITN.Properties.Resources.teacher__1_;
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Lớp - Sinh viên";
            this.barButtonItem2.Glyph = global::THITN.Properties.Resources.reading__2_;
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.LargeWidth = 90;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Môn học";
            this.barButtonItem4.Glyph = global::THITN.Properties.Resources.book;
            this.barButtonItem4.Id = 11;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Chuẩn bị thi";
            this.barButtonItem6.Glyph = global::THITN.Properties.Resources.contract;
            this.barButtonItem6.Id = 13;
            this.barButtonItem6.LargeWidth = 70;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Bộ đề";
            this.barButtonItem5.Glyph = global::THITN.Properties.Resources.checklist;
            this.barButtonItem5.Id = 14;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // rpHeThong
            // 
            this.rpHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgTaiKhoan,
            this.rpgDuLieu,
            this.rpgChuongTrinh});
            this.rpHeThong.ImageAlign = DevExpress.Utils.HorzAlignment.Near;
            this.rpHeThong.Name = "rpHeThong";
            this.rpHeThong.Text = "Hệ thống";
            // 
            // rpgTaiKhoan
            // 
            this.rpgTaiKhoan.AllowTextClipping = false;
            this.rpgTaiKhoan.ItemLinks.Add(this.btnDangNhap);
            this.rpgTaiKhoan.ItemLinks.Add(this.btnDangXuat);
            this.rpgTaiKhoan.Name = "rpgTaiKhoan";
            this.rpgTaiKhoan.ShowCaptionButton = false;
            this.rpgTaiKhoan.Text = "Tài khoản";
            // 
            // rpgDuLieu
            // 
            this.rpgDuLieu.AllowTextClipping = false;
            this.rpgDuLieu.Enabled = false;
            this.rpgDuLieu.ItemLinks.Add(this.btnSaoLuu);
            this.rpgDuLieu.ItemLinks.Add(this.btnPhucHoi);
            this.rpgDuLieu.Name = "rpgDuLieu";
            this.rpgDuLieu.ShowCaptionButton = false;
            this.rpgDuLieu.Text = "Dữ liệu";
            this.rpgDuLieu.Visible = false;
            // 
            // rpgChuongTrinh
            // 
            this.rpgChuongTrinh.AllowTextClipping = false;
            this.rpgChuongTrinh.ItemLinks.Add(this.btnThoat);
            this.rpgChuongTrinh.Name = "rpgChuongTrinh";
            this.rpgChuongTrinh.ShowCaptionButton = false;
            this.rpgChuongTrinh.Text = "Chương trình";
            // 
            // rpGiaoVien
            // 
            this.rpGiaoVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.rpGiaoVien.Name = "rpGiaoVien";
            this.rpGiaoVien.Text = "Quản lí";
            this.rpGiaoVien.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Người dùng";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Thi cử";
            // 
            // rpSinhVien
            // 
            this.rpSinhVien.Name = "rpSinhVien";
            this.rpSinhVien.Text = "Thi trắc nghiệm";
            this.rpSinhVien.Visible = false;
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMaNguoiDung,
            this.tsTenNguoiDung,
            this.tsNhomQuyen});
            this.statusStrip.Location = new System.Drawing.Point(0, 610);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1137, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsMaNguoiDung
            // 
            this.tsMaNguoiDung.Name = "tsMaNguoiDung";
            this.tsMaNguoiDung.Size = new System.Drawing.Size(245, 17);
            this.tsMaNguoiDung.Text = "Vui lòng đăng nhập để sử dụng chương trình";
            // 
            // tsTenNguoiDung
            // 
            this.tsTenNguoiDung.Name = "tsTenNguoiDung";
            this.tsTenNguoiDung.Size = new System.Drawing.Size(0, 17);
            // 
            // tsNhomQuyen
            // 
            this.tsNhomQuyen.Name = "tsNhomQuyen";
            this.tsNhomQuyen.Size = new System.Drawing.Size(0, 17);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Bảng điểm";
            this.barButtonItem3.Glyph = global::THITN.Properties.Resources.grades;
            this.barButtonItem3.Id = 15;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 632);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.rcMain);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.rcMain;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THI TRẮC NGHIỆM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rcMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHeThong;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDuLieu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnSaoLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpGiaoVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpSinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgChuongTrinh;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsMaNguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel tsTenNguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel tsNhomQuyen;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}
