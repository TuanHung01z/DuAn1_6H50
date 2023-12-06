using BUS.Services;
using DAL1.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class DichVu : Form
    {
        Regex NumbersOnly = new Regex(@"\d+$");
        public DichVu()
        {
            InitializeComponent();
            GetServiceList();
        }
        public Panel dichVu()
        {
            return panel_DichVu;
        }

        private void BTN_CreateSvc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_ServiceID.Text) ||
                string.IsNullOrWhiteSpace(Txt_SvcName.Text)   ||
                string.IsNullOrWhiteSpace(Txt_SvcPrice.Text)  ||
                string.IsNullOrWhiteSpace(Txt_Details.Text))
            {
                MessageBox.Show("Thiếu thông tin", "NO...........", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var DichVuMoi = new DAL1.DomainClass.DichVu();
            DichVuMoi.MaDichVu = Txt_ServiceID.Text;
            DichVuMoi.TenDichVu = Txt_SvcName.Text;
            DichVuMoi.GiaDichVu = int.Parse(Txt_SvcPrice.Text);
            DichVuMoi.TrangThaiDichVu = Txt_Details.Text;
            Svc_DichVu.Them_Moi(DichVuMoi);
            MessageBox.Show("Thêm thành công", "DONEZO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetServiceList();
            ResetAll();
        }

        private void GetServiceList()
        {
            Screen_Svc.DataSource = Svc_DichVu.TaiDuLieu();
            Screen_Svc.Columns[0].HeaderText = "Mã dịch vụ";
            Screen_Svc.Columns[1].HeaderText = "Mô tả dịch vụ";
            Screen_Svc.Columns[2].HeaderText = "Giá";
            Screen_Svc.Columns[3].HeaderText = "Trạng thái";
            Screen_Svc.Columns[4].Visible = false;
        }

        private void ResetAll()
        {
            Txt_ServiceID.Text = string.Empty;
            Txt_SvcName.Text = string.Empty;
            Txt_SvcPrice.Text = string.Empty;
            Txt_Details.Text = string.Empty;
        }
    }
}
