using BUS.Services;
using DAL1.DomainClass;
using System.Data;

namespace PRL
{
    public partial class KhachHang1 : Form
    {
        KhachHangServices _service;
        List<KhachHang> _listKH = new();
        string _idWhenClick;
        public KhachHang1()
        {
            InitializeComponent();
            _service = new KhachHangServices();
            LoadGird(null);

        }
        public Panel khachHang()
        {
            return Panel_khachHang;
        }
        public void LoadGird(string search)
        {
            dtgview.Rows.Clear();
            dtgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgview.ColumnCount = 4;
            dtgview.Columns[0].Name = "STT";
            dtgview.Columns[1].Name = "Tên";
            dtgview.Columns[2].Name = "Địa chỉ";
            dtgview.Columns[3].Name = "Số Điện Thoại";
            _listKH = _service.GetAll(search);
            foreach (var kh in _service.GetAll(txtSearch.Text))
            {
                int stt = _listKH.IndexOf(kh) + 1;
                dtgview.Rows.Add(stt, kh.TenKhachHang, kh.DiaChi, kh.SdtkhachHang);
            }
        }
        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var kh = new KhachHang();
            kh.TenKhachHang = txtTen.Text;
            kh.DiaChi = txtDiachi.Text;
            kh.SdtkhachHang = txtSDT.Text;
            var option = MessageBox.Show("Xác nhận muốn sửa khách hàng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Update(kh));
                LoadGird(null);
            }
            else
            {
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var kh = new KhachHang();
            kh.TenKhachHang = txtTen.Text;
            kh.DiaChi = txtDiachi.Text;
            kh.SdtkhachHang = txtSDT.Text;
            var option = MessageBox.Show("Xác nhận muốn thêm khách hàng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Add(kh));
                LoadGird(null);
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kh = new KhachHang();
            kh.SdtkhachHang = _idWhenClick;
            var option = MessageBox.Show("Xác nhận muốn Xoá khách hàng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Remove(kh));
                LoadGird(null);
            }
            else
            {
                return;
            }
        }


        private void dtgview_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _listKH.Count)
            {
                return;
            }
            var obj = _listKH[index];
            _idWhenClick = obj.SdtkhachHang;
            txtTen.Text = obj.TenKhachHang;
            txtDiachi.Text = obj.DiaChi;
            txtSDT.Text = obj.SdtkhachHang;
        }

        private void cmbHangKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGird(null);
        }
    }
}
