namespace THITN
{
    partial class frmSinhVien
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mALOPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cHUYEN_DEDataSet = new THITN.CHUYEN_DEDataSet();
            this.sinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhvienTableAdapter = new THITN.CHUYEN_DEDataSetTableAdapters.SinhvienTableAdapter();
            this.tableAdapterManager = new THITN.CHUYEN_DEDataSetTableAdapters.TableAdapterManager();
            this.sinhvienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACTIVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.tbMaSinhVien = new DevExpress.XtraEditors.TextEdit();
            this.tbHo = new DevExpress.XtraEditors.TextEdit();
            this.tbTen = new DevExpress.XtraEditors.TextEdit();
            this.tbNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.tbDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.tbMaLop = new DevExpress.XtraEditors.TextEdit();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYEN_DEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaSinhVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaLop.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(76, 54);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(70, 13);
            mASVLabel.TabIndex = 2;
            mASVLabel.Text = "Mã sinh viên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(319, 54);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(24, 13);
            hOLabel.TabIndex = 4;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(559, 54);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(29, 13);
            tENLabel.TabIndex = 6;
            tENLabel.Text = "Tên:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(319, 104);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(58, 13);
            nGAYSINHLabel.TabIndex = 8;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(559, 104);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(43, 13);
            dIACHILabel.TabIndex = 10;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(76, 104);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(42, 13);
            mALOPLabel.TabIndex = 12;
            mALOPLabel.Text = "Mã lớp:";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableClose = true;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DisableClose = true;
            this.bar3.OptionsBar.DisableCustomization = true;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar5});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnLuu,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar5;
            this.barManager1.MaxItemId = 6;
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThem.Glyph")));
            this.btnThem.Id = 0;
            this.btnThem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThem.LargeGlyph")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSua.Glyph")));
            this.btnSua.Id = 1;
            this.btnSua.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSua.LargeGlyph")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 2;
            this.btnXoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.LargeGlyph")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.Glyph")));
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.LargeGlyph")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLuu.Glyph")));
            this.btnLuu.Id = 4;
            this.btnLuu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLuu.LargeGlyph")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.Glyph")));
            this.btnThoat.Id = 5;
            this.btnThoat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.LargeGlyph")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1345, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 566);
            this.barDockControlBottom.Size = new System.Drawing.Size(1345, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 542);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1345, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 542);
            // 
            // cHUYEN_DEDataSet
            // 
            this.cHUYEN_DEDataSet.DataSetName = "CHUYEN_DEDataSet";
            this.cHUYEN_DEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhvienBindingSource
            // 
            this.sinhvienBindingSource.DataMember = "Sinhvien";
            this.sinhvienBindingSource.DataSource = this.cHUYEN_DEDataSet;
            // 
            // sinhvienTableAdapter
            // 
            this.sinhvienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangDiemTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Giaovien_DangkyTableAdapter = null;
            this.tableAdapterManager.GiaovienTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonhocTableAdapter = null;
            this.tableAdapterManager.SinhvienTableAdapter = this.sinhvienTableAdapter;
            this.tableAdapterManager.UpdateOrder = THITN.CHUYEN_DEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sinhvienGridControl
            // 
            this.sinhvienGridControl.DataSource = this.sinhvienBindingSource;
            this.sinhvienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sinhvienGridControl.Location = new System.Drawing.Point(0, 24);
            this.sinhvienGridControl.MainView = this.gridView1;
            this.sinhvienGridControl.MenuManager = this.barManager1;
            this.sinhvienGridControl.Name = "sinhvienGridControl";
            this.sinhvienGridControl.Size = new System.Drawing.Size(1345, 340);
            this.sinhvienGridControl.TabIndex = 5;
            this.sinhvienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colDIACHI,
            this.colMALOP,
            this.colACTIVE});
            this.gridView1.GridControl = this.sinhvienGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMASV.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMASV.OptionsColumn.AllowMove = false;
            this.colMASV.OptionsColumn.AllowShowHide = false;
            this.colMASV.OptionsColumn.ShowInCustomizationForm = false;
            this.colMASV.OptionsColumn.ShowInExpressionEditor = false;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colHO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colHO.OptionsColumn.AllowMove = false;
            this.colHO.OptionsColumn.AllowShowHide = false;
            this.colHO.OptionsColumn.ShowInCustomizationForm = false;
            this.colHO.OptionsColumn.ShowInExpressionEditor = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTEN.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTEN.OptionsColumn.AllowMove = false;
            this.colTEN.OptionsColumn.AllowShowHide = false;
            this.colTEN.OptionsColumn.ShowInCustomizationForm = false;
            this.colTEN.OptionsColumn.ShowInExpressionEditor = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNGAYSINH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNGAYSINH.OptionsColumn.AllowMove = false;
            this.colNGAYSINH.OptionsColumn.AllowShowHide = false;
            this.colNGAYSINH.OptionsColumn.ShowInCustomizationForm = false;
            this.colNGAYSINH.OptionsColumn.ShowInExpressionEditor = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDIACHI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDIACHI.OptionsColumn.AllowMove = false;
            this.colDIACHI.OptionsColumn.AllowShowHide = false;
            this.colDIACHI.OptionsColumn.ShowInCustomizationForm = false;
            this.colDIACHI.OptionsColumn.ShowInExpressionEditor = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMALOP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMALOP.OptionsColumn.AllowMove = false;
            this.colMALOP.OptionsColumn.AllowShowHide = false;
            this.colMALOP.OptionsColumn.ShowInCustomizationForm = false;
            this.colMALOP.OptionsColumn.ShowInExpressionEditor = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 5;
            // 
            // colACTIVE
            // 
            this.colACTIVE.FieldName = "ACTIVE";
            this.colACTIVE.Name = "colACTIVE";
            this.colACTIVE.OptionsColumn.AllowEdit = false;
            this.colACTIVE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colACTIVE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colACTIVE.OptionsColumn.AllowMove = false;
            this.colACTIVE.OptionsColumn.AllowShowHide = false;
            this.colACTIVE.OptionsColumn.ShowInCustomizationForm = false;
            this.colACTIVE.OptionsColumn.ShowInExpressionEditor = false;
            this.colACTIVE.Visible = true;
            this.colACTIVE.VisibleIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMatKhau);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbMatKhau);
            this.panel1.Controls.Add(mASVLabel);
            this.panel1.Controls.Add(this.tbMaSinhVien);
            this.panel1.Controls.Add(hOLabel);
            this.panel1.Controls.Add(this.tbHo);
            this.panel1.Controls.Add(tENLabel);
            this.panel1.Controls.Add(this.tbTen);
            this.panel1.Controls.Add(nGAYSINHLabel);
            this.panel1.Controls.Add(this.tbNgaySinh);
            this.panel1.Controls.Add(dIACHILabel);
            this.panel1.Controls.Add(this.tbDiaChi);
            this.panel1.Controls.Add(mALOPLabel);
            this.panel1.Controls.Add(this.tbMaLop);
            this.panel1.Controls.Add(this.btnHoanTat);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 210);
            this.panel1.TabIndex = 22;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(76, 153);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(55, 13);
            this.lbMatKhau.TabIndex = 25;
            this.lbMatKhau.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Thông tin chi tiết:";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMatKhau.Location = new System.Drawing.Point(165, 150);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(100, 21);
            this.tbMatKhau.TabIndex = 23;
            this.tbMatKhau.UseSystemPasswordChar = true;
            this.tbMatKhau.Visible = false;
            this.tbMatKhau.WordWrap = false;
            // 
            // tbMaSinhVien
            // 
            this.tbMaSinhVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhvienBindingSource, "MASV", true));
            this.tbMaSinhVien.Enabled = false;
            this.tbMaSinhVien.Location = new System.Drawing.Point(165, 51);
            this.tbMaSinhVien.MenuManager = this.barManager1;
            this.tbMaSinhVien.Name = "tbMaSinhVien";
            this.tbMaSinhVien.Size = new System.Drawing.Size(100, 20);
            this.tbMaSinhVien.TabIndex = 3;
            // 
            // tbHo
            // 
            this.tbHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhvienBindingSource, "HO", true));
            this.tbHo.Enabled = false;
            this.tbHo.Location = new System.Drawing.Point(401, 51);
            this.tbHo.MenuManager = this.barManager1;
            this.tbHo.Name = "tbHo";
            this.tbHo.Size = new System.Drawing.Size(120, 20);
            this.tbHo.TabIndex = 5;
            // 
            // tbTen
            // 
            this.tbTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhvienBindingSource, "TEN", true));
            this.tbTen.Enabled = false;
            this.tbTen.Location = new System.Drawing.Point(632, 51);
            this.tbTen.MenuManager = this.barManager1;
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(208, 20);
            this.tbTen.TabIndex = 7;
            // 
            // tbNgaySinh
            // 
            this.tbNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhvienBindingSource, "NGAYSINH", true));
            this.tbNgaySinh.EditValue = null;
            this.tbNgaySinh.Enabled = false;
            this.tbNgaySinh.Location = new System.Drawing.Point(401, 101);
            this.tbNgaySinh.MenuManager = this.barManager1;
            this.tbNgaySinh.Name = "tbNgaySinh";
            this.tbNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbNgaySinh.Size = new System.Drawing.Size(120, 20);
            this.tbNgaySinh.TabIndex = 9;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhvienBindingSource, "DIACHI", true));
            this.tbDiaChi.Enabled = false;
            this.tbDiaChi.Location = new System.Drawing.Point(632, 101);
            this.tbDiaChi.MenuManager = this.barManager1;
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(208, 20);
            this.tbDiaChi.TabIndex = 11;
            // 
            // tbMaLop
            // 
            this.tbMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sinhvienBindingSource, "MALOP", true));
            this.tbMaLop.Enabled = false;
            this.tbMaLop.Location = new System.Drawing.Point(165, 101);
            this.tbMaLop.MenuManager = this.barManager1;
            this.tbMaLop.Name = "tbMaLop";
            this.tbMaLop.Size = new System.Drawing.Size(100, 20);
            this.tbMaLop.TabIndex = 13;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Enabled = false;
            this.btnHoanTat.Location = new System.Drawing.Point(1080, 160);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(101, 30);
            this.btnHoanTat.TabIndex = 0;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(1207, 160);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(101, 30);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sinhvienGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "frmSinhVien";
            this.Text = "frmSinhVien";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYEN_DEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaSinhVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaLop.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource sinhvienBindingSource;
        private CHUYEN_DEDataSet cHUYEN_DEDataSet;
        private CHUYEN_DEDataSetTableAdapters.SinhvienTableAdapter sinhvienTableAdapter;
        private CHUYEN_DEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sinhvienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colACTIVE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnHoanTat;
        private DevExpress.XtraEditors.TextEdit tbMaSinhVien;
        private DevExpress.XtraEditors.TextEdit tbHo;
        private DevExpress.XtraEditors.TextEdit tbTen;
        private DevExpress.XtraEditors.DateEdit tbNgaySinh;
        private DevExpress.XtraEditors.TextEdit tbDiaChi;
        private DevExpress.XtraEditors.TextEdit tbMaLop;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMatKhau;
    }
}