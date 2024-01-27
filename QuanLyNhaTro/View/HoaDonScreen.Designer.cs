using QuanLyNhaTro.DataSet;

namespace QuanLyNhaTro
{
    partial class HoaDonScreen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sendMail = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_GiaKhac = new System.Windows.Forms.TextBox();
            this.txt_GiaNuoc = new System.Windows.Forms.TextBox();
            this.txt_SoNuoc = new System.Windows.Forms.TextBox();
            this.txt_ghiChu = new System.Windows.Forms.TextBox();
            this.txt_GiaDien = new System.Windows.Forms.TextBox();
            this.txt_SoDienMoi = new System.Windows.Forms.TextBox();
            this.txt_SoPhong = new System.Windows.Forms.TextBox();
            this.txt_HoaDonID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.hoaDonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soHopDongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienCuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienMoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDichVuKhacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDon = new QuanLyNhaTro.DataSet.HoaDon();
            this.hoaDonTableAdapter = new QuanLyNhaTro.DataSet.HoaDonTableAdapters.HoaDonTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_sendMail);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.txt_GiaKhac);
            this.groupBox1.Controls.Add(this.txt_GiaNuoc);
            this.groupBox1.Controls.Add(this.txt_SoNuoc);
            this.groupBox1.Controls.Add(this.txt_ghiChu);
            this.groupBox1.Controls.Add(this.txt_GiaDien);
            this.groupBox1.Controls.Add(this.txt_SoDienMoi);
            this.groupBox1.Controls.Add(this.txt_SoPhong);
            this.groupBox1.Controls.Add(this.txt_HoaDonID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1195, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btn_sendMail
            // 
            this.btn_sendMail.Location = new System.Drawing.Point(82, 223);
            this.btn_sendMail.Name = "btn_sendMail";
            this.btn_sendMail.Size = new System.Drawing.Size(179, 39);
            this.btn_sendMail.TabIndex = 8;
            this.btn_sendMail.Text = "Gửi Mail Hoá Đơn";
            this.btn_sendMail.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(824, 223);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(136, 39);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(545, 223);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(136, 39);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(313, 223);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(136, 39);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_GiaKhac
            // 
            this.txt_GiaKhac.Location = new System.Drawing.Point(908, 168);
            this.txt_GiaKhac.Name = "txt_GiaKhac";
            this.txt_GiaKhac.Size = new System.Drawing.Size(136, 30);
            this.txt_GiaKhac.TabIndex = 7;
            // 
            // txt_GiaNuoc
            // 
            this.txt_GiaNuoc.Location = new System.Drawing.Point(908, 104);
            this.txt_GiaNuoc.Name = "txt_GiaNuoc";
            this.txt_GiaNuoc.Size = new System.Drawing.Size(136, 30);
            this.txt_GiaNuoc.TabIndex = 6;
            // 
            // txt_SoNuoc
            // 
            this.txt_SoNuoc.Location = new System.Drawing.Point(908, 45);
            this.txt_SoNuoc.Name = "txt_SoNuoc";
            this.txt_SoNuoc.Size = new System.Drawing.Size(136, 30);
            this.txt_SoNuoc.TabIndex = 5;
            // 
            // txt_ghiChu
            // 
            this.txt_ghiChu.Location = new System.Drawing.Point(506, 168);
            this.txt_ghiChu.Name = "txt_ghiChu";
            this.txt_ghiChu.Size = new System.Drawing.Size(136, 30);
            this.txt_ghiChu.TabIndex = 4;
            // 
            // txt_GiaDien
            // 
            this.txt_GiaDien.Location = new System.Drawing.Point(506, 112);
            this.txt_GiaDien.Name = "txt_GiaDien";
            this.txt_GiaDien.Size = new System.Drawing.Size(136, 30);
            this.txt_GiaDien.TabIndex = 3;
            // 
            // txt_SoDienMoi
            // 
            this.txt_SoDienMoi.Location = new System.Drawing.Point(506, 50);
            this.txt_SoDienMoi.Name = "txt_SoDienMoi";
            this.txt_SoDienMoi.Size = new System.Drawing.Size(136, 30);
            this.txt_SoDienMoi.TabIndex = 2;
            // 
            // txt_SoPhong
            // 
            this.txt_SoPhong.Location = new System.Drawing.Point(174, 112);
            this.txt_SoPhong.Name = "txt_SoPhong";
            this.txt_SoPhong.Size = new System.Drawing.Size(136, 30);
            this.txt_SoPhong.TabIndex = 1;
            // 
            // txt_HoaDonID
            // 
            this.txt_HoaDonID.Location = new System.Drawing.Point(174, 50);
            this.txt_HoaDonID.Name = "txt_HoaDonID";
            this.txt_HoaDonID.Size = new System.Drawing.Size(136, 30);
            this.txt_HoaDonID.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ghi Chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(722, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giá Dịch Vụ Khác";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(722, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giá Nước";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(722, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Nước";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá Điện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện Mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoá Đơn ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_HoaDon);
            this.groupBox2.Location = new System.Drawing.Point(1, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1195, 392);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Hoá Đơn";
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AutoGenerateColumns = false;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoaDonIDDataGridViewTextBoxColumn,
            this.soHopDongDataGridViewTextBoxColumn,
            this.soPhongDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.thangLapDataGridViewTextBoxColumn,
            this.namLapDataGridViewTextBoxColumn,
            this.soDienCuDataGridViewTextBoxColumn,
            this.soDienMoiDataGridViewTextBoxColumn,
            this.giaDienDataGridViewTextBoxColumn,
            this.giaNuocDataGridViewTextBoxColumn,
            this.soNuocDataGridViewTextBoxColumn,
            this.giaDichVuKhacDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn});
            this.dgv_HoaDon.DataSource = this.hoaDonBindingSource;
            this.dgv_HoaDon.Location = new System.Drawing.Point(3, 29);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowHeadersWidth = 51;
            this.dgv_HoaDon.RowTemplate.Height = 24;
            this.dgv_HoaDon.Size = new System.Drawing.Size(1192, 363);
            this.dgv_HoaDon.TabIndex = 0;
            this.dgv_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellClick);
            // 
            // hoaDonIDDataGridViewTextBoxColumn
            // 
            this.hoaDonIDDataGridViewTextBoxColumn.DataPropertyName = "HoaDonID";
            this.hoaDonIDDataGridViewTextBoxColumn.HeaderText = "HoaDonID";
            this.hoaDonIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoaDonIDDataGridViewTextBoxColumn.Name = "hoaDonIDDataGridViewTextBoxColumn";
            this.hoaDonIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // soHopDongDataGridViewTextBoxColumn
            // 
            this.soHopDongDataGridViewTextBoxColumn.DataPropertyName = "SoHopDong";
            this.soHopDongDataGridViewTextBoxColumn.HeaderText = "SoHopDong";
            this.soHopDongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soHopDongDataGridViewTextBoxColumn.Name = "soHopDongDataGridViewTextBoxColumn";
            this.soHopDongDataGridViewTextBoxColumn.Width = 125;
            // 
            // soPhongDataGridViewTextBoxColumn
            // 
            this.soPhongDataGridViewTextBoxColumn.DataPropertyName = "SoPhong";
            this.soPhongDataGridViewTextBoxColumn.HeaderText = "SoPhong";
            this.soPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soPhongDataGridViewTextBoxColumn.Name = "soPhongDataGridViewTextBoxColumn";
            this.soPhongDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.Width = 125;
            // 
            // thangLapDataGridViewTextBoxColumn
            // 
            this.thangLapDataGridViewTextBoxColumn.DataPropertyName = "ThangLap";
            this.thangLapDataGridViewTextBoxColumn.HeaderText = "ThangLap";
            this.thangLapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thangLapDataGridViewTextBoxColumn.Name = "thangLapDataGridViewTextBoxColumn";
            this.thangLapDataGridViewTextBoxColumn.Width = 125;
            // 
            // namLapDataGridViewTextBoxColumn
            // 
            this.namLapDataGridViewTextBoxColumn.DataPropertyName = "NamLap";
            this.namLapDataGridViewTextBoxColumn.HeaderText = "NamLap";
            this.namLapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namLapDataGridViewTextBoxColumn.Name = "namLapDataGridViewTextBoxColumn";
            this.namLapDataGridViewTextBoxColumn.Width = 125;
            // 
            // soDienCuDataGridViewTextBoxColumn
            // 
            this.soDienCuDataGridViewTextBoxColumn.DataPropertyName = "SoDienCu";
            this.soDienCuDataGridViewTextBoxColumn.HeaderText = "SoDienCu";
            this.soDienCuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDienCuDataGridViewTextBoxColumn.Name = "soDienCuDataGridViewTextBoxColumn";
            this.soDienCuDataGridViewTextBoxColumn.Width = 125;
            // 
            // soDienMoiDataGridViewTextBoxColumn
            // 
            this.soDienMoiDataGridViewTextBoxColumn.DataPropertyName = "SoDienMoi";
            this.soDienMoiDataGridViewTextBoxColumn.HeaderText = "SoDienMoi";
            this.soDienMoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDienMoiDataGridViewTextBoxColumn.Name = "soDienMoiDataGridViewTextBoxColumn";
            this.soDienMoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaDienDataGridViewTextBoxColumn
            // 
            this.giaDienDataGridViewTextBoxColumn.DataPropertyName = "GiaDien";
            this.giaDienDataGridViewTextBoxColumn.HeaderText = "GiaDien";
            this.giaDienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaDienDataGridViewTextBoxColumn.Name = "giaDienDataGridViewTextBoxColumn";
            this.giaDienDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaNuocDataGridViewTextBoxColumn
            // 
            this.giaNuocDataGridViewTextBoxColumn.DataPropertyName = "GiaNuoc";
            this.giaNuocDataGridViewTextBoxColumn.HeaderText = "GiaNuoc";
            this.giaNuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaNuocDataGridViewTextBoxColumn.Name = "giaNuocDataGridViewTextBoxColumn";
            this.giaNuocDataGridViewTextBoxColumn.Width = 125;
            // 
            // soNuocDataGridViewTextBoxColumn
            // 
            this.soNuocDataGridViewTextBoxColumn.DataPropertyName = "SoNuoc";
            this.soNuocDataGridViewTextBoxColumn.HeaderText = "SoNuoc";
            this.soNuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soNuocDataGridViewTextBoxColumn.Name = "soNuocDataGridViewTextBoxColumn";
            this.soNuocDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaDichVuKhacDataGridViewTextBoxColumn
            // 
            this.giaDichVuKhacDataGridViewTextBoxColumn.DataPropertyName = "GiaDichVuKhac";
            this.giaDichVuKhacDataGridViewTextBoxColumn.HeaderText = "GiaDichVuKhac";
            this.giaDichVuKhacDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaDichVuKhacDataGridViewTextBoxColumn.Name = "giaDichVuKhacDataGridViewTextBoxColumn";
            this.giaDichVuKhacDataGridViewTextBoxColumn.Width = 125;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.ReadOnly = true;
            this.tongTienDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.hoaDon;
            // 
            // hoaDon
            // 
            this.hoaDon.DataSetName = "HoaDon";
            this.hoaDon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // HoaDonScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "HoaDonScreen";
            this.Text = "HoaDonScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HoaDonScreen_FormClosing);
            this.Load += new System.EventHandler(this.HoaDonScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_GiaKhac;
        private System.Windows.Forms.TextBox txt_GiaNuoc;
        private System.Windows.Forms.TextBox txt_SoNuoc;
        private System.Windows.Forms.TextBox txt_ghiChu;
        private System.Windows.Forms.TextBox txt_GiaDien;
        private System.Windows.Forms.TextBox txt_SoDienMoi;
        private System.Windows.Forms.TextBox txt_SoPhong;
        private System.Windows.Forms.TextBox txt_HoaDonID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DataSet.HoaDon hoaDon;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private DataSet.HoaDonTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoaDonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHopDongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienCuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienMoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDichVuKhacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sendMail;
    }
}