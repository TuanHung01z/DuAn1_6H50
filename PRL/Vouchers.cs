using BUS.Services;
using DAL1.DomainClass;
using Microsoft.Identity.Client;
using System.Data;

namespace PRL
{
    public partial class Vouchers : Form
    {
        private VoucherServices _services;
        private string _IDwhenclick;
        public Vouchers()
        {
            InitializeComponent();
            _services = new VoucherServices();
            LoadData(null);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public Panel Voucher()
        {
            return panel_Voucher;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vc = new Voucher();
            vc.MaVoucher = txt_maVoucher.Text;
            vc.LoaiVoucher = txt_loaiVoucher.Text;
            vc.GiaTri = int.Parse(txt_GiaTri.Text);
            vc.HanSuDung = DateTime.Parse(txt_HanSuDung.Text);
            var option = MessageBox.Show("Xác nhận muốn thêm vcách hàng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_services.Add(vc));
                LoadData(null);
            }
            else
            {
                return;
            }

        }
        public void LoadData(string search)
        {
            int stt = 1;
            dtgView.ColumnCount = 5;
            dtgView.Columns[0].Name = "Stt";
            dtgView.Columns[1].Name = "MaVoucher";
            dtgView.Columns[2].Name = "LoaiVoucher";
            dtgView.Columns[3].Name = "GiaTri";
            dtgView.Columns[4].Name = "HanSuDung";

            dtgView.Rows.Clear();
            foreach (var hd in _services.GetAllVCs())
            {
                dtgView.Rows.Add(stt++, hd.MaVoucher, hd.LoaiVoucher, hd.GiaTri, hd.HanSuDung);
            }


        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            // Xóa hoặc làm sạch dữ liệu trên các điều khiển

            // Xóa hoặc xóa trống TextBoxes
            txt_maVoucher.Text = string.Empty;
            txt_loaiVoucher.Text = string.Empty;
            txt_GiaTri.Text = string.Empty;
            txt_HanSuDung.Text = string.Empty;

            // Xóa hoặc làm sạch DataGridView
            dtgView.Rows.Clear(); // Xóa hết dữ liệu trong DataGridView

            // Hoặc có thể gọi phương thức LoadData hoặc LoadGird để tải lại dữ liệu mặc định
            LoadData(null); // Gọi lại phương thức để tải dữ liệu mặc định
        }

        private void btn_XoaVoucher_Click(object sender, EventArgs e)
        {

        }

        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
