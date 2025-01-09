using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace singinsystem.QLDiLam
{
    public partial class frmDongYXuongCa : Form
    {
        public frmDongYXuongCa()
        {
            InitializeComponent();
        }
        public class LuuThongTin
        {
            public static int KiemTra;
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            frmDongYXuongCa.LuuThongTin.KiemTra = 1;
            base.Close();
        }
        private void btnKhongDongY_Click(object sender, EventArgs e)
        {
            frmDongYXuongCa.LuuThongTin.KiemTra = 0;
            base.Close();
        }
        private void frmDongYXuongCa_Load(object sender, EventArgs e)
        {
            this.lbThongBao1.Text = ucQLDiLam.LuuThongTin.ThongBao1;
            this.lbThongBao2.Text = ucQLDiLam.LuuThongTin.ThongBao2;
        }
    }
}
