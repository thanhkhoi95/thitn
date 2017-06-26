namespace THITN
{
    partial class frmThongTinThi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cHUYEN_DEDataSet = new THITN.CHUYEN_DEDataSet();
            this.monhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monhocTableAdapter = new THITN.CHUYEN_DEDataSetTableAdapters.MonhocTableAdapter();
            this.tableAdapterManager = new THITN.CHUYEN_DEDataSetTableAdapters.TableAdapterManager();
            this.cbMaMH = new DevExpress.XtraEditors.ComboBoxEdit();
            this.deNgayThi = new DevExpress.XtraEditors.DateEdit();
            this.cbLanThi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBatDauThi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbCTThoiGian = new System.Windows.Forms.Label();
            this.lbCTSoCau = new System.Windows.Forms.Label();
            this.lbCTNgayThi = new System.Windows.Forms.Label();
            this.lbCTLanThi = new System.Windows.Forms.Label();
            this.lbCTTrinhDo = new System.Windows.Forms.Label();
            this.lbCTLop = new System.Windows.Forms.Label();
            this.lbCTMH = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYEN_DEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayThi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            mAMHLabel.Location = new System.Drawing.Point(38, 138);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(83, 16);
            mAMHLabel.TabIndex = 1;
            mAMHLabel.Text = "Mã môn học:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lbCTMH);
            this.panel1.Controls.Add(this.lbCTLop);
            this.panel1.Controls.Add(this.lbCTTrinhDo);
            this.panel1.Controls.Add(this.lbCTLanThi);
            this.panel1.Controls.Add(this.lbCTNgayThi);
            this.panel1.Controls.Add(this.lbCTSoCau);
            this.panel1.Controls.Add(this.lbCTThoiGian);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnBatDauThi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(329, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 381);
            this.panel1.TabIndex = 0;
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
            // cbMaMH
            // 
            this.cbMaMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monhocBindingSource, "MAMH", true));
            this.cbMaMH.Location = new System.Drawing.Point(144, 137);
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMaMH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbMaMH.Size = new System.Drawing.Size(121, 20);
            this.cbMaMH.TabIndex = 2;
            // 
            // deNgayThi
            // 
            this.deNgayThi.EditValue = null;
            this.deNgayThi.Location = new System.Drawing.Point(144, 195);
            this.deNgayThi.Name = "deNgayThi";
            this.deNgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayThi.Size = new System.Drawing.Size(121, 20);
            this.deNgayThi.TabIndex = 3;
            // 
            // cbLanThi
            // 
            this.cbLanThi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbLanThi.FormattingEnabled = true;
            this.cbLanThi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbLanThi.Location = new System.Drawing.Point(144, 247);
            this.cbLanThi.Name = "cbLanThi";
            this.cbLanThi.Size = new System.Drawing.Size(121, 21);
            this.cbLanThi.Sorted = true;
            this.cbLanThi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(38, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ngày thi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(38, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lần thi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(38, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã sinh viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(38, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã lớp:";
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaSV.Location = new System.Drawing.Point(141, 32);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(0, 16);
            this.lbMaSV.TabIndex = 9;
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaLop.Location = new System.Drawing.Point(141, 81);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(0, 16);
            this.lbMaLop.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Xem thông tin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(173, 346);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBatDauThi
            // 
            this.btnBatDauThi.Enabled = false;
            this.btnBatDauThi.Location = new System.Drawing.Point(259, 346);
            this.btnBatDauThi.Name = "btnBatDauThi";
            this.btnBatDauThi.Size = new System.Drawing.Size(90, 23);
            this.btnBatDauThi.TabIndex = 0;
            this.btnBatDauThi.Text = "Bắt đầu thi";
            this.btnBatDauThi.UseVisualStyleBackColor = true;
            this.btnBatDauThi.Click += new System.EventHandler(this.btnBatDauThi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(139, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Thông tin kì thi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(75, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Môn học:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(75, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lớp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(75, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Lần thi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(75, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ngày thi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(75, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Thời gian thi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(75, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Số câu thi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(75, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Trình độ:";
            // 
            // lbCTThoiGian
            // 
            this.lbCTThoiGian.AutoSize = true;
            this.lbCTThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCTThoiGian.Location = new System.Drawing.Point(158, 292);
            this.lbCTThoiGian.Name = "lbCTThoiGian";
            this.lbCTThoiGian.Size = new System.Drawing.Size(52, 16);
            this.lbCTThoiGian.TabIndex = 9;
            this.lbCTThoiGian.Text = "label13";
            // 
            // lbCTSoCau
            // 
            this.lbCTSoCau.AutoSize = true;
            this.lbCTSoCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCTSoCau.Location = new System.Drawing.Point(158, 253);
            this.lbCTSoCau.Name = "lbCTSoCau";
            this.lbCTSoCau.Size = new System.Drawing.Size(52, 16);
            this.lbCTSoCau.TabIndex = 10;
            this.lbCTSoCau.Text = "label14";
            // 
            // lbCTNgayThi
            // 
            this.lbCTNgayThi.AutoSize = true;
            this.lbCTNgayThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCTNgayThi.Location = new System.Drawing.Point(158, 212);
            this.lbCTNgayThi.Name = "lbCTNgayThi";
            this.lbCTNgayThi.Size = new System.Drawing.Size(52, 16);
            this.lbCTNgayThi.TabIndex = 11;
            this.lbCTNgayThi.Text = "label15";
            // 
            // lbCTLanThi
            // 
            this.lbCTLanThi.AutoSize = true;
            this.lbCTLanThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCTLanThi.Location = new System.Drawing.Point(158, 174);
            this.lbCTLanThi.Name = "lbCTLanThi";
            this.lbCTLanThi.Size = new System.Drawing.Size(52, 16);
            this.lbCTLanThi.TabIndex = 12;
            this.lbCTLanThi.Text = "label16";
            // 
            // lbCTTrinhDo
            // 
            this.lbCTTrinhDo.AutoSize = true;
            this.lbCTTrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCTTrinhDo.Location = new System.Drawing.Point(158, 140);
            this.lbCTTrinhDo.Name = "lbCTTrinhDo";
            this.lbCTTrinhDo.Size = new System.Drawing.Size(52, 16);
            this.lbCTTrinhDo.TabIndex = 13;
            this.lbCTTrinhDo.Text = "label17";
            // 
            // lbCTLop
            // 
            this.lbCTLop.AutoSize = true;
            this.lbCTLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCTLop.Location = new System.Drawing.Point(158, 105);
            this.lbCTLop.Name = "lbCTLop";
            this.lbCTLop.Size = new System.Drawing.Size(52, 16);
            this.lbCTLop.TabIndex = 14;
            this.lbCTLop.Text = "label18";
            // 
            // lbCTMH
            // 
            this.lbCTMH.AutoSize = true;
            this.lbCTMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCTMH.Location = new System.Drawing.Point(158, 72);
            this.lbCTMH.Name = "lbCTMH";
            this.lbCTMH.Size = new System.Drawing.Size(52, 16);
            this.lbCTMH.TabIndex = 15;
            this.lbCTMH.Text = "label19";
            // 
            // frmThongTinThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 381);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbMaLop);
            this.Controls.Add(this.lbMaSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLanThi);
            this.Controls.Add(this.deNgayThi);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.cbMaMH);
            this.Controls.Add(this.panel1);
            this.Name = "frmThongTinThi";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmThongTinThi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYEN_DEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayThi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CHUYEN_DEDataSet cHUYEN_DEDataSet;
        private System.Windows.Forms.BindingSource monhocBindingSource;
        private CHUYEN_DEDataSetTableAdapters.MonhocTableAdapter monhocTableAdapter;
        private CHUYEN_DEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.ComboBoxEdit cbMaMH;
        private DevExpress.XtraEditors.DateEdit deNgayThi;
        private System.Windows.Forms.ComboBox cbLanThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBatDauThi;
        private System.Windows.Forms.Label lbCTMH;
        private System.Windows.Forms.Label lbCTLop;
        private System.Windows.Forms.Label lbCTTrinhDo;
        private System.Windows.Forms.Label lbCTLanThi;
        private System.Windows.Forms.Label lbCTNgayThi;
        private System.Windows.Forms.Label lbCTSoCau;
        private System.Windows.Forms.Label lbCTThoiGian;
    }
}