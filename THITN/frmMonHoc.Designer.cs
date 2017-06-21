namespace THITN
{
    partial class frmMonHoc
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
            this.cHUYEN_DEDataSet = new THITN.CHUYEN_DEDataSet();
            this.monhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monhocTableAdapter = new THITN.CHUYEN_DEDataSetTableAdapters.MonhocTableAdapter();
            this.tableAdapterManager = new THITN.CHUYEN_DEDataSetTableAdapters.TableAdapterManager();
            this.monhocGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACTIVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.tbTenMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.cHUYENDEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUYEN_DEDataSet1 = new THITN.CHUYEN_DEDataSet();
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
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYEN_DEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENDEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYEN_DEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            mAMHLabel.Location = new System.Drawing.Point(24, 47);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(68, 13);
            mAMHLabel.TabIndex = 5;
            mAMHLabel.Text = "Mã môn học:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tENMHLabel.Location = new System.Drawing.Point(223, 47);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(72, 13);
            tENMHLabel.TabIndex = 7;
            tENMHLabel.Text = "Tên môn học:";
            // 
            // cHUYEN_DEDataSet
            // 
            this.cHUYEN_DEDataSet.DataSetName = "CHUYEN_DEDataSet";
            this.cHUYEN_DEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monhocBindingSource
            // 
            this.monhocBindingSource.DataMember = "Monhoc";
            this.monhocBindingSource.DataSource = this.cHUYEN_DEDataSet;
            // 
            // monhocTableAdapter
            // 
            this.monhocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangDiemTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Giaovien_DangkyTableAdapter = null;
            this.tableAdapterManager.GiaovienTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonhocTableAdapter = this.monhocTableAdapter;
            this.tableAdapterManager.SinhvienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.CHUYEN_DEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // monhocGridControl
            // 
            this.monhocGridControl.DataSource = this.monhocBindingSource;
            this.monhocGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            gridLevelNode1.RelationName = "Level1";
            this.monhocGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.monhocGridControl.Location = new System.Drawing.Point(0, 24);
            this.monhocGridControl.MainView = this.gridView1;
            this.monhocGridControl.Name = "monhocGridControl";
            this.monhocGridControl.Size = new System.Drawing.Size(1168, 405);
            this.monhocGridControl.TabIndex = 1;
            this.monhocGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colACTIVE});
            this.gridView1.GridControl = this.monhocGridControl;
            this.gridView1.Name = "gridView1";
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
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTENMH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTENMH.OptionsColumn.AllowMove = false;
            this.colTENMH.OptionsColumn.AllowShowHide = false;
            this.colTENMH.OptionsColumn.ShowInCustomizationForm = false;
            this.colTENMH.OptionsColumn.ShowInExpressionEditor = false;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
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
            this.colACTIVE.VisibleIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnHoanTat);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(mAMHLabel);
            this.panel2.Controls.Add(this.tbMaMonHoc);
            this.panel2.Controls.Add(tENMHLabel);
            this.panel2.Controls.Add(this.tbTenMonHoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 139);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Enabled = false;
            this.btnHoanTat.Location = new System.Drawing.Point(872, 101);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(101, 30);
            this.btnHoanTat.TabIndex = 11;
            this.btnHoanTat.Text = "Hoàn  tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoantat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(1019, 101);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 30);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thông tin chi tiết:";
            // 
            // tbMaMonHoc
            // 
            this.tbMaMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monhocBindingSource, "MAMH", true));
            this.tbMaMonHoc.Enabled = false;
            this.tbMaMonHoc.Location = new System.Drawing.Point(98, 44);
            this.tbMaMonHoc.Name = "tbMaMonHoc";
            this.tbMaMonHoc.Size = new System.Drawing.Size(100, 20);
            this.tbMaMonHoc.TabIndex = 6;
            // 
            // tbTenMonHoc
            // 
            this.tbTenMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monhocBindingSource, "TENMH", true));
            this.tbTenMonHoc.Enabled = false;
            this.tbTenMonHoc.Location = new System.Drawing.Point(301, 44);
            this.tbTenMonHoc.Name = "tbTenMonHoc";
            this.tbTenMonHoc.Size = new System.Drawing.Size(100, 20);
            this.tbTenMonHoc.TabIndex = 8;
            // 
            // cHUYENDEDataSetBindingSource
            // 
            this.cHUYENDEDataSetBindingSource.DataSource = this.cHUYEN_DEDataSet;
            this.cHUYENDEDataSetBindingSource.Position = 0;
            // 
            // cHUYEN_DEDataSet1
            // 
            this.cHUYEN_DEDataSet1.DataSetName = "CHUYEN_DEDataSet";
            this.cHUYEN_DEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.KeyTip))), this.btnThem, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph, "", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSua.Glyph")));
            this.btnSua.Id = 1;
            this.btnSua.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSua.LargeGlyph")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 2;
            this.btnXoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.LargeGlyph")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.Glyph")));
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.LargeGlyph")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
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
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1168, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 572);
            this.barDockControlBottom.Size = new System.Drawing.Size(1168, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 548);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1168, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 548);
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1168, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.monhocGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "frmMonHoc";
            this.Text = "frmMonHoc";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cHUYEN_DEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENDEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYEN_DEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CHUYEN_DEDataSet cHUYEN_DEDataSet;
        private System.Windows.Forms.BindingSource monhocBindingSource;
        private CHUYEN_DEDataSetTableAdapters.MonhocTableAdapter monhocTableAdapter;
        private CHUYEN_DEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl monhocGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colACTIVE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit tbMaMonHoc;
        private DevExpress.XtraEditors.TextEdit tbTenMonHoc;
        private System.Windows.Forms.BindingSource cHUYENDEDataSetBindingSource;
        private CHUYEN_DEDataSet cHUYEN_DEDataSet1;
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
    }
}