using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace btl
{
	public partial class frmKho : Form
	{
		Classes.DatabaseProcessor dtbase = new Classes.DatabaseProcessor();
		Classes.Function function = new Classes.Function();
		public frmKho()
		{
			InitializeComponent();
		}

		private void frmKho_Load(object sender, EventArgs e)
		{
			string sqlDgvPhuTung = "Select pt.MaPhuTung, pt.TenPhuTung, ncc.TenNCC, pt.SoLuongTon, pt.DonGiaBan, pt.DonGiaNhap, pt.HanSuDung " +
				"From PhuTung pt Join NhaCungCap ncc On pt.MaNCC = ncc.MaNCC " +
				"Where pt.TrangThai = 1 " +
				"Order By pt.MaPhuTung Asc";

			dgvPhuTung.AutoGenerateColumns = false;
			dgvPhuTung.DataSource = dtbase.ReadData(sqlDgvPhuTung);
			dgvPhuTung.ReadOnly = true;
		}

		private void btnDanhSachPhieuNhap_Click(object sender, EventArgs e)
		{
			frmPhieuNhap formPhieuNhap = new frmPhieuNhap();
			formPhieuNhap.ShowDialog();

			frmKho_Load(sender, e);
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Chắc chắn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnNgungSuDung_Click(object sender, EventArgs e)
		{
			if (dgvPhuTung.CurrentRow == null)
			{
				MessageBox.Show("Chưa chọn phụ tùng!", "Thông báo");
				return;
			}

			if (MessageBox.Show("Chắc chắn muốn ngưng sử dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				string maPhuTung = dgvPhuTung.CurrentRow.Cells["colMaPhuTung"].Value.ToString();

				string sqlUpdateTrangThai = "Update PhuTung Set TrangThai = 0 Where MaPhuTung = '" + maPhuTung + "'";

				dtbase.ChangeData(sqlUpdateTrangThai);

				frmKho_Load(sender, e);
			}
		}

		private void btnThoat_Click_1(object sender, EventArgs e)
		{
			if (MessageBox.Show("Chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void txtTim_TextChanged(object sender, EventArgs e)
		{
			string timPhuTung = txtTimPhuTung.Text;

			string sqlTimPhuTung = "Select pt.MaPhuTung, pt.TenPhuTung, ncc.TenNCC, pt.SoLuongTon, pt.DonGiaBan, pt.DonGiaNhap, pt.HanSuDung " +
				"From PhuTung pt Join NhaCungCap ncc On pt.MaNCC = ncc.MaNCC " +
				"Where pt.TrangThai = 1 And (pt.MaPhuTung Like '%" + timPhuTung + "%' Or pt.TenPhuTung Like N'%" + timPhuTung + "%')" +
				"Order By pt.MaPhuTung Asc";

			dgvPhuTung.DataSource = dtbase.ReadData(sqlTimPhuTung);
		}
	}
}
