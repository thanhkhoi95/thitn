namespace THITN
{
    partial class frmChuanBiThi
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
            this.cHUYEN_DEDataSet = new THITN.CHUYEN_DEDataSet();
            this.giaovien_DangkyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giaovien_DangkyTableAdapter = new THITN.CHUYEN_DEDataSetTableAdapters.Giaovien_DangkyTableAdapter();
            this.tableAdapterManager = new THITN.CHUYEN_DEDataSetTableAdapters.TableAdapterManager();
            this.giaovien_DangkyGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbThoiGian = new System.Windows.Forms.TextBox();
            this.deNgayThi = new DevExpress.XtraEditors.DateEdit();
            this.tbSoCau = new System.Windows.Forms.TextBox();
            this.cbTrinhDo = new System.Windows.Forms.ComboBox();
            this.tbLanThi = new System.Windows.Forms.TextBox();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMaMH = new System.Windows.Forms.ComboBox();
            this.monhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monhocTableAdapter = new THITN.CHUYEN_DEDataSetTableAdapters.MonhocTableAdapter();
            this.lopTableAdapter = new THITN.CHUYEN_DEDataSetTableAdapters.LopTableAdapter();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.giaovienDangkyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cHUYEN_DEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaovien_DangkyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaovien_DangkyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaovienDangkyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cHUYEN_DEDataSet
            // 
            this.cHUYEN_DEDataSet.DataSetName = "CHUYEN_DEDataSet";
            this.cHUYEN_DEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaovien_DangkyBindingSource
            // 
            this.giaovien_DangkyBindingSource.DataMember = "Giaovien_Dangky";
            this.giaovien_DangkyBindingSource.DataSource = this.cHUYEN_DEDataSet;
            // 
            // giaovien_DangkyTableAdapter
            // 
            this.giaovien_DangkyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangDiemTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Giaovien_DangkyTableAdapter = this.giaovien_DangkyTableAdapter;
            this.tableAdapterManager.GiaovienTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonhocTableAdapter = null;
            this.tableAdapterManager.SinhvienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.CHUYEN_DEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // giaovien_DangkyGridControl
            // 
            this.giaovien_DangkyGridControl.DataSource = this.giaovienDangkyBindingSource;
            this.giaovien_DangkyGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.giaovien_DangkyGridControl.Location = new System.Drawing.Point(0, 0);
            this.giaovien_DangkyGridControl.MainView = this.gridView1;
            this.giaovien_DangkyGridControl.Name = "giaovien_DangkyGridControl";
            this.giaovien_DangkyGridControl.Size = new System.Drawing.Size(899, 226);
            this.giaovien_DangkyGridControl.TabIndex = 1;
            this.giaovien_DangkyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMALOP,
            this.colMAMH,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.gridView1.GridControl = this.giaovien_DangkyGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbThoiGian);
            this.panel1.Controls.Add(this.deNgayThi);
            this.panel1.Controls.Add(this.tbSoCau);
            this.panel1.Controls.Add(this.cbTrinhDo);
            this.panel1.Controls.Add(this.tbLanThi);
            this.panel1.Controls.Add(this.cbMaLop);
            this.panel1.Controls.Add(this.cbMaMH);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 172);
            this.panel1.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(802, 137);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Đăng kí";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbThoiGian
            // 
            this.tbThoiGian.Location = new System.Drawing.Point(606, 54);
            this.tbThoiGian.Name = "tbThoiGian";
            this.tbThoiGian.Size = new System.Drawing.Size(100, 20);
            this.tbThoiGian.TabIndex = 14;
            this.tbThoiGian.TextChanged += new System.EventHandler(this.tbThoiGian_TextChanged);
            // 
            // deNgayThi
            // 
            this.deNgayThi.EditValue = null;
            this.deNgayThi.Location = new System.Drawing.Point(419, 102);
            this.deNgayThi.Name = "deNgayThi";
            this.deNgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayThi.Size = new System.Drawing.Size(100, 20);
            this.deNgayThi.TabIndex = 13;
            // 
            // tbSoCau
            // 
            this.tbSoCau.Location = new System.Drawing.Point(419, 54);
            this.tbSoCau.Name = "tbSoCau";
            this.tbSoCau.Size = new System.Drawing.Size(103, 20);
            this.tbSoCau.TabIndex = 12;
            this.tbSoCau.TextChanged += new System.EventHandler(this.tbSoCau_TextChanged);
            // 
            // cbTrinhDo
            // 
            this.cbTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrinhDo.FormattingEnabled = true;
            this.cbTrinhDo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbTrinhDo.Location = new System.Drawing.Point(299, 102);
            this.cbTrinhDo.Name = "cbTrinhDo";
            this.cbTrinhDo.Size = new System.Drawing.Size(46, 21);
            this.cbTrinhDo.TabIndex = 11;
            // 
            // tbLanThi
            // 
            this.tbLanThi.Enabled = false;
            this.tbLanThi.Location = new System.Drawing.Point(299, 54);
            this.tbLanThi.Name = "tbLanThi";
            this.tbLanThi.Size = new System.Drawing.Size(46, 20);
            this.tbLanThi.TabIndex = 10;
            // 
            // cbMaLop
            // 
            this.cbMaLop.DataSource = this.lopBindingSource;
            this.cbMaLop.DisplayMember = "MALOP";
            this.cbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(111, 54);
            this.cbMaLop.MaxDropDownItems = 5;
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(121, 21);
            this.cbMaLop.TabIndex = 9;
            this.cbMaLop.ValueMember = "MALOP";
            this.cbMaLop.SelectedIndexChanged += new System.EventHandler(this.cbMaLop_SelectedIndexChanged);
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.cHUYEN_DEDataSet;
            // 
            // cbMaMH
            // 
            this.cbMaMH.DataSource = this.monhocBindingSource;
            this.cbMaMH.DisplayMember = "MAMH";
            this.cbMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaMH.FormattingEnabled = true;
            this.cbMaMH.Location = new System.Drawing.Point(111, 102);
            this.cbMaMH.MaxDropDownItems = 5;
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Size = new System.Drawing.Size(121, 21);
            this.cbMaMH.TabIndex = 8;
            this.cbMaMH.ValueMember = "MAMH";
            this.cbMaMH.SelectedIndexChanged += new System.EventHandler(this.cbMaMH_SelectedIndexChanged);
            // 
            // monhocBindingSource
            // 
            this.monhocBindingSource.DataMember = "Monhoc";
            this.monhocBindingSource.DataSource = this.cHUYEN_DEDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Chuẩn bị thi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thời gian thi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày thi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số câu thi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lần thi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trình độ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã môn học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp:";
            // 
            // monhocTableAdapter
            // 
            this.monhocTableAdapter.ClearBeforeFill = true;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 1;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 2;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 5;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 6;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 7;
            // 
            // giaovienDangkyBindingSource
            // 
            this.giaovienDangkyBindingSource.DataMember = "Giaovien_Dangky";
            this.giaovienDangkyBindingSource.DataSource = this.cHUYEN_DEDataSet;
            // 
            // frmChuanBiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.giaovien_DangkyGridControl);
            this.Name = "frmChuanBiThi";
            this.Text = "frmChuanBiThi";
            this.Load += new System.EventHandler(this.frmChuanBiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cHUYEN_DEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaovien_DangkyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaovien_DangkyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaovienDangkyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CHUYEN_DEDataSet cHUYEN_DEDataSet;
        private System.Windows.Forms.BindingSource giaovien_DangkyBindingSource;
        private CHUYEN_DEDataSetTableAdapters.Giaovien_DangkyTableAdapter giaovien_DangkyTableAdapter;
        private CHUYEN_DEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl giaovien_DangkyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMaMH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource monhocBindingSource;
        private CHUYEN_DEDataSetTableAdapters.MonhocTableAdapter monhocTableAdapter;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private CHUYEN_DEDataSetTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbThoiGian;
        private DevExpress.XtraEditors.DateEdit deNgayThi;
        private System.Windows.Forms.TextBox tbSoCau;
        private System.Windows.Forms.ComboBox cbTrinhDo;
        private System.Windows.Forms.TextBox tbLanThi;
        private System.Windows.Forms.Button btnThoat;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private System.Windows.Forms.BindingSource giaovienDangkyBindingSource;
    }
}