using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace hoccsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboLoaiSuCo.SelectedIndex = 0;
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picAnhLoi.ImageLocation = ofd.FileName;
                }
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text) || string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã phiếu và Người yêu cầu!");
                return;
            }

            string uuTien = rdoThap.Checked ? "Thấp" : rdoTrungBinh.Checked ? "Trung bình" : "Khẩn cấp";

            List<string> thietBi = new List<string>();
            if (chkMayTinhBan.Checked) thietBi.Add("Máy tính bàn");
            if (chkLaptop.Checked) thietBi.Add("Laptop");
            if (chkMayIn.Checked) thietBi.Add("Máy in");
            if (chkDienThoai.Checked) thietBi.Add("Điện thoại");

            string strThietBi = thietBi.Count > 0 ? string.Join(", ", thietBi) : "Không chọn";
            string coAnh = picAnhLoi.ImageLocation != null ? "Đã chọn" : "Chưa chọn";

            string thongTin = $"Mã phiếu: {txtMaPhieu.Text}\n" +
                              $"Người yêu cầu: {txtNguoiYeuCau.Text}\n" +
                              $"Ngày ghi nhận: {dtpNgayGhiNhan.Value:dd/MM/yyyy}\n" +
                              $"Mức độ ưu tiên: {uuTien}\n" +
                              $"Loại sự cố: {cboLoaiSuCo.SelectedItem}\n" +
                              $"Thiết bị ảnh hưởng: {strThietBi}\n" +
                              $"Ảnh lỗi: {coAnh}";

            MessageBox.Show(thongTin, "Thông tin phiếu yêu cầu");
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();
            dtpNgayGhiNhan.Value = DateTime.Now;
            rdoThap.Checked = true;
            cboLoaiSuCo.SelectedIndex = 0;
            chkMayTinhBan.Checked = chkLaptop.Checked = chkMayIn.Checked = chkDienThoai.Checked = false;
            picAnhLoi.Image = null;
            picAnhLoi.ImageLocation = null;
            txtMaPhieu.Focus();
        }
    }
}