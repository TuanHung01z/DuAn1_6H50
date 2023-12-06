using BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class YeuCauDichVu : Form
    {
        YCDichVuServices svces = new YCDichVuServices();
        public YeuCauDichVu()
        {
            InitializeComponent();
            LoadData();
        }
        public Panel yeuCauDichVu()
        {
            return panel_YeuCauDichVu;
        }

        public void LoadData()
        {
            dtg_ChonDV.ColumnCount = 3;

            dtg_ChonDV.Columns[0].Name = "madv";
            dtg_ChonDV.Columns[0].HeaderText = "Mã DV";

            dtg_ChonDV.Columns[1].Name = "mota";
            dtg_ChonDV.Columns[1].HeaderText = "Tên dịch vụ";

            dtg_ChonDV.Columns[2].Name = "giadv";
            dtg_ChonDV.Columns[2].HeaderText = "Giá dịch vụ";


            foreach (var item in svces.GetAllDV())
            {
                dtg_ChonDV.Rows.Add(item.MaDichVu, item.TenDichVu, item.GiaDichVu.ToString());
            }
        }
    }
}
