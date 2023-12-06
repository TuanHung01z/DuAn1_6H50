using BUS.Services;
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
    }
}
