﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THITN
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmDangNhap));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Text = "Đăng nhập";
                f.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.Text = "Đăng nhập";
            f.Show();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private Form KiemTraTonTai(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType) //Neu form duoc truyen vao da duoc mo
                {
                    return f;
                }
            }
            return null;
        }

        public void DangNhapThanhCong()
        {
            tsMaNguoiDung.Text = "Mã người dùng: " + Program.username + "  - ";
            tsTenNguoiDung.Text = "Tên người dùng: " + Program.mHoten + "  - ";
            tsNhomQuyen.Text = "Nhóm quyền: " + Program.mGroup;
            btnDangNhap.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            btnDangNhap.Enabled = false;
            btnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnDangXuat.Enabled = true;
            if (Program.mGroup.Equals("GIAOVIEN"))
            {
                //btnDangKi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //btnDangKi.Enabled = true;
                rpgDuLieu.Visible = true;
                rpgDuLieu.Enabled = true;
                rpGiaoVien.Visible = true;
            }
            else if (Program.mGroup.Equals("SINHVIEN"))
            {
                rpSinhVien.Visible = true;
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            Program.conn.Close();
            Program.conn.Dispose();
            tsMaNguoiDung.Text = "Vui lòng đăng nhập để sử dụng chương trình";
            tsTenNguoiDung.Text = "";
            tsNhomQuyen.Text = "";
            btnDangNhap.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnDangNhap.Enabled = true;
            btnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            btnDangXuat.Enabled = false;
            //btnDangKi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            rpgDuLieu.Visible = false;
            rpGiaoVien.Visible = false;
            rpSinhVien.Visible = false;
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmGiaoVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmGiaoVien f = new frmGiaoVien();
                f.MdiParent = this;
                f.Text = "Quản lí giáo viên";
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmMonHoc));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Text = "Quản lí môn học";
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmLop));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Text = "Quản lí lớp học";
                f.Show();
            }

        }

        private void barButtonItem6_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmChuanBiThi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmChuanBiThi f = new frmChuanBiThi();
                f.MdiParent = this;
                f.Text = "Chuẩn bị thi";
                f.Show();
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmSaoLuuPhucHoi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmSaoLuuPhucHoi f = new frmSaoLuuPhucHoi();
                f.MdiParent = this;
                f.Text = "Sao lưu & phục hồi dữ liệu";
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmThongTinThi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmThongTinThi f = new frmThongTinThi();
                f.MdiParent = this;
                f.Text = "Thi trắc nghiệm";
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(Form2));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Form2 f = new Form2();
                f.MdiParent = this;
                f.Text = "Xem bảng điểm";
                f.Show();
            }
        }
    }
}
