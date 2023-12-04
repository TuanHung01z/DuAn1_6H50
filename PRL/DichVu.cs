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
    public partial class DichVu : Form
    {
        List<DichVu>? Temp_DichVu = null;

        public DichVu()
        {
            InitializeComponent();
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
            Temp_DichVu = null;
            // it's been 6 months. where the hell is service............
        }
    }
}
