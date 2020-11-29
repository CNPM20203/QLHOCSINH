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
    public partial class DiemMonHoc : Form
    {
        public DiemMonHoc()
        {
            InitializeComponent();
        }

        private void btnThemDMH_Click(object sender, EventArgs e)
        {
            ThemDiemMonHoc TDMon = new ThemDiemMonHoc();
            TDMon.Show();
        
        }

        private void btnSuaDMH_Click(object sender, EventArgs e)
        {
            SuaDiemMonHoc SDMon = new SuaDiemMonHoc();
            SDMon.Show();
        }
    }
}
