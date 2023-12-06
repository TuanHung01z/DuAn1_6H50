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
    public partial class TheThanhVien : Form
    {
        Regex NumbersOnly = new Regex(@"\d+$");
        Regex ASCIIOnly = new Regex(@"[A-Za-z0-9]+$");
        public TheThanhVien()
        {
            InitializeComponent();
            BTN_Update.Enabled = false;
            BTN_Delete.Enabled = false;
            GetServiceList();
        }
        public Panel theTV()
        {
            return Panel_TheTv;
        }

        private void BTN_CreateNew_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = 
        }

        private void GetServiceList()
        {
            Screen_MemberCard.DataSource = Svc_DichVu.TaiDuLieu();
            Screen_MemberCard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Screen_MemberCard.ColumnCount = 5;
            Screen_MemberCard.Columns[0].HeaderText = "SĐT";
            Screen_MemberCard.Columns[1].HeaderText = "Điểm";
            Screen_MemberCard.Columns[2].HeaderText = "Loại thành viên";
            Screen_MemberCard.Columns[3].HeaderText = "Ngày hiệu lực";
            Screen_MemberCard.Columns[4].HeaderText = "Ngày hết hạn";
            Screen_MemberCard.Columns[5].Visible = false;
        }

        private void ResetAll()
        {
            BTN_CreateNew.Enabled = true;
            BTN_Update.Enabled = false;
            BTN_Delete.Enabled = false;
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }
    }
}
