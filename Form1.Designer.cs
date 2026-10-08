namespace hoccsharp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMaPhieu = new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(110, 15), Size = new System.Drawing.Size(180, 23) };
            this.txtNguoiYeuCau = new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(110, 45), Size = new System.Drawing.Size(180, 23) };
            this.dtpNgayGhiNhan = new System.Windows.Forms.DateTimePicker() { Location = new System.Drawing.Point(110, 75), Size = new System.Drawing.Size(180, 23), Format = System.Windows.Forms.DateTimePickerFormat.Short };

            this.rdoThap = new System.Windows.Forms.RadioButton() { Text = "Thấp", Location = new System.Drawing.Point(110, 105), AutoSize = true, Checked = true };
            this.rdoTrungBinh = new System.Windows.Forms.RadioButton() { Text = "TB", Location = new System.Drawing.Point(165, 105), AutoSize = true };
            this.rdoKhanCap = new System.Windows.Forms.RadioButton() { Text = "Khẩn cấp", Location = new System.Drawing.Point(210, 105), AutoSize = true };

            this.cboLoaiSuCo = new System.Windows.Forms.ComboBox() { Location = new System.Drawing.Point(110, 135), Size = new System.Drawing.Size(180, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            this.cboLoaiSuCo.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });

            this.chkMayTinhBan = new System.Windows.Forms.CheckBox() { Text = "Máy tính bàn", Location = new System.Drawing.Point(110, 165), AutoSize = true };
            this.chkLaptop = new System.Windows.Forms.CheckBox() { Text = "Laptop", Location = new System.Drawing.Point(200, 165), AutoSize = true };
            this.chkMayIn = new System.Windows.Forms.CheckBox() { Text = "Máy in", Location = new System.Drawing.Point(110, 190), AutoSize = true };
            this.chkDienThoai = new System.Windows.Forms.CheckBox() { Text = "Điện thoại", Location = new System.Drawing.Point(200, 190), AutoSize = true };

            this.btnTaiAnh = new System.Windows.Forms.Button() { Text = "Tải ảnh lỗi", Location = new System.Drawing.Point(15, 220), Size = new System.Drawing.Size(85, 30) };
            this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);

            this.picAnhLoi = new System.Windows.Forms.PictureBox() { Location = new System.Drawing.Point(110, 220), Size = new System.Drawing.Size(180, 75), BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle, SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage };

            this.btnGui = new System.Windows.Forms.Button() { Text = "Gửi yêu cầu", Location = new System.Drawing.Point(110, 310), Size = new System.Drawing.Size(85, 30) };
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);

            this.btnNhapLai = new System.Windows.Forms.Button() { Text = "Nhập lại", Location = new System.Drawing.Point(205, 310), Size = new System.Drawing.Size(85, 30) };
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);

            this.ClientSize = new System.Drawing.Size(305, 350);
            this.Text = "IT Support Ticket Form";
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { Text = "Mã phiếu:", Location = new System.Drawing.Point(15, 18), AutoSize = true }, this.txtMaPhieu,
                new System.Windows.Forms.Label { Text = "Người YC:", Location = new System.Drawing.Point(15, 48), AutoSize = true }, this.txtNguoiYeuCau,
                new System.Windows.Forms.Label { Text = "Ngày:", Location = new System.Drawing.Point(15, 78), AutoSize = true }, this.dtpNgayGhiNhan,
                new System.Windows.Forms.Label { Text = "Ưu tiên:", Location = new System.Drawing.Point(15, 107), AutoSize = true }, this.rdoThap, this.rdoTrungBinh, this.rdoKhanCap,
                new System.Windows.Forms.Label { Text = "Loại sự cố:", Location = new System.Drawing.Point(15, 138), AutoSize = true }, this.cboLoaiSuCo,
                new System.Windows.Forms.Label { Text = "Thiết bị:", Location = new System.Drawing.Point(15, 166), AutoSize = true }, this.chkMayTinhBan, this.chkLaptop, this.chkMayIn, this.chkDienThoai,
                this.btnTaiAnh, this.picAnhLoi, this.btnGui, this.btnNhapLai
            });
        }

        private System.Windows.Forms.TextBox txtMaPhieu, txtNguoiYeuCau;
        private System.Windows.Forms.DateTimePicker dtpNgayGhiNhan;
        private System.Windows.Forms.RadioButton rdoThap, rdoTrungBinh, rdoKhanCap;
        private System.Windows.Forms.ComboBox cboLoaiSuCo;
        private System.Windows.Forms.CheckBox chkMayTinhBan, chkLaptop, chkMayIn, chkDienThoai;
        private System.Windows.Forms.PictureBox picAnhLoi;
        private System.Windows.Forms.Button btnTaiAnh, btnGui, btnNhapLai;
    }
}