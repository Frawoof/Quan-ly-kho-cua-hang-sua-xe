namespace btl
{
	partial class frmKho
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			groupBox1 = new GroupBox();
			btnXoaNCC = new Button();
			btnThemNCC = new Button();
			txtMaNVNhap = new TextBox();
			label4 = new Label();
			dtpNgayNhap = new DateTimePicker();
			label3 = new Label();
			cbNhaCungCap = new ComboBox();
			label2 = new Label();
			txtMaPhieuNhap = new TextBox();
			label1 = new Label();
			groupBox2 = new GroupBox();
			XoaThongTin = new Button();
			btnSuaThongTin = new Button();
			btnThemPhuTung = new Button();
			txtThanhTien = new TextBox();
			label10 = new Label();
			dtpHanSuDung = new DateTimePicker();
			label9 = new Label();
			txtDonGiaNhap = new TextBox();
			label8 = new Label();
			txtSoLuongNhap = new TextBox();
			label7 = new Label();
			txtTenPhuTung = new TextBox();
			label6 = new Label();
			cbMaPhuTung = new ComboBox();
			label5 = new Label();
			panel1 = new Panel();
			dgvPhuTung = new DataGridView();
			panel2 = new Panel();
			btnInPhieu = new Button();
			btnSuaPhieu = new Button();
			btnThoat = new Button();
			btnXoaPhieu = new Button();
			btnLuuPhieu = new Button();
			btnLamMoi = new Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvPhuTung).BeginInit();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnXoaNCC);
			groupBox1.Controls.Add(btnThemNCC);
			groupBox1.Controls.Add(txtMaNVNhap);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(dtpNgayNhap);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(cbNhaCungCap);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(txtMaPhieuNhap);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(915, 154);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin phiếu nhập";
			// 
			// btnXoaNCC
			// 
			btnXoaNCC.Location = new Point(232, 114);
			btnXoaNCC.Name = "btnXoaNCC";
			btnXoaNCC.Size = new Size(131, 29);
			btnXoaNCC.TabIndex = 20;
			btnXoaNCC.Text = "Xóa NCC";
			btnXoaNCC.UseVisualStyleBackColor = true;
			// 
			// btnThemNCC
			// 
			btnThemNCC.Location = new Point(68, 114);
			btnThemNCC.Name = "btnThemNCC";
			btnThemNCC.Size = new Size(131, 29);
			btnThemNCC.TabIndex = 19;
			btnThemNCC.Text = "Thêm NCC";
			btnThemNCC.UseVisualStyleBackColor = true;
			btnThemNCC.Click += btnThemNCC_Click;
			// 
			// txtMaNVNhap
			// 
			txtMaNVNhap.Location = new Point(627, 81);
			txtMaNVNhap.Name = "txtMaNVNhap";
			txtMaNVNhap.Size = new Size(250, 27);
			txtMaNVNhap.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(501, 87);
			label4.Name = "label4";
			label4.Size = new Size(94, 20);
			label4.TabIndex = 6;
			label4.Text = "Mã NV nhập:";
			// 
			// dtpNgayNhap
			// 
			dtpNgayNhap.Location = new Point(627, 26);
			dtpNgayNhap.Name = "dtpNgayNhap";
			dtpNgayNhap.Size = new Size(250, 27);
			dtpNgayNhap.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(501, 33);
			label3.Name = "label3";
			label3.Size = new Size(84, 20);
			label3.TabIndex = 4;
			label3.Text = "Ngày nhập:";
			// 
			// cbNhaCungCap
			// 
			cbNhaCungCap.FormattingEnabled = true;
			cbNhaCungCap.Location = new Point(149, 80);
			cbNhaCungCap.Name = "cbNhaCungCap";
			cbNhaCungCap.Size = new Size(246, 28);
			cbNhaCungCap.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(20, 87);
			label2.Name = "label2";
			label2.Size = new Size(103, 20);
			label2.TabIndex = 2;
			label2.Text = "Nhà cung cấp:";
			// 
			// txtMaPhieuNhap
			// 
			txtMaPhieuNhap.Location = new Point(149, 28);
			txtMaPhieuNhap.Name = "txtMaPhieuNhap";
			txtMaPhieuNhap.Size = new Size(246, 27);
			txtMaPhieuNhap.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(20, 33);
			label1.Name = "label1";
			label1.Size = new Size(111, 20);
			label1.TabIndex = 0;
			label1.Text = "Mã phiếu nhập:";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(XoaThongTin);
			groupBox2.Controls.Add(btnSuaThongTin);
			groupBox2.Controls.Add(btnThemPhuTung);
			groupBox2.Controls.Add(txtThanhTien);
			groupBox2.Controls.Add(label10);
			groupBox2.Controls.Add(dtpHanSuDung);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(txtDonGiaNhap);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(txtSoLuongNhap);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(txtTenPhuTung);
			groupBox2.Controls.Add(label6);
			groupBox2.Controls.Add(cbMaPhuTung);
			groupBox2.Controls.Add(label5);
			groupBox2.Location = new Point(12, 172);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(915, 264);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Thông tin phụ tùng";
			// 
			// XoaThongTin
			// 
			XoaThongTin.Location = new Point(336, 215);
			XoaThongTin.Name = "XoaThongTin";
			XoaThongTin.Size = new Size(131, 29);
			XoaThongTin.TabIndex = 18;
			XoaThongTin.Text = "Xóa thông tin";
			XoaThongTin.UseVisualStyleBackColor = true;
			// 
			// btnSuaThongTin
			// 
			btnSuaThongTin.Location = new Point(177, 215);
			btnSuaThongTin.Name = "btnSuaThongTin";
			btnSuaThongTin.Size = new Size(131, 29);
			btnSuaThongTin.TabIndex = 17;
			btnSuaThongTin.Text = "Sửa thông tin";
			btnSuaThongTin.UseVisualStyleBackColor = true;
			// 
			// btnThemPhuTung
			// 
			btnThemPhuTung.Location = new Point(20, 215);
			btnThemPhuTung.Name = "btnThemPhuTung";
			btnThemPhuTung.Size = new Size(131, 29);
			btnThemPhuTung.TabIndex = 16;
			btnThemPhuTung.Text = "Thêm phụ tùng";
			btnThemPhuTung.UseVisualStyleBackColor = true;
			// 
			// txtThanhTien
			// 
			txtThanhTien.Location = new Point(627, 169);
			txtThanhTien.Name = "txtThanhTien";
			txtThanhTien.Size = new Size(250, 27);
			txtThanhTien.TabIndex = 15;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(501, 169);
			label10.Name = "label10";
			label10.Size = new Size(81, 20);
			label10.TabIndex = 14;
			label10.Text = "Thành tiền:";
			// 
			// dtpHanSuDung
			// 
			dtpHanSuDung.Location = new Point(149, 166);
			dtpHanSuDung.Name = "dtpHanSuDung";
			dtpHanSuDung.Size = new Size(246, 27);
			dtpHanSuDung.TabIndex = 9;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(18, 169);
			label9.Name = "label9";
			label9.Size = new Size(96, 20);
			label9.TabIndex = 8;
			label9.Text = "Hạn sử dụng:";
			// 
			// txtDonGiaNhap
			// 
			txtDonGiaNhap.Location = new Point(627, 110);
			txtDonGiaNhap.Name = "txtDonGiaNhap";
			txtDonGiaNhap.Size = new Size(250, 27);
			txtDonGiaNhap.TabIndex = 13;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(501, 110);
			label8.Name = "label8";
			label8.Size = new Size(102, 20);
			label8.TabIndex = 12;
			label8.Text = "Đơn giá nhập:";
			// 
			// txtSoLuongNhap
			// 
			txtSoLuongNhap.Location = new Point(149, 107);
			txtSoLuongNhap.Name = "txtSoLuongNhap";
			txtSoLuongNhap.Size = new Size(246, 27);
			txtSoLuongNhap.TabIndex = 11;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(18, 110);
			label7.Name = "label7";
			label7.Size = new Size(109, 20);
			label7.TabIndex = 10;
			label7.Text = "Số lượng nhập:";
			// 
			// txtTenPhuTung
			// 
			txtTenPhuTung.Location = new Point(627, 50);
			txtTenPhuTung.Name = "txtTenPhuTung";
			txtTenPhuTung.Size = new Size(250, 27);
			txtTenPhuTung.TabIndex = 9;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(501, 52);
			label6.Name = "label6";
			label6.Size = new Size(98, 20);
			label6.TabIndex = 8;
			label6.Text = "Tên phụ tùng:";
			// 
			// cbMaPhuTung
			// 
			cbMaPhuTung.FormattingEnabled = true;
			cbMaPhuTung.Location = new Point(149, 49);
			cbMaPhuTung.Name = "cbMaPhuTung";
			cbMaPhuTung.Size = new Size(246, 28);
			cbMaPhuTung.TabIndex = 1;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(20, 52);
			label5.Name = "label5";
			label5.Size = new Size(96, 20);
			label5.TabIndex = 0;
			label5.Text = "Mã phụ tùng:";
			// 
			// panel1
			// 
			panel1.Controls.Add(dgvPhuTung);
			panel1.Location = new Point(12, 442);
			panel1.Name = "panel1";
			panel1.Size = new Size(915, 241);
			panel1.TabIndex = 2;
			// 
			// dgvPhuTung
			// 
			dgvPhuTung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPhuTung.Location = new Point(3, 3);
			dgvPhuTung.Name = "dgvPhuTung";
			dgvPhuTung.RowHeadersWidth = 51;
			dgvPhuTung.Size = new Size(909, 235);
			dgvPhuTung.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.Controls.Add(btnInPhieu);
			panel2.Controls.Add(btnSuaPhieu);
			panel2.Controls.Add(btnThoat);
			panel2.Controls.Add(btnXoaPhieu);
			panel2.Controls.Add(btnLuuPhieu);
			panel2.Controls.Add(btnLamMoi);
			panel2.Location = new Point(12, 689);
			panel2.Name = "panel2";
			panel2.Size = new Size(915, 100);
			panel2.TabIndex = 3;
			// 
			// btnInPhieu
			// 
			btnInPhieu.Location = new Point(336, 24);
			btnInPhieu.Name = "btnInPhieu";
			btnInPhieu.Size = new Size(123, 57);
			btnInPhieu.TabIndex = 5;
			btnInPhieu.Text = "In phiếu";
			btnInPhieu.UseVisualStyleBackColor = true;
			// 
			// btnSuaPhieu
			// 
			btnSuaPhieu.Location = new Point(484, 24);
			btnSuaPhieu.Name = "btnSuaPhieu";
			btnSuaPhieu.Size = new Size(123, 57);
			btnSuaPhieu.TabIndex = 4;
			btnSuaPhieu.Text = "Sửa phiếu";
			btnSuaPhieu.UseVisualStyleBackColor = true;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(774, 24);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(123, 57);
			btnThoat.TabIndex = 3;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			// 
			// btnXoaPhieu
			// 
			btnXoaPhieu.Location = new Point(627, 24);
			btnXoaPhieu.Name = "btnXoaPhieu";
			btnXoaPhieu.Size = new Size(123, 57);
			btnXoaPhieu.TabIndex = 2;
			btnXoaPhieu.Text = "Xóa phiếu";
			btnXoaPhieu.UseVisualStyleBackColor = true;
			// 
			// btnLuuPhieu
			// 
			btnLuuPhieu.Location = new Point(185, 24);
			btnLuuPhieu.Name = "btnLuuPhieu";
			btnLuuPhieu.Size = new Size(123, 57);
			btnLuuPhieu.TabIndex = 1;
			btnLuuPhieu.Text = "Lưu phiếu";
			btnLuuPhieu.UseVisualStyleBackColor = true;
			// 
			// btnLamMoi
			// 
			btnLamMoi.Location = new Point(28, 24);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(123, 57);
			btnLamMoi.TabIndex = 0;
			btnLamMoi.Text = "Làm mới";
			btnLamMoi.UseVisualStyleBackColor = true;
			// 
			// frmKho
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(939, 801);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "frmKho";
			Text = "Form Kho";
			Load += frmKho_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvPhuTung).EndInit();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private TextBox txtMaNVNhap;
		private Label label4;
		private DateTimePicker dtpNgayNhap;
		private Label label3;
		private ComboBox cbNhaCungCap;
		private Label label2;
		private TextBox txtMaPhieuNhap;
		private Label label1;
		private GroupBox groupBox2;
		private TextBox txtThanhTien;
		private Label label10;
		private DateTimePicker dtpHanSuDung;
		private Label label9;
		private TextBox txtDonGiaNhap;
		private Label label8;
		private TextBox txtSoLuongNhap;
		private Label label7;
		private TextBox txtTenPhuTung;
		private Label label6;
		private ComboBox cbMaPhuTung;
		private Label label5;
		private Panel panel1;
		private DataGridView dgvPhuTung;
		private Panel panel2;
		private Button btnLamMoi;
		private Button btnThoat;
		private Button btnXoaPhieu;
		private Button btnLuuPhieu;
		private Button btnInPhieu;
		private Button btnSuaPhieu;
		private Button XoaThongTin;
		private Button btnSuaThongTin;
		private Button btnThemPhuTung;
		private Button btnXoaNCC;
		private Button btnThemNCC;
	}
}
