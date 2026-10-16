using System.Data;

namespace btl
{
	public partial class frmKho : Form
	{
		Classes.DatabaseProcess dtbase = new Classes.DatabaseProcess();
		Classes.Function function = new Classes.Function();
		public frmKho()
		{
			InitializeComponent();
		}

		private void frmKho_Load(object sender, EventArgs e)
		{
			function.NumberOnly(txtSoLuongNhap);
			function.NumberOnly(txtDonGiaNhap);

			txtThanhTien.Enabled = false;

			function.AddComboBox(cbNhaCungCap, dtbase.ReadData("Select TenNCC, MaNCC From NhaCungCap"), "TenNCC", "MaNCC");
			cbNhaCungCap.SelectedIndex = -1;
			function.AddComboBox(cbMaPhuTung, dtbase.ReadData("Select MaPhuTung From PhuTung"), "MaPhuTung", "MaPhuTung");
			cbMaPhuTung.SelectedIndex = -1;
		}

		private void btnThemNCC_Click(object sender, EventArgs e)
		{
			frmThemNCC form = new frmThemNCC();
			form.ShowDialog();
			
			if(form.DialogResult == DialogResult.OK)
			{
				function.AddComboBox(cbNhaCungCap, dtbase.ReadData("Select TenNCC, MaNCC From NhaCungCap"), "TenNCC", "MaNCC");
				cbNhaCungCap.SelectedIndex = -1;
			}
		}

		private void btnXoaNCC_Click(object sender, EventArgs e)
		{
			if (cbNhaCungCap.SelectedValue == null ||cbNhaCungCap.Text.Trim() == "")
			{
				MessageBox.Show("Chọn nhà cung cấp muốn xóa!", "Thông báo");
				return;
			}

			if (MessageBox.Show("Chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				string sql = "Delete From NhaCungCap Where MaNCC = '" + cbNhaCungCap.SelectedValue.ToString() + "'";
				dtbase.ChangeData(sql);

				MessageBox.Show("Xóa thành công!", "Thông báo");
				function.AddComboBox(cbNhaCungCap, dtbase.ReadData("Select TenNCC, MaNCC From NhaCungCap"), "TenNCC", "MaNCC");
				cbNhaCungCap.SelectedIndex = -1;
			}
		}
	}
}
