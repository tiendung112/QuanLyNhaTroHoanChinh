namespace QuanLyNhaTro
{
    partial class PhongScreen
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
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_ThemPhong = new System.Windows.Forms.Button();
            this.txt_GiaPhong = new System.Windows.Forms.TextBox();
            this.txt_SoPhong = new System.Windows.Forms.TextBox();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.txt_Tang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_phong = new System.Windows.Forms.DataGridView();
            this.soPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viTriPhongIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiPhongIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhaTroDataSet = new QuanLyNhaTro.QuanLyNhaTroDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_TTphong = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.phongTableAdapter = new QuanLyNhaTro.QuanLyNhaTroDataSetTableAdapters.PhongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaTroDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(425, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 52);
            this.label7.TabIndex = 22;
            this.label7.Text = "Quản Lý Phòng";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(777, 224);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(134, 37);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(488, 224);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(134, 37);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_ThemPhong
            // 
            this.btn_ThemPhong.Location = new System.Drawing.Point(157, 224);
            this.btn_ThemPhong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_ThemPhong.Name = "btn_ThemPhong";
            this.btn_ThemPhong.Size = new System.Drawing.Size(134, 37);
            this.btn_ThemPhong.TabIndex = 5;
            this.btn_ThemPhong.Text = "Thêm";
            this.btn_ThemPhong.UseVisualStyleBackColor = true;
            this.btn_ThemPhong.Click += new System.EventHandler(this.btn_ThemPhong_Click);
            // 
            // txt_GiaPhong
            // 
            this.txt_GiaPhong.Location = new System.Drawing.Point(695, 170);
            this.txt_GiaPhong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_GiaPhong.Name = "txt_GiaPhong";
            this.txt_GiaPhong.Size = new System.Drawing.Size(290, 30);
            this.txt_GiaPhong.TabIndex = 4;
            // 
            // txt_SoPhong
            // 
            this.txt_SoPhong.Location = new System.Drawing.Point(201, 104);
            this.txt_SoPhong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_SoPhong.Name = "txt_SoPhong";
            this.txt_SoPhong.Size = new System.Drawing.Size(290, 30);
            this.txt_SoPhong.TabIndex = 1;
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(695, 3);
            this.txt_GhiChu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(290, 88);
            this.txt_GhiChu.TabIndex = 3;
            // 
            // txt_Tang
            // 
            this.txt_Tang.Location = new System.Drawing.Point(201, 21);
            this.txt_Tang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Tang.Name = "txt_Tang";
            this.txt_Tang.Size = new System.Drawing.Size(290, 30);
            this.txt_Tang.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Trạng Thái Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ghi Chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giá Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tầng";
            // 
            // dgv_phong
            // 
            this.dgv_phong.AutoGenerateColumns = false;
            this.dgv_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soPhongDataGridViewTextBoxColumn,
            this.viTriPhongIDDataGridViewTextBoxColumn,
            this.giaPhongDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.trangThaiPhongIDDataGridViewTextBoxColumn});
            this.dgv_phong.DataSource = this.phongBindingSource;
            this.dgv_phong.Location = new System.Drawing.Point(-4, 29);
            this.dgv_phong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_phong.Name = "dgv_phong";
            this.dgv_phong.RowHeadersWidth = 51;
            this.dgv_phong.RowTemplate.Height = 24;
            this.dgv_phong.Size = new System.Drawing.Size(1114, 404);
            this.dgv_phong.TabIndex = 0;
            this.dgv_phong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phong_CellClick);
            // 
            // soPhongDataGridViewTextBoxColumn
            // 
            this.soPhongDataGridViewTextBoxColumn.DataPropertyName = "SoPhong";
            this.soPhongDataGridViewTextBoxColumn.HeaderText = "Số Phòng";
            this.soPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soPhongDataGridViewTextBoxColumn.Name = "soPhongDataGridViewTextBoxColumn";
            this.soPhongDataGridViewTextBoxColumn.Width = 125;
            // 
            // viTriPhongIDDataGridViewTextBoxColumn
            // 
            this.viTriPhongIDDataGridViewTextBoxColumn.DataPropertyName = "ViTriPhongID";
            this.viTriPhongIDDataGridViewTextBoxColumn.HeaderText = "Tầng";
            this.viTriPhongIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.viTriPhongIDDataGridViewTextBoxColumn.Name = "viTriPhongIDDataGridViewTextBoxColumn";
            this.viTriPhongIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaPhongDataGridViewTextBoxColumn
            // 
            this.giaPhongDataGridViewTextBoxColumn.DataPropertyName = "GiaPhong";
            this.giaPhongDataGridViewTextBoxColumn.HeaderText = "Giá Phòng";
            this.giaPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaPhongDataGridViewTextBoxColumn.Name = "giaPhongDataGridViewTextBoxColumn";
            this.giaPhongDataGridViewTextBoxColumn.Width = 125;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.ghiChuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangThaiPhongIDDataGridViewTextBoxColumn
            // 
            this.trangThaiPhongIDDataGridViewTextBoxColumn.DataPropertyName = "TrangThaiPhongID";
            this.trangThaiPhongIDDataGridViewTextBoxColumn.HeaderText = "Trạng Thái";
            this.trangThaiPhongIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangThaiPhongIDDataGridViewTextBoxColumn.Name = "trangThaiPhongIDDataGridViewTextBoxColumn";
            this.trangThaiPhongIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataMember = "Phong";
            this.phongBindingSource.DataSource = this.quanLyNhaTroDataSet;
            // 
            // quanLyNhaTroDataSet
            // 
            this.quanLyNhaTroDataSet.DataSetName = "QuanLyNhaTroDataSet";
            this.quanLyNhaTroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_TTphong);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_ThemPhong);
            this.groupBox1.Controls.Add(this.txt_GiaPhong);
            this.groupBox1.Controls.Add(this.txt_SoPhong);
            this.groupBox1.Controls.Add(this.txt_GhiChu);
            this.groupBox1.Controls.Add(this.txt_Tang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1115, 277);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý";
            // 
            // cbx_TTphong
            // 
            this.cbx_TTphong.FormattingEnabled = true;
            this.cbx_TTphong.Location = new System.Drawing.Point(205, 168);
            this.cbx_TTphong.Name = "cbx_TTphong";
            this.cbx_TTphong.Size = new System.Drawing.Size(283, 30);
            this.cbx_TTphong.TabIndex = 2;
            this.cbx_TTphong.Click += new System.EventHandler(this.cbx_TTphong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_phong);
            this.groupBox2.Location = new System.Drawing.Point(6, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1110, 433);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phòng";
            // 
            // phongTableAdapter
            // 
            this.phongTableAdapter.ClearBeforeFill = true;
            // 
            // PhongScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 778);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhongScreen";
            this.Text = "PhongScreen";
            this.Load += new System.EventHandler(this.PhongScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaTroDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_ThemPhong;
        private System.Windows.Forms.TextBox txt_GiaPhong;
        private System.Windows.Forms.TextBox txt_SoPhong;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.TextBox txt_Tang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_phong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private QuanLyNhaTroDataSet quanLyNhaTroDataSet;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private QuanLyNhaTroDataSetTableAdapters.PhongTableAdapter phongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viTriPhongIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiPhongIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbx_TTphong;
    }
}