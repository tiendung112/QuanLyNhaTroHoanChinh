namespace QuanLyNhaTro
{
    partial class HopDongScreen
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
            this.btn_traPhong = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_TienCoc = new System.Windows.Forms.TextBox();
            this.dtp_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.txt_soLuongNguoi = new System.Windows.Forms.TextBox();
            this.txt_SoPhong = new System.Windows.Forms.TextBox();
            this.txt_KhachThueID = new System.Windows.Forms.TextBox();
            this.txt_soHopDong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Hopdong = new System.Windows.Forms.DataGridView();
            this.soHopDongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachThueIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongNguoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiThueDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tienCocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaThueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hopDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhaTroDataSet = new QuanLyNhaTro.DataSet.QuanLyNhaTroDataSet();
            this.hopDongTableAdapter = new QuanLyNhaTro.DataSet.QuanLyNhaTroDataSetTableAdapters.HopDongTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hopdong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopDongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaTroDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_traPhong);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.txt_TienCoc);
            this.groupBox1.Controls.Add(this.dtp_TuNgay);
            this.groupBox1.Controls.Add(this.dtp_NgayTra);
            this.groupBox1.Controls.Add(this.txt_soLuongNguoi);
            this.groupBox1.Controls.Add(this.txt_SoPhong);
            this.groupBox1.Controls.Add(this.txt_KhachThueID);
            this.groupBox1.Controls.Add(this.txt_soHopDong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1189, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btn_traPhong
            // 
            this.btn_traPhong.Location = new System.Drawing.Point(61, 238);
            this.btn_traPhong.Name = "btn_traPhong";
            this.btn_traPhong.Size = new System.Drawing.Size(181, 43);
            this.btn_traPhong.TabIndex = 8;
            this.btn_traPhong.Text = "Trả Phòng";
            this.btn_traPhong.UseVisualStyleBackColor = true;
            this.btn_traPhong.Click += new System.EventHandler(this.btn_traPhong_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(862, 238);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(181, 43);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(521, 238);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(181, 43);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(290, 238);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(181, 43);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_TienCoc
            // 
            this.txt_TienCoc.Location = new System.Drawing.Point(539, 149);
            this.txt_TienCoc.Name = "txt_TienCoc";
            this.txt_TienCoc.Size = new System.Drawing.Size(163, 30);
            this.txt_TienCoc.TabIndex = 4;
            // 
            // dtp_TuNgay
            // 
            this.dtp_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_TuNgay.Location = new System.Drawing.Point(878, 79);
            this.dtp_TuNgay.Name = "dtp_TuNgay";
            this.dtp_TuNgay.Size = new System.Drawing.Size(165, 30);
            this.dtp_TuNgay.TabIndex = 6;
            // 
            // dtp_NgayTra
            // 
            this.dtp_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayTra.Location = new System.Drawing.Point(878, 146);
            this.dtp_NgayTra.Name = "dtp_NgayTra";
            this.dtp_NgayTra.Size = new System.Drawing.Size(165, 30);
            this.dtp_NgayTra.TabIndex = 7;
            // 
            // txt_soLuongNguoi
            // 
            this.txt_soLuongNguoi.Location = new System.Drawing.Point(539, 79);
            this.txt_soLuongNguoi.Name = "txt_soLuongNguoi";
            this.txt_soLuongNguoi.Size = new System.Drawing.Size(163, 30);
            this.txt_soLuongNguoi.TabIndex = 3;
            // 
            // txt_SoPhong
            // 
            this.txt_SoPhong.Location = new System.Drawing.Point(188, 174);
            this.txt_SoPhong.Name = "txt_SoPhong";
            this.txt_SoPhong.Size = new System.Drawing.Size(163, 30);
            this.txt_SoPhong.TabIndex = 2;
            // 
            // txt_KhachThueID
            // 
            this.txt_KhachThueID.Location = new System.Drawing.Point(188, 114);
            this.txt_KhachThueID.Name = "txt_KhachThueID";
            this.txt_KhachThueID.Size = new System.Drawing.Size(164, 30);
            this.txt_KhachThueID.TabIndex = 1;
            // 
            // txt_soHopDong
            // 
            this.txt_soHopDong.Location = new System.Drawing.Point(188, 50);
            this.txt_soHopDong.Name = "txt_soHopDong";
            this.txt_soHopDong.Size = new System.Drawing.Size(164, 30);
            this.txt_soHopDong.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tiền Cọc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(746, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày Trả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(746, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Từ Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lượng Người";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách Thuê ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Hợp Đồng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Hopdong);
            this.groupBox2.Location = new System.Drawing.Point(5, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1189, 368);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "danh sách hợp đồng";
            // 
            // dgv_Hopdong
            // 
            this.dgv_Hopdong.AutoGenerateColumns = false;
            this.dgv_Hopdong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hopdong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soHopDongDataGridViewTextBoxColumn,
            this.khachThueIDDataGridViewTextBoxColumn,
            this.soPhongDataGridViewTextBoxColumn,
            this.soLuongNguoiDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.tuNgayDataGridViewTextBoxColumn,
            this.ngayTraPhongDataGridViewTextBoxColumn,
            this.trangThaiThueDataGridViewCheckBoxColumn,
            this.tienCocDataGridViewTextBoxColumn,
            this.giaThueDataGridViewTextBoxColumn});
            this.dgv_Hopdong.DataSource = this.hopDongBindingSource;
            this.dgv_Hopdong.Location = new System.Drawing.Point(3, 26);
            this.dgv_Hopdong.Name = "dgv_Hopdong";
            this.dgv_Hopdong.RowHeadersWidth = 51;
            this.dgv_Hopdong.RowTemplate.Height = 24;
            this.dgv_Hopdong.Size = new System.Drawing.Size(1186, 342);
            this.dgv_Hopdong.TabIndex = 0;
            this.dgv_Hopdong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hopdong_CellClick);
            // 
            // soHopDongDataGridViewTextBoxColumn
            // 
            this.soHopDongDataGridViewTextBoxColumn.DataPropertyName = "SoHopDong";
            this.soHopDongDataGridViewTextBoxColumn.HeaderText = "SoHopDong";
            this.soHopDongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soHopDongDataGridViewTextBoxColumn.Name = "soHopDongDataGridViewTextBoxColumn";
            this.soHopDongDataGridViewTextBoxColumn.Width = 125;
            // 
            // khachThueIDDataGridViewTextBoxColumn
            // 
            this.khachThueIDDataGridViewTextBoxColumn.DataPropertyName = "KhachThueID";
            this.khachThueIDDataGridViewTextBoxColumn.HeaderText = "KhachThueID";
            this.khachThueIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.khachThueIDDataGridViewTextBoxColumn.Name = "khachThueIDDataGridViewTextBoxColumn";
            this.khachThueIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // soPhongDataGridViewTextBoxColumn
            // 
            this.soPhongDataGridViewTextBoxColumn.DataPropertyName = "SoPhong";
            this.soPhongDataGridViewTextBoxColumn.HeaderText = "SoPhong";
            this.soPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soPhongDataGridViewTextBoxColumn.Name = "soPhongDataGridViewTextBoxColumn";
            this.soPhongDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongNguoiDataGridViewTextBoxColumn
            // 
            this.soLuongNguoiDataGridViewTextBoxColumn.DataPropertyName = "SoLuongNguoi";
            this.soLuongNguoiDataGridViewTextBoxColumn.HeaderText = "SoLuongNguoi";
            this.soLuongNguoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongNguoiDataGridViewTextBoxColumn.Name = "soLuongNguoiDataGridViewTextBoxColumn";
            this.soLuongNguoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.Width = 125;
            // 
            // tuNgayDataGridViewTextBoxColumn
            // 
            this.tuNgayDataGridViewTextBoxColumn.DataPropertyName = "TuNgay";
            this.tuNgayDataGridViewTextBoxColumn.HeaderText = "TuNgay";
            this.tuNgayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tuNgayDataGridViewTextBoxColumn.Name = "tuNgayDataGridViewTextBoxColumn";
            this.tuNgayDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayTraPhongDataGridViewTextBoxColumn
            // 
            this.ngayTraPhongDataGridViewTextBoxColumn.DataPropertyName = "NgayTraPhong";
            this.ngayTraPhongDataGridViewTextBoxColumn.HeaderText = "NgayTraPhong";
            this.ngayTraPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTraPhongDataGridViewTextBoxColumn.Name = "ngayTraPhongDataGridViewTextBoxColumn";
            this.ngayTraPhongDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangThaiThueDataGridViewCheckBoxColumn
            // 
            this.trangThaiThueDataGridViewCheckBoxColumn.DataPropertyName = "TrangThaiThue";
            this.trangThaiThueDataGridViewCheckBoxColumn.HeaderText = "TrangThaiThue";
            this.trangThaiThueDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.trangThaiThueDataGridViewCheckBoxColumn.Name = "trangThaiThueDataGridViewCheckBoxColumn";
            this.trangThaiThueDataGridViewCheckBoxColumn.Width = 125;
            // 
            // tienCocDataGridViewTextBoxColumn
            // 
            this.tienCocDataGridViewTextBoxColumn.DataPropertyName = "TienCoc";
            this.tienCocDataGridViewTextBoxColumn.HeaderText = "TienCoc";
            this.tienCocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienCocDataGridViewTextBoxColumn.Name = "tienCocDataGridViewTextBoxColumn";
            this.tienCocDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaThueDataGridViewTextBoxColumn
            // 
            this.giaThueDataGridViewTextBoxColumn.DataPropertyName = "GiaThue";
            this.giaThueDataGridViewTextBoxColumn.HeaderText = "GiaThue";
            this.giaThueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaThueDataGridViewTextBoxColumn.Name = "giaThueDataGridViewTextBoxColumn";
            this.giaThueDataGridViewTextBoxColumn.Width = 125;
            // 
            // hopDongBindingSource
            // 
            this.hopDongBindingSource.DataMember = "HopDong";
            this.hopDongBindingSource.DataSource = this.quanLyNhaTroDataSet;
            // 
            // quanLyNhaTroDataSet
            // 
            this.quanLyNhaTroDataSet.DataSetName = "QuanLyNhaTroDataSet";
            this.quanLyNhaTroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hopDongTableAdapter
            // 
            this.hopDongTableAdapter.ClearBeforeFill = true;
            // 
            // HopDongScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "HopDongScreen";
            this.Text = "HopDongScreen";
            this.Load += new System.EventHandler(this.HopDongScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hopdong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopDongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaTroDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Hopdong;
        private DataSet.QuanLyNhaTroDataSet quanLyNhaTroDataSet;
        private System.Windows.Forms.BindingSource hopDongBindingSource;
        private DataSet.QuanLyNhaTroDataSetTableAdapters.HopDongTableAdapter hopDongTableAdapter;
        private System.Windows.Forms.TextBox txt_soHopDong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHopDongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachThueIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongNguoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTraPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThaiThueDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienCocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaThueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_TienCoc;
        private System.Windows.Forms.DateTimePicker dtp_TuNgay;
        private System.Windows.Forms.DateTimePicker dtp_NgayTra;
        private System.Windows.Forms.TextBox txt_soLuongNguoi;
        private System.Windows.Forms.TextBox txt_SoPhong;
        private System.Windows.Forms.TextBox txt_KhachThueID;
        private System.Windows.Forms.Button btn_traPhong;
    }
}