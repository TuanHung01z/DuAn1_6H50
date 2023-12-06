using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PRL
{

    public partial class HoaDon : Form
    {
        private Control[] controls;
        Vouchers vc = new Vouchers()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };
        TaoVe tv = new TaoVe()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };
        KhachHang1 KH = new KhachHang1()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };
        LichChieu Lc = new LichChieu()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };
        TheThanhVien Thetv = new TheThanhVien()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };
        DichVu DV = new DichVu()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };
        YeuCauDichVu Ycdv = new YeuCauDichVu()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };
        ThongKe TK = new ThongKe()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };
        public HoaDon()
        {
            InitializeComponent();
            controls = panel2.Controls.Cast<Control>().ToArray();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_Phim.BackColor = Color.FromArgb(190, 0, 0);
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.FromArgb(190, 0, 0);
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;


        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
        }

        private void btn_xuatFilepdf_Click(object sender, EventArgs e)
        {
        }

        private void btn_nhapHoaDon_Click(object sender, EventArgs e)
        {
        }

        private void btn_luuHoaDon_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label23_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label28_Click(object sender, EventArgs e)
        {
        }

        private void Panel_TheThanhVien_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
        }

        private void label26_Click(object sender, EventArgs e)
        {
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
        }

        private void label31_Click(object sender, EventArgs e)
        {
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
        }

        private void label29_Click(object sender, EventArgs e)
        {
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
        }

        private void label27_Click(object sender, EventArgs e)
        {
        }

        private void Panel_Voucher_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label22_Click(object sender, EventArgs e)
        {
        }

        private void Panel_TaoHoaDon_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Panel_TaoVe_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void Panel_KhachHang_Paint(object sender, PaintEventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void label16_Click_1(object sender, EventArgs e)
        {
        }

        private void label18_Click(object sender, EventArgs e)
        {
        }

        private void label19_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
        }

        private void Panel_KhachHang_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_Phim.BackColor = Color.Orange;
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.FromArgb(190, 0, 0);
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;

        }

        private void Panel_LichChieu_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Panel_TaoVe_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.FromArgb(190, 0, 0);
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;
        }

        private void Panel_TaoHoaDon_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.FromArgb(190, 0, 0);
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;
        }

        private void Panel_Voucher_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.FromArgb(190, 0, 0);
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;
        }

        private void Panel_TheThanhVien_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.FromArgb(190, 0, 0);
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;
        }

        private void Panel_DichVu_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.FromArgb(190, 0, 0);
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;
        }

        private void Panel_YeucauDichVu_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.FromArgb(190, 0, 0);
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;
        }

        private void Panel_ThongKe_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.FromArgb(190, 0, 0);
            panel_DangXuat.BackColor = Color.Orange;
        }

        private void panel_DangXuat_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.FromArgb(190, 0, 0);
        }

        private void Panel_Voucher_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Panel_Voucher_Click(object sender, EventArgs e)
        {
            Vouchers vc = new Vouchers();
            Panel panel = vc.Voucher();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            panel2.Controls.Add(vc);
            panel2.Controls.Add(tv);
            panel2.Controls.Add(KH);
            panel2.Controls.Add(Lc);
            panel2.Controls.Add(Thetv);
            panel2.Controls.Add(DV);
            panel2.Controls.Add(Ycdv);
            panel2.Controls.Add(TK);
        }

        private void Panel_TaoHoaDon_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.AddRange(controls);
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void Panel_TaoVe_Click(object sender, EventArgs e)
        {
            TaoVe tv = new TaoVe();
            Panel panel = tv.taoVe();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }

        private void Panel_KhachHang_Click(object sender, EventArgs e)
        {
            KhachHang1 Kh = new KhachHang1();
            Panel panel = Kh.khachHang();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }

        private void Panel_LichChieu_Click(object sender, EventArgs e)
        {
            LichChieu lc = new LichChieu();
            Panel panel = lc.lichChieu();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }

        private void Panel_TheThanhVien_Click(object sender, EventArgs e)
        {
            TheThanhVien Thetv = new TheThanhVien();
            Panel panel = Thetv.theTV();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }

        private void Panel_DichVu_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            Panel panel = dv.dichVu();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }

        private void Panel_YeucauDichVu_Click(object sender, EventArgs e)
        {
            YeuCauDichVu Ycdv = new YeuCauDichVu();
            Panel panel = Ycdv.yeuCauDichVu();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }

        private void Panel_ThongKe_Click(object sender, EventArgs e)
        {
            ThongKe TK = new ThongKe();
            Panel panel = TK.thongKe();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }

        private void panel_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất ?", "Đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login f1 = new Login();
                f1.ShowDialog();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void Panel_Phim_Click(object sender, EventArgs e)
        {
            Phim ph = new Phim();
            Panel panel = ph.phim();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }
    }
}
