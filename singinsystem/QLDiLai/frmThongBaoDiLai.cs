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
using singinsystem.QLDiLai;

namespace singinsystem.QLDiLai
{
    public partial class frmThongBaoDiLai : Form
    {
        private QLDiLaiManager QLDLManager;
        private string error = "";
        public frmThongBaoDiLai()
        {
            InitializeComponent();
            this.QLDLManager = new QLDiLaiManager();
        }
        private void frmThongBao_Load(object sender, EventArgs e)
        {
            this.lbTuNgay.Text = ucQLDiLai.LuuThongTin.TuNgay;
            this.lbDenNgay.Text = ucQLDiLai.LuuThongTin.DenNgay;
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        
    }
}
