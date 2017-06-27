namespace THITN
{
    partial class frmBoDe
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
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label aLabel;
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label cLabel;
            System.Windows.Forms.Label dLabel;
            System.Windows.Forms.Label dAP_ANLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoDe));
            this.cHUYEN_DEDataSet = new THITN.CHUYEN_DEDataSet();
            this.bODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new THITN.CHUYEN_DEDataSetTableAdapters.BODETableAdapter();
            this.tableAdapterManager = new THITN.CHUYEN_DEDataSetTableAdapters.TableAdapterManager();
            this.bODEGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACTIVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.tbNoiDung = new DevExpress.XtraEditors.MemoEdit();
            this.tbA = new DevExpress.XtraEditors.MemoEdit();
            this.tbB = new DevExpress.XtraEditors.MemoEdit();
            this.tbC = new DevExpress.XtraEditors.MemoEdit();
            this.tbD = new DevExpress.XtraEditors.MemoEdit();
            this.cbTrinhDo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbDa = new DevExpress.XtraEditors.ComboBoxEdit();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            aLabel = new System.Windows.Forms.Label();
            bLabel = new System.Windows.Forms.Label();
            cLabel = new System.Windows.Forms.Label();
            dLabel = new System.Windows.Forms.Label();
            dAP_ANLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYEN_DEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTrinhDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            nOIDUNGLabel.Location = new System.Drawing.Point(37, 40);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(53, 13);
            nOIDUNGLabel.TabIndex = 7;
            nOIDUNGLabel.Text = "Nội dung:";
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            aLabel.Location = new System.Drawing.Point(312, 40);
            aLabel.Name = "aLabel";
            aLabel.Size = new System.Drawing.Size(18, 13);
            aLabel.TabIndex = 9;
            aLabel.Text = "A:";
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            bLabel.Location = new System.Drawing.Point(312, 96);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(17, 13);
            bLabel.TabIndex = 11;
            bLabel.Text = "B:";
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            cLabel.Location = new System.Drawing.Point(511, 40);
            cLabel.Name = "cLabel";
            cLabel.Size = new System.Drawing.Size(18, 13);
            cLabel.TabIndex = 13;
            cLabel.Text = "C:";
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dLabel.Location = new System.Drawing.Point(510, 96);
            dLabel.Name = "dLabel";
            dLabel.Size = new System.Drawing.Size(18, 13);
            dLabel.TabIndex = 15;
            dLabel.Text = "D:";
            // 
            // dAP_ANLabel
            // 
            dAP_ANLabel.AutoSize = true;
            dAP_ANLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dAP_ANLabel.Location = new System.Drawing.Point(37, 119);
            dAP_ANLabel.Name = "dAP_ANLabel";
            dAP_ANLabel.Size = new System.Drawing.Size(46, 13);
            dAP_ANLabel.TabIndex = 17;
            dAP_ANLabel.Text = "Đáp án:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tRINHDOLabel.Location = new System.Drawing.Point(181, 119);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(50, 13);
            tRINHDOLabel.TabIndex = 5;
            tRINHDOLabel.Text = "Trình độ:";
            // 
            // cHUYEN_DEDataSet
            // 
            this.cHUYEN_DEDataSet.DataSetName = "CHUYEN_DEDataSet";
            this.cHUYEN_DEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bODEBindingSource
            // 
            this.bODEBindingSource.DataMember = "BODE";
            this.bODEBindingSource.DataSource = this.cHUYEN_DEDataSet;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangDiemTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.Giaovien_DangkyTableAdapter = null;
            this.tableAdapterManager.GiaovienTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonhocTableAdapter = null;
            this.tableAdapterManager.SinhvienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.CHUYEN_DEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bODEGridControl
            // 
            this.bODEGridControl.DataSource = this.bODEBindingSource;
            this.bODEGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.bODEGridControl.Location = new System.Drawing.Point(0, 24);
            this.bODEGridControl.MainView = this.gridView1;
            this.bODEGridControl.Name = "bODEGridControl";
            this.bODEGridControl.Size = new System.Drawing.Size(899, 183);
            this.bODEGridControl.TabIndex = 1;
            this.bODEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colCAUHOI,
            this.colTRINHDO,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN,
            this.colMAGV,
            this.colACTIVE});
            this.gridView1.GridControl = this.bODEGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMAMH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMAMH.OptionsColumn.AllowMove = false;
            this.colMAMH.OptionsColumn.AllowShowHide = false;
            this.colMAMH.OptionsColumn.ShowInCustomizationForm = false;
            this.colMAMH.OptionsColumn.ShowInExpressionEditor = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 8;
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.FieldName = "CAUHOI";
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.OptionsColumn.AllowEdit = false;
            this.colCAUHOI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCAUHOI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCAUHOI.OptionsColumn.AllowMove = false;
            this.colCAUHOI.OptionsColumn.AllowShowHide = false;
            this.colCAUHOI.OptionsColumn.ShowInCustomizationForm = false;
            this.colCAUHOI.OptionsColumn.ShowInExpressionEditor = false;
            this.colCAUHOI.Visible = true;
            this.colCAUHOI.VisibleIndex = 0;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.OptionsColumn.AllowEdit = false;
            this.colTRINHDO.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTRINHDO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTRINHDO.OptionsColumn.AllowMove = false;
            this.colTRINHDO.OptionsColumn.AllowShowHide = false;
            this.colTRINHDO.OptionsColumn.ShowInCustomizationForm = false;
            this.colTRINHDO.OptionsColumn.ShowInExpressionEditor = false;
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 1;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.OptionsColumn.AllowEdit = false;
            this.colNOIDUNG.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNOIDUNG.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNOIDUNG.OptionsColumn.AllowMove = false;
            this.colNOIDUNG.OptionsColumn.AllowShowHide = false;
            this.colNOIDUNG.OptionsColumn.ShowInCustomizationForm = false;
            this.colNOIDUNG.OptionsColumn.ShowInExpressionEditor = false;
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 2;
            // 
            // colA
            // 
            this.colA.FieldName = "A";
            this.colA.Name = "colA";
            this.colA.OptionsColumn.AllowEdit = false;
            this.colA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colA.OptionsColumn.AllowMove = false;
            this.colA.OptionsColumn.AllowShowHide = false;
            this.colA.OptionsColumn.ShowInCustomizationForm = false;
            this.colA.OptionsColumn.ShowInExpressionEditor = false;
            this.colA.Visible = true;
            this.colA.VisibleIndex = 3;
            // 
            // colB
            // 
            this.colB.FieldName = "B";
            this.colB.Name = "colB";
            this.colB.OptionsColumn.AllowEdit = false;
            this.colB.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colB.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colB.OptionsColumn.AllowMove = false;
            this.colB.OptionsColumn.AllowShowHide = false;
            this.colB.OptionsColumn.ShowInCustomizationForm = false;
            this.colB.OptionsColumn.ShowInExpressionEditor = false;
            this.colB.Visible = true;
            this.colB.VisibleIndex = 4;
            // 
            // colC
            // 
            this.colC.FieldName = "C";
            this.colC.Name = "colC";
            this.colC.OptionsColumn.AllowEdit = false;
            this.colC.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colC.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colC.OptionsColumn.AllowMove = false;
            this.colC.OptionsColumn.AllowShowHide = false;
            this.colC.OptionsColumn.ShowInCustomizationForm = false;
            this.colC.OptionsColumn.ShowInExpressionEditor = false;
            this.colC.Visible = true;
            this.colC.VisibleIndex = 5;
            // 
            // colD
            // 
            this.colD.FieldName = "D";
            this.colD.Name = "colD";
            this.colD.OptionsColumn.AllowEdit = false;
            this.colD.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colD.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colD.OptionsColumn.AllowMove = false;
            this.colD.OptionsColumn.AllowShowHide = false;
            this.colD.OptionsColumn.ShowInCustomizationForm = false;
            this.colD.OptionsColumn.ShowInExpressionEditor = false;
            this.colD.Visible = true;
            this.colD.VisibleIndex = 6;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.OptionsColumn.AllowEdit = false;
            this.colDAP_AN.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDAP_AN.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDAP_AN.OptionsColumn.AllowMove = false;
            this.colDAP_AN.OptionsColumn.AllowShowHide = false;
            this.colDAP_AN.OptionsColumn.ShowInCustomizationForm = false;
            this.colDAP_AN.OptionsColumn.ShowInExpressionEditor = false;
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 7;
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
            this.colMAGV.VisibleIndex = 9;
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
            this.colACTIVE.VisibleIndex = 10;
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
            this.barButtonItem2,
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
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
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
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(899, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 398);
            this.barDockControlBottom.Size = new System.Drawing.Size(899, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 374);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(899, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 374);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnHoanTat);
            this.panel1.Controls.Add(tRINHDOLabel);
            this.panel1.Controls.Add(nOIDUNGLabel);
            this.panel1.Controls.Add(aLabel);
            this.panel1.Controls.Add(bLabel);
            this.panel1.Controls.Add(cLabel);
            this.panel1.Controls.Add(dLabel);
            this.panel1.Controls.Add(dAP_ANLabel);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.tbNoiDung);
            this.panel1.Controls.Add(this.tbA);
            this.panel1.Controls.Add(this.tbB);
            this.panel1.Controls.Add(this.tbC);
            this.panel1.Controls.Add(this.tbD);
            this.panel1.Controls.Add(this.cbTrinhDo);
            this.panel1.Controls.Add(this.cbDa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 347);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Thông tin chi tiết:";
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Enabled = false;
            this.btnHoanTat.Location = new System.Drawing.Point(722, 163);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(75, 23);
            this.btnHoanTat.TabIndex = 19;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(812, 163);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // tbNoiDung
            // 
            this.tbNoiDung.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bODEBindingSource, "NOIDUNG", true));
            this.tbNoiDung.EditValue = "Nội dung câu hỏi...";
            this.tbNoiDung.Enabled = false;
            this.tbNoiDung.Location = new System.Drawing.Point(111, 38);
            this.tbNoiDung.MenuManager = this.barManager1;
            this.tbNoiDung.Name = "tbNoiDung";
            this.tbNoiDung.Size = new System.Drawing.Size(184, 68);
            this.tbNoiDung.TabIndex = 8;
            // 
            // tbA
            // 
            this.tbA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bODEBindingSource, "A", true));
            this.tbA.EditValue = "Đáp án A...";
            this.tbA.Enabled = false;
            this.tbA.Location = new System.Drawing.Point(335, 37);
            this.tbA.MenuManager = this.barManager1;
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(153, 46);
            this.tbA.TabIndex = 10;
            // 
            // tbB
            // 
            this.tbB.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bODEBindingSource, "B", true));
            this.tbB.EditValue = "Đáp án B...";
            this.tbB.Enabled = false;
            this.tbB.Location = new System.Drawing.Point(335, 89);
            this.tbB.MenuManager = this.barManager1;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(153, 47);
            this.tbB.TabIndex = 12;
            // 
            // tbC
            // 
            this.tbC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bODEBindingSource, "C", true));
            this.tbC.EditValue = "Đáp án C...";
            this.tbC.Enabled = false;
            this.tbC.Location = new System.Drawing.Point(534, 37);
            this.tbC.MenuManager = this.barManager1;
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(153, 46);
            this.tbC.TabIndex = 14;
            // 
            // tbD
            // 
            this.tbD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bODEBindingSource, "D", true));
            this.tbD.EditValue = "Đáp án D...";
            this.tbD.Enabled = false;
            this.tbD.Location = new System.Drawing.Point(534, 93);
            this.tbD.MenuManager = this.barManager1;
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(153, 43);
            this.tbD.TabIndex = 16;
            // 
            // cbTrinhDo
            // 
            this.cbTrinhDo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bODEBindingSource, "TRINHDO", true));
            this.cbTrinhDo.EditValue = "A";
            this.cbTrinhDo.Enabled = false;
            this.cbTrinhDo.Location = new System.Drawing.Point(248, 116);
            this.cbTrinhDo.MenuManager = this.barManager1;
            this.cbTrinhDo.Name = "cbTrinhDo";
            this.cbTrinhDo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTrinhDo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbTrinhDo.Properties.DropDownRows = 3;
            this.cbTrinhDo.Properties.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbTrinhDo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTrinhDo.Size = new System.Drawing.Size(47, 20);
            this.cbTrinhDo.TabIndex = 6;
            // 
            // cbDa
            // 
            this.cbDa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bODEBindingSource, "DAP_AN", true));
            this.cbDa.EditValue = "A";
            this.cbDa.Enabled = false;
            this.cbDa.Location = new System.Drawing.Point(111, 116);
            this.cbDa.MenuManager = this.barManager1;
            this.cbDa.Name = "cbDa";
            this.cbDa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDa.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbDa.Properties.DropDownRows = 4;
            this.cbDa.Properties.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbDa.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbDa.Size = new System.Drawing.Size(48, 20);
            this.cbDa.TabIndex = 18;
            // 
            // frmBoDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bODEGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBoDe";
            this.Text = "frmBoDe";
            this.Load += new System.EventHandler(this.frmBoDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cHUYEN_DEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTrinhDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CHUYEN_DEDataSet cHUYEN_DEDataSet;
        private System.Windows.Forms.BindingSource bODEBindingSource;
        private CHUYEN_DEDataSetTableAdapters.BODETableAdapter bODETableAdapter;
        private CHUYEN_DEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl bODEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colACTIVE;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnHoanTat;
        private DevExpress.XtraEditors.MemoEdit tbNoiDung;
        private DevExpress.XtraEditors.MemoEdit tbA;
        private DevExpress.XtraEditors.MemoEdit tbB;
        private DevExpress.XtraEditors.MemoEdit tbC;
        private DevExpress.XtraEditors.MemoEdit tbD;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit cbTrinhDo;
        private DevExpress.XtraEditors.ComboBoxEdit cbDa;
    }
}