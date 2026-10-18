using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace btl
{
	public partial class frmPhieuNhap : Form
	{
		Classes.DatabaseProcessor dtbase = new Classes.DatabaseProcessor();
		public frmPhieuNhap()
		{
			InitializeComponent();
		}

		private void frmPhieuNhap_Load(object sender, EventArgs e)
		{
			string sqlPhieuNhap = "Select pn.MaPhieuNhap, pn.NgayNhap, Sum(ct.SoLuong) AsTongSoLuongNhap, Sum(ct.ThanhTien) As ThanhTien, NguoiNhap " +
				"From PhieuNhap pn Join ChiTietPhieuNhap ct On pn.MaPhieuNhap = ct.MaPhieuNhap " +
				"Group By pn.MaPhieuNhap, pn.NgayNhap, pn.NguoiNhap " +
				"Order By pn.MaPhieuNhap Asc";

			dgvPhieuNhap.DataSource = dtbase.ReadData(sqlPhieuNhap);
		}

		private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string maPhieuNhap = dgvPhieuNhap.CurrentRow.Cells["colMaPhieuNhap"].Value.ToString();

			string sqlChiTiet = "Select pn.MaPhieuNhap, ncc.TenNCC, pt.MaPhuTung, pt.TenPhuTung, ct.SoLuong As SoLuongNhap, ct.DonGiaNhap, ct.ThanhTien, ct.HanSuDung " +
				"From PhuTung pt Join ChiTietPhieuNhap ct On pt.MaPhuTung = ct.MaPhuTung " +
				"Join PhieuNhap pn On ct.MaPhieuNhap = pn.MaPhieuNhap " +
				"Join NhaCungCap ncc On pn.MaNCC = ncc.MaNCC " +
				"Where ct.MaPhieuNhap = '" + maPhieuNhap + "'";

			dgvChiTiet.DataSource = dtbase.ReadData(sqlChiTiet);
		}

		private string GenerateMaPhieuNhap()
		{
			string sql = "Select Max(Cast(Substring(MaPhieuNhap, 3, Len(MaPhieuNhap)) As int)) From PhieuNhap";

			DataTable data = dtbase.ReadData(sql);

			int so = 1;
			if (data.Rows.Count > 0 && data.Rows[0][0] != DBNull.Value)
			{
				so = Convert.ToInt32(data.Rows[0][0]) + 1;
			}

			return "PN" + so.ToString("D3");
		}

		private void btnThemPhieuNhap_Click(object sender, EventArgs e)
		{
			frmNhapPhieuNhap formNhapPhieuNhap = new frmNhapPhieuNhap(GenerateMaPhieuNhap());
			formNhapPhieuNhap.ShowDialog();

			frmPhieuNhap_Load(sender, e);
		}
	}
}
