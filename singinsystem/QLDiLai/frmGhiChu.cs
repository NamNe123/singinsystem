using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Manager;
using DataAccessLayer.Entity;
using singinsystem.QLDiLai;

namespace singinsystem.QLDiLai
{
    public partial class frmGhiChu : Form
    {
        private QLDiLaiManager QLDLManager;
        private string error = "";
        public frmGhiChu()
        {
            InitializeComponent();
            this.QLDLManager = new QLDiLaiManager();
        }
        public class LuuThongTin
        {
            public static int KiemTra;
        }
        private void frmGhiChu_Load(object sender, EventArgs e)
        {
            this.lbTenNV.Text = ucQLDiLai.LuuThongTin.TenNV;
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            QLDiLaiEntity qldiLaiEntity = new QLDiLaiEntity();
            qldiLaiEntity.Id = ucQLDiLai.LuuThongTin.Id;
            qldiLaiEntity.GhiChu = this.txtGhiChu.Text;
            bool flag = this.QLDLManager.ThemGhiChu(qldiLaiEntity, ref this.error);
            bool flag2 = flag;
            if (flag2)
            {
                frmGhiChu.LuuThongTin.KiemTra = 1;
            }
            else
            {
                CustomMessageBoxPhu.Show("下班失败: " + this.error, "失败 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            frmGhiChu.LuuThongTin.KiemTra = 1;
            base.Close();
        }
        private void btnKhongDongY_Click(object sender, EventArgs e)
        {
            frmGhiChu.LuuThongTin.KiemTra = 0;
            base.Close();
        }
    }
}
