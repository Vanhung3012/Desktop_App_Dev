using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoiLyThuyetSo2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frm35ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frm35();
            form.ShowDialog();
        }

        private void frm42ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frm42();
            form.ShowDialog();
        }

        private void frm48ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frm48();
            form.ShowDialog();
        }

        private void frm52ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frm52();
            form.ShowDialog();
        }

        private void frm56ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frm56();
            form.ShowDialog();
        }

        private void frm57ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frm57();
            form.ShowDialog();
        }

        private void frm60ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frm60();
            form.ShowDialog();
        }
    }
}
