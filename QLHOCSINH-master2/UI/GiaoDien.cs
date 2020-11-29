using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lop QLL = new Lop();
            QLL.Show();
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {

        }

        private void btnQLHS_Click(object sender, EventArgs e)
        {
            QuanLyHocSinh qlhs = new QuanLyHocSinh();
            qlhs.Show();
        }

        private void btnQLD_Click(object sender, EventArgs e)
        {
            DiemMonHoc QLDM = new DiemMonHoc();
            QLDM.Show();
        }

        private void btnDHK_Click(object sender, EventArgs e)
        {
            QuanLyDiemHocKy QLDHK = new QuanLyDiemHocKy();
            QLDHK.Show();
        }
    }
}
