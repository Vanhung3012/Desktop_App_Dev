﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked)
            MessageBox.Show("Bạn đã chọn giới tính Nam","Thông báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNu.Checked)
            MessageBox.Show("Bạn đã chọn giới tính Nữ", "Thông báo");
        }

     

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if (rdDo.Checked)
                txtHopMau.BackColor = Color.Red;
            else if (rdXanh.Checked)
                txtHopMau.BackColor = Color.Green;
            else if (rdVang.Checked)
                txtHopMau.BackColor = Color.Yellow;
            else if (rdXanhDuong.Checked)
                txtHopMau.BackColor = Color.Blue;
           

           else
                txtHopMau.BackColor= Color.Orange;
                    
                }

        private void rdDo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }