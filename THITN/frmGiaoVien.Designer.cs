namespace THITN
{
    partial class frmGiaoVien
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label sODTLLLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
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
            this.giaovienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giaovienTableAdapter = new THITN.CHUYEN_DEDataSetTableAdapters.GiaovienTableAdapter();
            this.tableAdapterManager = new THITN.CHUYEN_DEDataSetTableAdapters.TableAdapterManager();
            this.giaovienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODTLL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACTIVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.tbMaGV = new DevExpress.XtraEditors.TextEdit();
            this.tbHo = new DevExpress.XtraEditors.TextEdit();
            this.tbTen = new DevExpress.XtraEditors.TextEdit();
            this.tbSoDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.tbDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            sODTLLLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYEN_DEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaovienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaovienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSoDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDiaChi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            mAGVLabel.Location = new System.Drawing.Point(23, 46);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(71, 13);
            mAGVLabel.TabIndex = 10;
            mAGVLabel.Text = "Mã giáo viên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            hOLabel.Location = new System.Drawing.Point(234, 46);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(24, 13);
            hOLabel.TabIndex = 12;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tENLabel.Location = new System.Drawing.Point(419, 46);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(29, 13);
            tENLabel.TabIndex = 14;
            tENLabel.Text = "Tên:";
            // 
            // sODTLLLabel
            // 
            sODTLLLabel.AutoSize = true;
            sODTLLLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            sODTLLLabel.Location = new System.Drawing.Point(23, 77);
            sODTLLLabel.Name = "sODTLLLabel";
            sODTLLLabel.Size = new System.Drawing.Size(75, 13);
            sODTLLLabel.TabIndex = 16;
            sODTLLLabel.Text = "Số ĐT liên lạc:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dIACHILabel.Location = new System.Drawing.Point(234, 77);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(43, 13);
            dIACHILabel.TabIndex = 18;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
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
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableClose = true;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThem.Glyph")));
            this.btnThem.Id = 0;
            this.btnThem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThem.LargeGlyph")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
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
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(899, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 390);
            this.barDockControlBottom.Size = new System.Drawing.Size(899, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 366);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(899, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 366);
            // 
            // cHUYEN_DEDataSet
            // 
            this.cHUYEN_DEDataSet.DataSetName = "CHUYEN_DEDataSet";
            this.cHUYEN_DEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaovienBindingSource
            // 
            this.giaovienBindingSource.DataMember = "Giaovien";
            this.giaovienBindingSource.DataSource = this.cHUYEN_DEDataSet;
            // 
            // giaovienTableAdapter
            // 
            this.giaovienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangDiemTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Giaovien_DangkyTableAdapter = null;
            this.tableAdapterManager.GiaovienTableAdapter = this.giaovienTableAdapter;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonhocTableAdapter = null;
            this.tableAdapterManager.SinhvienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.CHUYEN_DEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // giaovienGridControl
            // 
            this.giaovienGridControl.DataSource = this.giaovienBindingSource;
            this.giaovienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.giaovienGridControl.Location = new System.Drawing.Point(0, 24);
            this.giaovienGridControl.MainView = this.gridView1;
            this.giaovienGridControl.MenuManager = this.barManager1;
            this.giaovienGridControl.Name = "giaovienGridControl";
            this.giaovienGridControl.Size = new System.Drawing.Size(899, 226);
            this.giaovienGridControl.TabIndex = 5;
            this.giaovienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colSODTLL,
            this.colDIACHI,
            this.colACTIVE});
            this.gridView1.GridControl = this.giaovienGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.OptionsColumn.AllowEdit = false;
            this.colMAGV.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMAGV.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMAGV.OptionsColumn.AllowMove = false;
            this.colMAGV.OptionsColumn.AllowShowHide = false;
            this.colMAGV.OptionsColumn.ShowInCustomizationForm = false;
            this.colMAGV.OptionsColumn.ShowInExpressionEditor = false;
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
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
            // colSODTLL
            // 
            this.colSODTLL.FieldName = "SODTLL";
            this.colSODTLL.Name = "colSODTLL";
            this.colSODTLL.OptionsColumn.AllowEdit = false;
            this.colSODTLL.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSODTLL.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSODTLL.OptionsColumn.AllowMove = false;
            this.colSODTLL.OptionsColumn.AllowShowHide = false;
            this.colSODTLL.OptionsColumn.ShowInCustomizationForm = false;
            this.colSODTLL.OptionsColumn.ShowInExpressionEditor = false;
            this.colSODTLL.Visible = true;
            this.colSODTLL.VisibleIndex = 3;
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
            this.colACTIVE.VisibleIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHoanTat);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(mAGVLabel);
            this.panel1.Controls.Add(this.tbMaGV);
            this.panel1.Controls.Add(hOLabel);
            this.panel1.Controls.Add(this.tbHo);
            this.panel1.Controls.Add(tENLabel);
            this.panel1.Controls.Add(this.tbTen);
            this.panel1.Controls.Add(sODTLLLabel);
            this.panel1.Controls.Add(this.tbSoDienThoai);
            this.panel1.Controls.Add(dIACHILabel);
            this.panel1.Controls.Add(this.tbDiaChi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 139);
            this.panel1.TabIndex = 6;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Enabled = false;
            this.btnHoanTat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHoanTat.Location = new System.Drawing.Point(706, 113);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(75, 23);
            this.btnHoanTat.TabIndex = 21;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(803, 113);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // tbMaGV
            // 
            this.tbMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giaovienBindingSource, "MAGV", true));
            this.tbMaGV.Enabled = false;
            this.tbMaGV.Location = new System.Drawing.Point(111, 43);
            this.tbMaGV.MenuManager = this.barManager1;
            this.tbMaGV.Name = "tbMaGV";
            this.tbMaGV.Size = new System.Drawing.Size(100, 20);
            this.tbMaGV.TabIndex = 11;
            // 
            // tbHo
            // 
            this.tbHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giaovienBindingSource, "HO", true));
            this.tbHo.Enabled = false;
            this.tbHo.Location = new System.Drawing.Point(291, 43);
            this.tbHo.MenuManager = this.barManager1;
            this.tbHo.Name = "tbHo";
            this.tbHo.Size = new System.Drawing.Size(100, 20);
            this.tbHo.TabIndex = 13;
            // 
            // tbTen
            // 
            this.tbTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giaovienBindingSource, "TEN", true));
            this.tbTen.Enabled = false;
            this.tbTen.Location = new System.Drawing.Point(467, 43);
            this.tbTen.MenuManager = this.barManager1;
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(100, 20);
            this.tbTen.TabIndex = 15;
            // 
            // tbSoDienThoai
            // 
            this.tbSoDienThoai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giaovienBindingSource, "SODTLL", true));
            this.tbSoDienThoai.Enabled = false;
            this.tbSoDienThoai.Location = new System.Drawing.Point(111, 74);
            this.tbSoDienThoai.MenuManager = this.barManager1;
            this.tbSoDienThoai.Name = "tbSoDienThoai";
            this.tbSoDienThoai.Size = new System.Drawing.Size(100, 20);
            this.tbSoDienThoai.TabIndex = 17;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giaovienBindingSource, "DIACHI", true));
            this.tbDiaChi.Enabled = false;
            this.tbDiaChi.Location = new System.Drawing.Point(291, 74);
            this.tbDiaChi.MenuManager = this.barManager1;
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(100, 20);
            this.tbDiaChi.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Thông tin chi tiết:";
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.giaovienGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmGiaoVien";
            this.Text = "frmGiaoVien";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYEN_DEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaovienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaovienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSoDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDiaChi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource giaovienBindingSource;
        private CHUYEN_DEDataSet cHUYEN_DEDataSet;
        private CHUYEN_DEDataSetTableAdapters.GiaovienTableAdapter giaovienTableAdapter;
        private CHUYEN_DEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl giaovienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSODTLL;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colACTIVE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Button btnHuy;
        private DevExpress.XtraEditors.TextEdit tbMaGV;
        private DevExpress.XtraEditors.TextEdit tbHo;
        private DevExpress.XtraEditors.TextEdit tbTen;
        private DevExpress.XtraEditors.TextEdit tbSoDienThoai;
        private DevExpress.XtraEditors.TextEdit tbDiaChi;
    }
}